using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FileAid.Models;

namespace FileAid.GUI
{
    public partial class FormFileAidViewFiles : Form
    {
        private string caption = "FileAid Linked Files";
        private FileLink myLink;
        private List<TrackedFile> filesInLink;
        public FormFileAidViewFiles(int linkID)
        {
            InitializeComponent();

            myLink = LinkManager.GetLink(linkID);
            if (myLink == null) return;
            lblGroupName.Text = (string.IsNullOrEmpty(myLink.LinkMemo) ? "Unnamed Group" : myLink.LinkMemo);
        }

        private void FillListView() {
            ViewFileslistView.Items.Clear();
            try {
                filesInLink = myLink.GetFiles();
                if (filesInLink == null || filesInLink.Count == 0) return;
                foreach (var file in filesInLink) {
                    string[] fileDetails = new string[6];
                    fileDetails[0] = file.Filename;
                    fileDetails[1] = file.FileExtension;
                    fileDetails[2] = file.FilePath;
                    fileDetails[3] = file.FileSize.ToString();
                    fileDetails[4] = file.ModifiedOn.ToString();
                    fileDetails[5] = (file.TrackingDisabledOn > new DateTime()) ? "X" : "";
                    ListViewItem row = new ListViewItem(fileDetails);
                    row.Tag = file.FileID;
                    ViewFileslistView.Items.Add(row);
                }
            }
            catch (SqlException) {
                Messenger.ShowDbMsg();
            }
        }

        private void FormFileAidViewFiles_Load(object sender, EventArgs e)
        {
            AddLinktoolTip.SetToolTip(btnRemoveFile, "Remove file from group");
            AddLinktoolTip.SetToolTip(btnClose, "Close");

            FillListView();
        }

        private void btnClose_Cancel(object sender, EventArgs e) {
            Close();
        }

        private void btnRemoveFile_Click(object sender, EventArgs e) {
            if (filesInLink == null || filesInLink.Count == 0) return;
            string prompt = "Select a file to remove from group.";
            bool isSelected = ForceSingleSelection(prompt);
            if (!isSelected) return;

            try {
                // Get selected item / row
                var selected = ViewFileslistView.SelectedItems;
                if (selected.Count != 1) return;
                ListViewItem row = selected[0];

                // Retrieve tracked file for selected row
                int fileID = (int)row.Tag;
                TrackedFile tf = FileManager.GetFile(fileID);
                if (tf == null) return;

                // Confirm user wants to remove file
                string removePrompt = $"Remove {tf.Filename}.{tf.FileExtension} from group?";
                bool wantsRemoved = (Messenger.ShowYesNo(removePrompt, caption) == DialogResult.Yes);
                if (!wantsRemoved) return;

                // remove file from group
                bool wasRemoved = myLink.RemoveFiles(new List<int> { tf.FileID });
                if (wasRemoved) {
                    LogFileRemoval(myLink, tf);
                    FillListView(); // Refresh GUI
                } else {
                    Messenger.Show("Unable to remove file from group.", caption);
                }
            }
            catch (SqlException) {
                Messenger.ShowDbMsg();
            }
        }

        private bool ForceSingleSelection(string prompt) {
            bool isSelected = (ViewFileslistView.SelectedItems.Count == 1);
            if (isSelected) return true;
            Messenger.Show(prompt, caption);
            return false;
        }
        

        private bool LogFileRemoval(FileLink link, TrackedFile tf) {
            Event ev = new Event();
            ev.EventTypeID = EventTypes.FileLinkLeftGroup;
            ev.LinkID = link.LinkMemoID;
            ev.FileID = tf.FileID;
            ev.OccurredOn = DateTime.Now;
            ev.Description = $"File {tf.Filename}.{tf.FileExtension} removed from group: ID {link.LinkMemoID}, '{link.LinkMemo}'";
            bool wasLogged = Logger.Log(ev);
            return wasLogged;
        }

        private void btnReport_Click(object sender, EventArgs e) {
            FormFileAidRptLinkedFiles rptForm = new FormFileAidRptLinkedFiles(ViewFileslistView.Items,
                lblGroupName.Text);
            rptForm.ShowDialog();
            //Messenger.Show("Placeholder for Events report", caption);
            Report eventsRpt = ReportManager.GetReportByName("Linked Files");
            if (eventsRpt == null) return; // Could not find report
            bool wasLogged = LogReportRun(eventsRpt.ReportID, eventsRpt.Name);
            if (wasLogged) FillListView(); // Refresh GUI
        }

        private bool LogReportRun(int reportID, string reportName) {
            Event ev = new Event();
            ev.EventTypeID = EventTypes.ReportRun;
            ev.ReportID = reportID;
            ev.OccurredOn = DateTime.Now;
            ev.Description = $"Report run: {reportName}";
            bool wasLogged = Logger.Log(ev);
            return wasLogged;
        }
    }
}
