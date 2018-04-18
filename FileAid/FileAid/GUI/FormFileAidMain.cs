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
using System.Text.RegularExpressions;

namespace FileAid.GUI
{
    public partial class FormFileAidMain : Form
    {
        private string caption = "FileAid Tracked Files";
        public FormFileAidMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            FormFileAidNewFile newfile = new FormFileAidNewFile();
            bool wasAdded = (newfile.ShowDialog() == DialogResult.OK);
            if (wasAdded) FillListView(); // Refresh GUI
        }

        private void btnAddLink_Click(object sender, EventArgs e) {
            List<int> fileIDs = new List<int>();
            var checkedItems = MainListView.CheckedItems;
            if (checkedItems.Count < 2) { // Need at least 2 files to create link
                Messenger.Show("Check at least 2 files to link together.", caption);
                return;
            }
            foreach (ListViewItem item in checkedItems) {
                int fileID = (int)item.Tag;
                fileIDs.Add(fileID);
            }
            FormFileAidLink newLink = new FormFileAidLink(fileIDs);
            bool wasAdded = (newLink.ShowDialog() == DialogResult.OK);
            if (wasAdded) FillListView(); // Refresh GUI -- Should this really refresh?
        }

        private void btnAddReminder_Click(object sender, EventArgs e) {
            List<int> fileIDs = new List<int>();
            var checkedItems = MainListView.CheckedItems;
            if (checkedItems.Count < 1) { 
                Messenger.Show("Check at least 1 file to create reminder.", caption);
                return;
            }
            foreach (ListViewItem item in checkedItems) {
                int fileID = (int)item.Tag;
                // Check if file already has a reminder
                TrackedFile tf = FileManager.GetFile(fileID);
                Reminder rem = ReminderManager.GetReminder(tf.ReminderID);
                bool hasReminder = (rem != null && rem.ResolvedOn == new DateTime());
                if (hasReminder) {
                    Messenger.Show("One of more of the chosen files already has an existing, unresolved reminder.\n\n"
                        , caption);
                    return;
                }
                fileIDs.Add(fileID);
            }

            FormFileAidReminder newReminder = new FormFileAidReminder(fileIDs);
            bool wasAdded = (newReminder.ShowDialog() == DialogResult.OK);
            if (wasAdded) FillListView(); // Refresh GUI -- Should this really refresh?
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
            FileAidMaintoolTip.SetToolTip(txtWild, "Enter a search pattern");
            FileAidMaintoolTip.SetToolTip(btnWildSearch, "Search filenames, paths, and memos");
            FileAidMaintoolTip.SetToolTip(btnViewHistory, "View history");

            // Give values to controls
            //EnddateTimePicker.Value = DateTime.Now;
            EnddateTimePicker.Value = DateTime.Today + TimeSpan.FromDays(1);
            StartdateTimePicker.Value = EnddateTimePicker.Value.Date - TimeSpan.FromDays(30);
            Configs settings = ConfigManager.GetConfigs();
            InactivecheckBox.Checked = (settings == null) ? false : settings.ShowInactive;

            FillListView();
        }

