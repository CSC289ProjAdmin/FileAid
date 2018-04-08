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

namespace FileAid.GUI
{
    public partial class FormFileAidMain : Form
    {
        public FormFileAidMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            FormFileAidNewFile newfile = new FormFileAidNewFile();
            newfile.ShowDialog();
        }

        private void btnAddLink_Click(object sender, EventArgs e) {
            FormFileAidLink newLink = new FormFileAidLink();
            newLink.ShowDialog();
        }

        private void btnAddReminder_Click(object sender, EventArgs e) {
            FormFileAidReminder newReminder = new FormFileAidReminder();
            newReminder.ShowDialog();
        }

        private void FormFileAidMain_Load(object sender, EventArgs e)
        {
            FileAidMaintoolTip.SetToolTip(btnAdd, "Add new File");
            FileAidMaintoolTip.SetToolTip(btnStopTrack, "Stop file tracking");
            FileAidMaintoolTip.SetToolTip(btnTrack, "Restart file tracking");
            FileAidMaintoolTip.SetToolTip(btnAddLink, "Add file link");
            FileAidMaintoolTip.SetToolTip(btnAddReminder, "Add Reminder to files");
            FileAidMaintoolTip.SetToolTip(txtMemo, "Please enter the memo");
            FileAidMaintoolTip.SetToolTip(btnUpdate, "Update the memo");
            FileAidMaintoolTip.SetToolTip(btnMainPrintRepo, "Print report");
            FileAidMaintoolTip.SetToolTip(InactivecheckBox, "Show Inactive Files");
            FileAidMaintoolTip.SetToolTip(StartdateTimePicker, "Select date modified start date");
            FileAidMaintoolTip.SetToolTip(EnddateTimePicker, "Select date modified end date");
            FileAidMaintoolTip.SetToolTip(txtWild, "Please enter file name");
            FileAidMaintoolTip.SetToolTip(btnWildSearch, "Search the file");
            FileAidMaintoolTip.SetToolTip(btnViewHistory, "View history");

            try {
                List<Models.TrackedFile> allFiles = Models.FileManager.GetFiles();
                if (allFiles == null) {
                    // No files in system
                    return;
                }
                foreach (var file in allFiles) {
                    string[] fileDetails = new string[6];
                    fileDetails[0] = file.Filename;
                    fileDetails[1] = file.FileExtension;
                    fileDetails[2] = file.FilePath;
                    fileDetails[3] = file.FileSize.ToString();
                    fileDetails[4] = file.ModifiedOn.ToString();
                    fileDetails[5] = (file.TrackingDisabledOn > new DateTime()) ? "X" : "";
                    ListViewItem row = new ListViewItem(fileDetails);
                    MainListView.Items.Add(row);
                }
            }
            catch (SqlException) {
                Models.Messenger.ShowDbMsg();
            }
        }

        private void btnViewHistory_Click(object sender, EventArgs e) {
            FormFileAidViewHistory history = new FormFileAidViewHistory();
            history.ShowDialog();
        }
    }
}
