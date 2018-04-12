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
    public partial class FormFileAidDbMgmt : Form
    {
        private string caption = "Database Management";
        public FormFileAidDbMgmt()
        {
            InitializeComponent();
        }

        private void FormFileAidDbMgmt_Load(object sender, EventArgs e)
        {
            DBMantoolTip.SetToolTip(btnBackup, "Backup the Data");
            DBMantoolTip.SetToolTip(btnRestore, "Restore the Data");
            DBMantoolTip.SetToolTip(btnReset, "Reset the Database");
            DBMantoolTip.SetToolTip(btnDbPrintRepo, "Print the report");

            FillListView();
        }

        private void FillListView() {
            try {
                List<Models.Event> allEvents = Models.EventManager.GetEvents();
                if (allEvents == null) return;
                var dbEventIDs = new Models.EventTypes[]{
                    Models.EventTypes.DbBackedUp,
                    Models.EventTypes.DbReset,
                    Models.EventTypes.DbRestored
                };
                var dbEvents = from ev in allEvents
                               where dbEventIDs.Contains(ev.EventTypeID)
                               select ev;
                DBManlistView.Items.Clear();
                if (dbEvents == null || dbEvents.Count() == 0) return; // No database event history
                foreach (var ev in dbEvents) {
                    string[] evDetails = new string[2];
                    evDetails[0] = ev.OccurredOn.ToString();
                    evDetails[1] = ev.Description;
                    ListViewItem row = new ListViewItem(evDetails);
                    DBManlistView.Items.Add(row);
                }
            }
            catch (SqlException) {
                Models.Messenger.ShowDbMsg();
            }
        }

        private void btnBackup_Click(object sender, EventArgs e) {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = $"Choose location to save database backup.";
            if (dlg.ShowDialog() == DialogResult.OK) {
                bool wasBackedUp = Models.DbManager.Backup(dlg.SelectedPath);
                Models.Messenger.Show(wasBackedUp ? "Backup successful." : "Backup failed.", caption);
                bool wasLogged = LogBackupEvent(dlg.SelectedPath);
                if (wasLogged) {
                    FillListView(); // Refresh event list
                } else {
                    Models.Messenger.Show("Failed to log backup event.", caption);
                }
            }
        }

        private void btnRestore_Click(object sender, EventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL Server database backup files|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK) {
                bool wasRestored = Models.DbManager.Restore(dlg.FileName);
                Models.Messenger.Show(wasRestored ? "Restore successful." : "Restore failed.", caption);
                bool wasLogged = LogRestoreEvent(System.IO.Path.GetFileName(dlg.FileName));
                if (wasLogged) {
                    FillListView(); // Refresh event list
                } else {
                    Models.Messenger.Show("Failed to log restore event.", caption);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e) {
            // Prompt twice before resetting
            string firstPrompt = "Resetting the database will:\n"
                + "1) Clear all data\n"
                + "2) Revert FileAid to its initial state\n"
                + "3) Cause FileAid to shutdown.\n\n"
                + "Are you sure you want to reset?";
            string secondPrompt = "Resetting the database is final and cannot be undone.\n\n"
                + "Are you absolutely sure you want to reset?";
            DialogResult dr = Models.Messenger.ShowYesNo(firstPrompt, caption);
            bool wantsReset = (dr == DialogResult.Yes);
            if (!wantsReset) return;
            dr = Models.Messenger.ShowYesNo(secondPrompt, caption);
            wantsReset = (dr == DialogResult.Yes);
            if (!wantsReset) return;

            bool wasReset = Models.DbManager.Reset();
            if (wasReset) {
                bool wasLogged = LogResetEvent();
                if (!wasLogged) Models.Messenger.Show("Failed to log reset event.", "FileAid");
                Models.Messenger.Show("Database has been reset.\n\nFileAid will now shut down.", caption);
                Application.Exit();
            } else {
                Models.Messenger.Show("Failed to reset database.", caption);
            }
        }

        private bool LogBackupEvent(string path) {
            Models.Event ev = new Models.Event();
            ev.EventTypeID = Models.EventTypes.DbBackedUp;
            ev.OccurredOn = DateTime.Now;
            ev.Description = $"Database backed up to {path}";
            bool wasLogged = Models.Logger.Log(ev);
            return wasLogged;
        }

        private bool LogRestoreEvent(string filename) {
            Models.Event ev = new Models.Event();
            ev.EventTypeID = Models.EventTypes.DbRestored;
            ev.OccurredOn = DateTime.Now;
            ev.Description = $"Database restored from {filename}";
            bool wasLogged = Models.Logger.Log(ev);
            return wasLogged;
        }

        private bool LogResetEvent() {
            Models.Event ev = new Models.Event();
            ev.EventTypeID = Models.EventTypes.DbReset;
            ev.OccurredOn = DateTime.Now;
            ev.Description = $"Database reset to initial state";
            bool wasLogged = Models.Logger.Log(ev);
            return wasLogged;
        }

        private void btnDbPrintRepo_Click(object sender, EventArgs e) {
            Messenger.Show("Placeholder for Database Management report", caption);
            Report eventsRpt = ReportManager.GetReportByName("Database Management");
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