        private void FillListView() {
            try {
                MainListView.Items.Clear();
                List<TrackedFile> allFiles = FileManager.GetFiles();
                if (allFiles == null) return; // No files in system
                // First filter by date range
                var filteredFiles = from file in allFiles
                                    where (file.ModifiedOn > StartdateTimePicker.Value
                                    && file.ModifiedOn < EnddateTimePicker.Value)
                                    select file;
                // Second, remove inactive files if necessary
                bool wantsInactive = InactivecheckBox.Checked;
                if (!wantsInactive) { // Remove inactive files
                    filteredFiles = from file in filteredFiles
                                    where (file.TrackingDisabledOn == new DateTime())
                                    select file;
                }
                string searchPattern = txtWild.Text.Trim();
                if (!string.IsNullOrEmpty(searchPattern)) {
                    filteredFiles = from file in filteredFiles
                                    where (
                                        Regex.IsMatch(file.Filename+"."+file.FileExtension,
                                            WildcardToRegular(searchPattern), RegexOptions.IgnoreCase) ||
                                        Regex.IsMatch(file.FilePath,
                                            WildcardToRegular(searchPattern), RegexOptions.IgnoreCase) ||
                                        Regex.IsMatch(string.IsNullOrEmpty(file.FileMemo) ? "" : file.FileMemo,
                                            WildcardToRegular(searchPattern), RegexOptions.IgnoreCase)
                                    )
                                    select file;
                }

                if (filteredFiles == null) return; // No files to show
                foreach (var file in filteredFiles) {
                    string[] fileDetails = new string[8];
                    fileDetails[0] = file.Filename;
                    fileDetails[1] = file.FileExtension;
                    fileDetails[2] = file.FilePath;
                    fileDetails[3] = file.FileSize.ToString();
                    fileDetails[4] = file.ModifiedOn.ToString();
                    var links = file.GetLinks();
                    bool hasLinks = (links != null && links.Count > 0);
                    fileDetails[5] = hasLinks ? links.Count.ToString()  : "";
                    var rem = file.GetReminder();
                    bool hasOpenReminder = (rem != null && rem.ResolvedOn == new DateTime());
                    fileDetails[6] = hasOpenReminder ? "X" : "";
                    fileDetails[7] = (file.TrackingDisabledOn > new DateTime()) ? "X" : "";
                    ListViewItem row = new ListViewItem(fileDetails);
                    row.Tag = file.FileID;
                    MainListView.Items.Add(row);
                }
            }
            catch (SqlException) {
                Messenger.ShowDbMsg();
            }
        }

        private void btnViewHistory_Click(object sender, EventArgs e) {
            string prompt = "Check a single file to view its update history.";
            bool isSelected = ForceSingleSelection(prompt);
            if (!isSelected) return;

            try {
                ListViewItem row = MainListView.CheckedItems[0];
                int fileID = (int)row.Tag;
                TrackedFile tf = FileManager.GetFile(fileID);
                if (tf == null) return;
                FormFileAidViewHistory history = new FormFileAidViewHistory(tf);
                history.ShowDialog();
            }
            catch (SqlException) {
                Messenger.ShowDbMsg();
            }
        }

        private void btnStopTrack_Click(object sender, EventArgs e) {
            string prompt = "Check a single file to mark inactive.";
            bool isSelected = ForceSingleSelection(prompt);
            if (!isSelected) return;

            try {
                ListViewItem row = MainListView.CheckedItems[0];
                int fileID = (int)row.Tag;
                TrackedFile tf = FileManager.GetFile(fileID);
                if (tf == null) return;
                bool wasStopped = tf.StopTracking(); // Will only stop if file is active / being tracked
                if (wasStopped) {
                    bool wasLogged = LogTrackingStopped(tf);
                    if (!wasLogged) {
                        Messenger.Show("Failed to log tracking event.", caption);
                    }
                    FillListView(); // Refresh GUI
                }
            }
            catch (SqlException) {
                Messenger.ShowDbMsg();
            }
        }

        private bool ForceSingleSelection(string prompt) {
            bool isChecked = (MainListView.CheckedItems.Count == 1);
            //bool isSelected = (MainListView.SelectedItems.Count == 1);
            if (isChecked) return true;
            Messenger.Show(prompt, caption);
            return false;
        }

        private bool LogTrackingStopped(TrackedFile tf) {
            Event ev = new Event();
            ev.EventTypeID = EventTypes.FileTrackingStopped;
            ev.FileID = tf.FileID;
            ev.OccurredOn = DateTime.Now;
            ev.Description = $"Tracking stopped for {tf.Filename}.{tf.FileExtension}";
            bool wasLogged = Logger.Log(ev);
            return wasLogged;
        }

