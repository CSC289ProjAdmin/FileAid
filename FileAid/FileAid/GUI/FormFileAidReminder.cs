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
    public partial class FormFileAidReminder : Form
    {
        private string caption = "FileAid Reminders";
        private List<int> selectedIDs;
        private List<TrackedFile> filesToLink;
        public FormFileAidReminder(List<int> fileIDs)
        {
            InitializeComponent();
            selectedIDs = fileIDs;
            filesToLink = new List<TrackedFile>();
        }

        private void FormFileAidReminder_Load(object sender, EventArgs e)
        {
            RemindertoolTip.SetToolTip(ReminderdateTimePicker, "Select reminder due");
            RemindertoolTip.SetToolTip(txtDescription, "Enter description");
            RemindertoolTip.SetToolTip(txtReminderName, "Enter reminder name");
            RemindertoolTip.SetToolTip(btnAddReminder, "Add reminder");
            RemindertoolTip.SetToolTip(btnReminderCancel, "Cancel reminder");

            // Due date must be greater than today for new reminders
            ReminderdateTimePicker.MinDate = DateTime.Today;

            FillListView();
        }

        private void FillListView() {
            if (selectedIDs == null) return; // No files to group

            try {
                ReminderlistView.Items.Clear();
                filesToLink.Clear();
                foreach (int id in selectedIDs) {
                    TrackedFile tf = FileManager.GetFile(id);
                    if (tf == null) continue;
                    filesToLink.Add(tf);
                }
                if (filesToLink.Count == 0) return; // No files found

                foreach (var file in filesToLink) {
                    string[] fileDetails = new string[6];
                    fileDetails[0] = file.Filename;
                    fileDetails[1] = file.FileExtension;
                    fileDetails[2] = file.FilePath;
                    fileDetails[3] = file.FileSize.ToString();
                    fileDetails[4] = file.ModifiedOn.ToString();
                    fileDetails[5] = (file.TrackingDisabledOn > new DateTime()) ? "X" : "";
                    ListViewItem row = new ListViewItem(fileDetails);
                    row.Tag = file.FileID;
                    ReminderlistView.Items.Add(row);
                }
            }
            catch (SqlException) {
                Messenger.ShowDbMsg();
            }
        }

        private void btnReminderCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnAddReminder_Click(object sender, EventArgs e) {
            if (filesToLink.Count < 1) return; // Need at least one file to create reminder

            // Validate fields
            DateTime dueDate = ReminderdateTimePicker.Value;
            if (dueDate < DateTime.Today) {
                Messenger.Show("Due date must be greater than or equal to today.", caption);
                return;
            }
            string reminderName = txtReminderName.Text.Trim();
            if (string.IsNullOrEmpty(reminderName)) {
                Messenger.Show("Reminder name is required.", caption);
                return;
            }

            // Add reminder
            List<int> memberIDs = new List<int>();
            foreach (var file in filesToLink) {
                memberIDs.Add(file.FileID);
            }
            if (memberIDs.Count < 1) return; // Just in case

            string reminderMemo = txtDescription.Text.Trim();
            Reminder newRem = null;
            if (string.IsNullOrEmpty(reminderMemo)) {
                newRem = ReminderManager.AddReminder(memberIDs, reminderName, dueDate);
            } else {
                newRem = ReminderManager.AddReminder(memberIDs, reminderName, dueDate, reminderMemo);
            }
            if (newRem == null) {
                Messenger.Show("Could not create reminder.\n\n" +
                    "Check that chosen files do not have existing, unresolved reminders.", caption);
                return;
            }

            // Log, notify and close
            var files = newRem.GetFiles();
            int nFiles = (files == null) ? 0 : files.Count;
            LogReminderCreation(newRem.ReminderID, nFiles, newRem.Name);
            Messenger.Show($"New reminder created for {nFiles} file(s).", caption);
            DialogResult = DialogResult.OK;
            Close();
        }

        private bool LogReminderCreation(int reminderID, int fileCount, string name) {
            Event ev = new Event();
            ev.EventTypeID = EventTypes.ReminderAdded;
            ev.OccurredOn = DateTime.Now;
            ev.ReminderID = reminderID;
            ev.Description = $"Reminder '{name}' added to {fileCount} file(s).";
            bool wasLogged = Logger.Log(ev);
            return wasLogged;
        }
    }
}
