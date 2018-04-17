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
    public partial class FormFileAidFileLinks : Form
    {
        private string caption = "FileAid Links / Groups";
        private List<FileLink> myLinks;
        public FormFileAidFileLinks(List<FileLink> links)
        {
            InitializeComponent();
            myLinks = links;
        }

        private void FormFileAidFileLinks_Load(object sender, EventArgs e) {
            FillListView();
        }

        private void FillListView() {
            try {
                FileLinkslistView.Items.Clear();
                if (myLinks == null) {
                    // No links in system yet.
                    return;
                }
                foreach (var link in myLinks) {
                    // Need to get current info on each refresh
                    var currLink = LinkManager.GetLink(link.LinkMemoID);
                    if (currLink == null) continue;
                    string[] remDetails = new string[2];
                    remDetails[0] = currLink.LinkMemo;
                    if (string.IsNullOrEmpty(remDetails[0]))
                        remDetails[0] = "(No Description Given)";
                    remDetails[1] = link.GetFiles().Count.ToString();
                    ListViewItem row = new ListViewItem(remDetails);
                    row.Tag = link.LinkMemoID;
                    FileLinkslistView.Items.Add(row);
                }
            }
            catch (SqlException) {
                Messenger.ShowDbMsg();
            }
        }

        private void FileLinkslistView_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                var selected = FileLinkslistView.SelectedItems;
                if (selected.Count != 1) return;
                ListViewItem row = selected[0];
                int linkID = (int)row.Tag;
                FileLink link = LinkManager.GetLink(linkID);
                if (link == null) return;
                txtMemo.Text = link.LinkMemo;
            }
            catch (SqlException) {
                Messenger.ShowDbMsg();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            if (myLinks == null || myLinks.Count == 0) return;

            // Handle changing and removing link memo
            string prompt = "Select a link / group to update its memo.";
            bool isSelected = ForceSingleSelection(prompt);
            if (!isSelected) return;

            try {
                // Get selected item / row
                var selected = FileLinkslistView.SelectedItems;
                if (selected.Count != 1) return;
                ListViewItem row = selected[0];

                // Retrieve FileLink for selected row
                int linkID = (int)row.Tag;
                FileLink link = LinkManager.GetLink(linkID);
                if (link == null) return;

                // Compare memo field with existing memo
                string newMemo = txtMemo.Text.Trim();
                string originalMemo = link.LinkMemo ?? "";
                bool isSameMemo = (newMemo == originalMemo);
                if (isSameMemo) return;

                // Remove memo if new is empty. Update otherwise.
                bool wantsRemoved = (string.IsNullOrEmpty(newMemo));
                if (wantsRemoved) {
                    bool wasRemoved = link.RemoveMemo();
                    if (wasRemoved) {
                        LogMemoRemoval(link.LinkMemoID, originalMemo);
                        string removedPrompt = $"Memo removed for link number {link.LinkMemoID}";
                        Messenger.Show(removedPrompt, caption);
                    }
                } else {
                    bool wasUpdated = link.UpdateMemo(newMemo);
                    if (wasUpdated) {
                        LogMemoChanged(link.LinkMemoID, originalMemo, newMemo);
                        string updatedPrompt = $"Memo updated for link number {link.LinkMemoID}";
                        Messenger.Show(updatedPrompt, caption);
                    }
                }
                FillListView(); // Refresh GUI
                txtMemo.Text = "";
            }
            catch (SqlException) {
                Messenger.ShowDbMsg();
            }
        }

        private bool ForceSingleSelection(string prompt) {
            bool isSelected = (FileLinkslistView.SelectedItems.Count == 1);
            if (isSelected) return true;
            Messenger.Show(prompt, caption);
            return false;
        }

        private bool LogMemoRemoval(int linkID, string originalMemo) {
            Event ev = new Event();
            ev.EventTypeID = EventTypes.FileLinkMemoRemoved;
            ev.LinkID = linkID;
            ev.OccurredOn = DateTime.Now;
            ev.Description = $"Link memo removed";
            ev.Initial = originalMemo;
            bool wasLogged = Logger.Log(ev);
            return wasLogged;
        }

        private bool LogMemoChanged(int linkID, string originalMemo, string newMemo) {
            Event ev = new Event();
            ev.EventTypeID = EventTypes.FileLinkMemoUpdated;
            ev.LinkID = linkID;
            ev.OccurredOn = DateTime.Now;
            ev.Description = $"Link memo changed to: {newMemo}";
            ev.Initial = originalMemo;
            ev.New = newMemo;
            bool wasLogged = Logger.Log(ev);
            return wasLogged;
        }

        private void btnViewFiles_Click(object sender, EventArgs e) {
            if (myLinks == null || myLinks.Count == 0) return;
            string prompt = "Select a link / group to view its member files.";
            bool isSelected = ForceSingleSelection(prompt);
            if (!isSelected) return;

            try {
                // Get selected item / row
                var selected = FileLinkslistView.SelectedItems;
                if (selected.Count != 1) return;
                ListViewItem row = selected[0];

                // View members files for selected row
                int linkID = (int)row.Tag;
                FormFileAidViewFiles viewFiles = new FormFileAidViewFiles(linkID);
                viewFiles.ShowDialog();
                FillListView(); // Refresh GUI
                txtMemo.Text = "";
            }
            catch (SqlException) {
                Messenger.ShowDbMsg();
            }
        }

        private void btnReprot_Click(object sender, EventArgs e) {
            FormFileAidRptFileLinks rptForm = new FormFileAidRptFileLinks(FileLinkslistView.Items);
            rptForm.ShowDialog();
            //Messenger.Show("Placeholder for FileLinks report", caption);
            // Log report run
            Report rpt = ReportManager.GetReportByName("File Links");
            if (rpt == null) return; // Could not find report
            bool wasLogged = LogReportRun(rpt.ReportID, rpt.Name);
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
