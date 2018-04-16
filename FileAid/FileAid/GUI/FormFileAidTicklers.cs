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
    public partial class FormFileAidTicklers : Form
    {
        private string caption = "FileAid Ticklers";
        public FormFileAidTicklers()
        {
            InitializeComponent();
        }

        private void FormFileAidTicklers_Load(object sender, EventArgs e)
        {
            TicklerstoolTip.SetToolTip(btnPushToOutlook, "Push to outlook");
            TicklerstoolTip.SetToolTip(btnResolved, "Mark as resolved");

            FillListView();
        }

        private void btnPushToOutlook_Click(object sender, EventArgs e) {
            if (TicklerslistView.SelectedItems.Count != 1) {
                Models.Messenger.Show("Please select a reminder to push.", caption);
                return;
            }
            int remID = (int)TicklerslistView.SelectedItems[0].Tag;
            try {
                Models.Reminder rem = Models.ReminderManager.GetReminder(remID);
                bool wasPushed = rem.Push();
                if (wasPushed) {
                    LogReminderPushed(rem);
                    // Refresh list
                    FillListView();
                }
            }
            catch (SqlException) {
                Models.Messenger.ShowDbMsg();
            }
        }

        private bool LogReminderPushed(Reminder rem) {
            Event ev = new Event();
            ev.EventTypeID = EventTypes.ReminderPushed;
            ev.OccurredOn = DateTime.Now;
            ev.ReminderID = rem.ReminderID;
            ev.Description = $"Reminder pushed to Outlook: {rem.Name}";
            bool wasLogged = Logger.Log(ev);
            return wasLogged;
        }

        private void btnResolved_Click(object sender, EventArgs e) {
            if (TicklerslistView.SelectedItems.Count != 1) {
                Models.Messenger.Show("Please select a reminder to resolve.", caption);
                return;
            }
            try {
                int remID = (int)TicklerslistView.SelectedItems[0].Tag;
                Models.Reminder rem = Models.ReminderManager.GetReminder(remID);
                bool wasResolved = rem.Resolve();
                if (wasResolved) {
                    LogReminderResolved(rem);
                    // Refresh list
                    FillListView();
                }
            }
            catch (SqlException) {
                Models.Messenger.ShowDbMsg();
            }
        }

        private bool LogReminderResolved(Reminder rem) {
            Event ev = new Event();
            ev.EventTypeID = EventTypes.ReminderResolved;
            ev.OccurredOn = DateTime.Now;
            ev.ReminderID = rem.ReminderID;
            ev.Description = $"Reminder resolved: {rem.Name}";
            bool wasLogged = Logger.Log(ev);
            return wasLogged;
        }

        private void FillListView() {
            try {
                TicklerslistView.Items.Clear();
                List<Models.Reminder> allReminders = Models.ReminderManager.GetReminders();
                if (allReminders == null) {
                    // No reminders found
                    return;
                }
                foreach (var rem in allReminders) {
                    var files = rem.GetFiles();
                    bool hasFiles = (files != null && files.Count > 0);
                    if (!hasFiles) {
                        // If no files, silently delete the reminder and don't add to list
                        rem.RemoveFiles(new List<int> { -999 }); // removing any file checks for deletion
                        continue;
                    }

                    string[] remDetails = new string[6];
                    remDetails[0] = rem.Name;
                    remDetails[1] = rem.Memo;
                    remDetails[2] = (files == null) ? "0" : files.Count.ToString();
                    remDetails[3] = rem.DueOn.ToString();
                    remDetails[4] = (rem.ResolvedOn > new DateTime()) ? "X" : "";
                    remDetails[5] = (rem.PushedOn > new DateTime()) ? "X" : "";
                    ListViewItem row = new ListViewItem(remDetails);
                    row.Tag = rem.ReminderID;
                    TicklerslistView.Items.Add(row);
                }
            }
            catch (SqlException) {
                Models.Messenger.ShowDbMsg();
            }
        }

        private void btnViewFiles_Click(object sender, EventArgs e) {
            string prompt = "Select a reminder to view its files.";
            bool isSelected = ForceSingleSelection(prompt);
            if (!isSelected) return;

            try {
                ListViewItem row = TicklerslistView.SelectedItems[0];
                int reminderID = (int)row.Tag;
                Reminder rem = ReminderManager.GetReminder(reminderID);
                if (rem == null) return;
                FormFileAidViewReminder viewRem = new FormFileAidViewReminder(rem);
                viewRem.ShowDialog();

                // Always refresh gui here because reminder may have been removed
                FillListView();
            }
            catch (SqlException) {
                Messenger.ShowDbMsg();
            }
        }

        private bool ForceSingleSelection(string prompt) {
            bool isSelected = (TicklerslistView.SelectedItems.Count == 1);
            if (isSelected) return true;
            Messenger.Show(prompt, caption);
            return false;
        }

        private void btnReport_Click(object sender, EventArgs e) {
            FormFileAidRptReminders remRpt = new FormFileAidRptReminders(TicklerslistView.Items);
            remRpt.ShowDialog();
            //Messenger.Show("Placeholder for Reminders report.", caption);
            // Log report run
            Report rpt = ReportManager.GetReportByName("Reminders");
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