        private void btnTrack_Click(object sender, EventArgs e) {
            string prompt = "Check a single inactive file to begin tracking.";
            bool isSelected = ForceSingleSelection(prompt);
            if (!isSelected) return;

            try {
                ListViewItem row = MainListView.CheckedItems[0];
                int fileID = (int)row.Tag;
                TrackedFile tf = FileManager.GetFile(fileID);
                if (tf == null) return;
                bool wasStarted = tf.StartTracking(); // Will only start if file is inactive / not being tracked
                if (wasStarted) {
                    bool wasLogged = LogTrackingStarted(tf);
                    if (!wasLogged) {
                        Messenger.Show("Failed to log tracking event.", caption);
                    }
                    FillListView(); // Refresh GUI
                }
            }
            catch (SqlException) {
                Messenger.ShowDbMsg();
            }
        }

        private bool LogTrackingStarted(TrackedFile tf) {
            Event ev = new Event();
            ev.EventTypeID = EventTypes.FileTrackingStarted;
            ev.FileID = tf.FileID;
            ev.OccurredOn = DateTime.Now;
            ev.Description = $"Tracking started for {tf.Filename}.{tf.FileExtension}";
            bool wasLogged = Logger.Log(ev);
            return wasLogged;
        }

        private void btnMainPrintRepo_Click(object sender, EventArgs e) {
            // Create objects to give report, attach them to it, attach report to viewer and open it
            FormFileAidRptViewer rptForm = new FormFileAidRptViewer(MainListView.Items);
            rptForm.ShowDialog();
            //Messenger.Show("Placeholder for Tracked Files report", caption);
            Report eventsRpt = ReportManager.GetReportByName("Tracked Files");
            if (eventsRpt == null) return; // Could not find report
            bool wasLogged = LogReportRun(eventsRpt.ReportID, eventsRpt.Name);
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

        private void btnUpdate_Click(object sender, EventArgs e) {
            string prompt = "Check a single file to update its memo.";
            bool isSelected = ForceSingleSelection(prompt);
            if (!isSelected) return;

            try {
                // Get selected item / row
                var selected = MainListView.CheckedItems;
                if (selected.Count != 1) return;
                ListViewItem row = selected[0];

                // Retrieve Tracked File for selected row
                int fileID = (int)row.Tag;
                TrackedFile tf = FileManager.GetFile(fileID);
                if (tf == null) return;

                // Compare memo field with existing memo
                string newMemo = txtMemo.Text.Trim();
                string originalMemo = tf.FileMemo ?? "";
                bool isSameMemo = (newMemo == originalMemo);
                if (isSameMemo) return;

                // Remove memo if new is empty. Update otherwise.
                bool wantsRemoved = (string.IsNullOrEmpty(newMemo));
                if (wantsRemoved) {
                    bool wasRemoved = tf.RemoveMemo();
                    if (wasRemoved) {
                        LogMemoRemoval(tf.FileID, originalMemo);
                        string removedPrompt = $"Memo removed for\n\n{tf.Filename}.{tf.FileExtension}";
                        Messenger.Show(removedPrompt, caption);
                    }
                } else {
                    bool wasUpdated = tf.UpdateMemo(newMemo);
                    if (wasUpdated) {
                        LogMemoChanged(tf.FileID, originalMemo, newMemo);
                        string updatedPrompt = $"Memo updated for\n\n{tf.Filename}.{tf.FileExtension}";
                        Messenger.Show(updatedPrompt, caption);
                    }
                }
            }
            catch (SqlException) {
                Messenger.ShowDbMsg();
            }
        }

        private bool LogMemoRemoval(int fileID, string originalMemo) {
            Event ev = new Event();
            ev.EventTypeID = EventTypes.FileMemoRemoved;
            ev.FileID = fileID;
            ev.OccurredOn = DateTime.Now;
            ev.Description = $"Memo removed";
            ev.Initial = originalMemo;
            bool wasLogged = Logger.Log(ev);
            return wasLogged;
        }

        private bool LogMemoChanged(int fileID, string originalMemo, string newMemo) {
            Event ev = new Event();
            ev.EventTypeID = EventTypes.FileMemoUpdated;
            ev.FileID = fileID;
            ev.OccurredOn = DateTime.Now;
            ev.Description = $"Memo changed to: {newMemo}";
            ev.Initial = originalMemo;
            ev.New = newMemo;
            bool wasLogged = Logger.Log(ev);
            return wasLogged;
        }

        private void MainListView_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                var selected = MainListView.SelectedItems;
                if (selected.Count != 1) return;
                ListViewItem row = selected[0];
                int fileID = (int)row.Tag;
                TrackedFile tf = FileManager.GetFile(fileID);
                if (tf == null) return;
                txtMemo.Text = tf.FileMemo;
            }
            catch (SqlException) {
                Messenger.ShowDbMsg();
            }
        }

        private void InactivecheckBox_CheckedChanged(object sender, EventArgs e) {
            UpdateListView();
        }

        private void btnWildSearch_Click(object sender, EventArgs e) {
            UpdateListView();
        }

        private void UpdateListView() {
            // Validate date range
            bool isValidRange = (StartdateTimePicker.Value <= EnddateTimePicker.Value);
            if (!isValidRange) {
                Messenger.Show("Start date must be less than or equal to end date.", caption);
                return;
            }
            // TODO: Add / validate wildcard filter
            FillListView();
        }

        private void btnViewLinks_Click(object sender, EventArgs e) {
            string prompt = "Check a single file to view its links / groups.";
            bool isSelected = ForceSingleSelection(prompt);
            if (!isSelected) return;

            try {
                ListViewItem row = MainListView.CheckedItems[0];
                bool hasLinks = (row.SubItems[5].Text != ""); // # Links column
                if (!hasLinks) {
                    string noLinksPrompt = "Selected file is not a member of any filelink groups.";
                    Messenger.Show(noLinksPrompt, caption);
                    return;
                }

                int fileID = (int)row.Tag;
                TrackedFile tf = FileManager.GetFile(fileID);
                if (tf == null) return;
                List<FileLink> myLinks = tf.GetLinks();
                FormFileAidFileLinks linkForm = new FormFileAidFileLinks(myLinks);
                linkForm.ShowDialog();

                // Always refresh gui here because links may have been removed
                FillListView();
                // Re-check the selected item if it is still in list
                foreach (ListViewItem item in MainListView.Items) {
                    if ((int)item.Tag == fileID) {
                        item.Checked = true;
                    }
                }
            }
            catch (SqlException) {
                Messenger.ShowDbMsg();
            }
        }

        private void btnViewReminder_Click(object sender, EventArgs e) {
            string prompt = "Check a single file to view its reminder.";
            bool isSelected = ForceSingleSelection(prompt);
            if (!isSelected) return;

            try {
                ListViewItem row = MainListView.CheckedItems[0];
                bool hasReminder = (row.SubItems[6].Text == "X"); // Reminder column
                if (!hasReminder) {
                    string noReminderPrompt = "Selected file does not have an open, unresolved reminder.";
                    Messenger.Show(noReminderPrompt, caption);
                    return;
                }

                int fileID = (int)row.Tag;
                TrackedFile tf = FileManager.GetFile(fileID);
                if (tf == null) return;
                Reminder rem = tf.GetReminder();
                if (rem == null) return;
                FormFileAidViewReminder viewRem = new FormFileAidViewReminder(rem);
                viewRem.ShowDialog();

                // Always refresh gui here because reminder may have been removed
                FillListView();
                // Re-check the selected item if it is still in list
                foreach (ListViewItem item in MainListView.Items) {
                    if ((int)item.Tag == fileID) {
                        item.Checked = true;
                    }
                }
            }
            catch (SqlException) {
                Messenger.ShowDbMsg();
            }
        }

        private static string WildcardToRegular(string value) {
            return "^" + Regex.Escape(value).Replace("\\?", ".").Replace("\\*",".*") + "$";
        }

        private void btnClear_Click(object sender, EventArgs e) {
            var items = MainListView.CheckedItems;
            foreach (ListViewItem item in items) {
                item.Checked = false;
            }
        }
    }
}
