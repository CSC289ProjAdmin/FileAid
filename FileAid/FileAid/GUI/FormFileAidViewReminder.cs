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
    public partial class FormFileAidViewReminder : Form
    {
        private string caption = "FileAid View Reminder";
        private Reminder myRem;
        public FormFileAidViewReminder(Reminder rem)
        {
            InitializeComponent();
            myRem = rem;
        }

        private void FormFileAidReminder_Load(object sender, EventArgs e)
        {
            if (myRem == null) return;
            ReminderdateTimePicker.Value = myRem.DueOn;
            ReminderdateTimePicker.Enabled = false;

            lblName.Text = myRem.Name;
            txtReminderName.Text = myRem.Name;
            txtReminderName.Enabled = false;

            txtDescription.Text = myRem.Memo;
            txtDescription.Enabled = false;

            FillListView();
        }

        private void FillListView() {
            ReminderlistView.Items.Clear();
            try {
                List<TrackedFile> remFiles = myRem.GetFiles();
                if (remFiles == null) return; // No files attached to reminder
                foreach (var file in remFiles) {
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

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnRemoveFile_Click(object sender, EventArgs e) {
            var listitems = ReminderlistView.Items;        
            if (listitems == null || listitems.Count == 0) return;
            string prompt = "Select a file to remove from reminder.";
            bool isSelected = ForceSingleSelection(prompt);
            if (!isSelected) return;

            try {
                // Get selected item / row
                var selected = ReminderlistView.SelectedItems;
                if (selected.Count != 1) return;
                ListViewItem row = selected[0];

                // Retrieve tracked file for selected row
                int fileID = (int)row.Tag;
                TrackedFile tf = FileManager.GetFile(fileID);
                if (tf == null) return;

                // Confirm user wants to remove file
                string removePrompt = $"Remove {tf.Filename}.{tf.FileExtension} from reminder?";
                bool wantsRemoved = (Messenger.ShowYesNo(removePrompt, caption) == DialogResult.Yes);
                if (!wantsRemoved) return;

                // remove file from group
                bool wasRemoved = myRem.RemoveFiles(new List<int> { tf.FileID });
                if (wasRemoved) {
                    LogFileRemoval(myRem, tf);
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
            bool isSelected = (ReminderlistView.SelectedItems.Count == 1);
            if (isSelected) return true;
            Messenger.Show(prompt, caption);
            return false;
        }

        private bool LogFileRemoval(Reminder rem, TrackedFile tf) {
            Event ev = new Event();
            ev.EventTypeID = EventTypes.FileReminderSet;
            ev.ReminderID = rem.ReminderID;
            ev.FileID = tf.FileID;
            ev.OccurredOn = DateTime.Now;
            ev.Description = $"File {tf.Filename}.{tf.FileExtension} removed from reminder: {rem.Name}";
            bool wasLogged = Logger.Log(ev);
            return wasLogged;
        }

        private void btnReport_Click(object sender, EventArgs e) {
            Messenger.Show("Placeholder for Reminder Details report", caption);
            // Log report run
        }
    }
}
