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
    public partial class FormFileAidEvents : Form
    {
        private User currentUser;
        private string caption = "FileAid Event History";
        public FormFileAidEvents(User u)
        {
            InitializeComponent();
            currentUser = u;
        }

        private void FormFileAidEvents_Load(object sender, EventArgs e)
        {
            EventstoolTip.SetToolTip(btnReset, "Reset the events");
            EventstoolTip.SetToolTip(btnEventsReport, "Print the events report");
            EventstoolTip.SetToolTip(txtWild, "Enter a search pattern");
            EventstoolTip.SetToolTip(btnEventsSearch, "Search the files");
            EventstoolTip.SetToolTip(EventsStartdateTimePicker, "Select start date");
            EventstoolTip.SetToolTip(EventsEnddateTimePicker, "Select end date");

            // Give values to controls and enable buttons
            EventsEnddateTimePicker.Value = DateTime.Today;
            EventsStartdateTimePicker.Value = EventsEnddateTimePicker.Value - TimeSpan.FromDays(30);
            bool isAdmin = (currentUser.Username == "Admin");
            btnReset.Enabled = isAdmin; // Only Admin can reset the event history

            FillListView();
        }

        private void FillListView() {
            try {
                EventslistView.Items.Clear();
                List<Event> allEvents = EventManager.GetEvents();
                if (allEvents == null) return; // No events to load
                var filteredEvents = from ev in allEvents
                                     where (ev.OccurredOn.Date > EventsStartdateTimePicker.Value.Date
                                     && ev.OccurredOn.Date < EventsEnddateTimePicker.Value.Date + TimeSpan.FromDays(1))
                                     select ev;

                string searchPattern = txtWild.Text.Trim();
                if (!string.IsNullOrEmpty(searchPattern)) {
                    filteredEvents = from ev in filteredEvents
                                    where (
                                        Regex.IsMatch(ev.Description,
                                            WildcardToRegular(searchPattern), RegexOptions.IgnoreCase) ||
                                        Regex.IsMatch(string.IsNullOrEmpty(ev.Initial) ? "" : ev.Initial,
                                            WildcardToRegular(searchPattern), RegexOptions.IgnoreCase) ||
                                        Regex.IsMatch(string.IsNullOrEmpty(ev.New) ? "" : ev.New,
                                            WildcardToRegular(searchPattern), RegexOptions.IgnoreCase)
                                    )
                                    select ev;
                }

                if (filteredEvents == null) return; // No events in range
                foreach (var ev in filteredEvents) {
                    string[] evDetails = new string[4];
                    evDetails[0] = ev.OccurredOn.ToString();
                    evDetails[1] = ev.Description;
                    evDetails[2] = string.IsNullOrEmpty(ev.Initial) ? "" : ev.Initial;
                    evDetails[3] = string.IsNullOrEmpty(ev.New) ? "" : ev.New;
                    ListViewItem row = new ListViewItem(evDetails);
                    EventslistView.Items.Add(row);
                }
            }
            catch (SqlException) {
                Messenger.ShowDbMsg();
            }
        }

        private void btnReset_Click(object sender, EventArgs e) {
            // First confirm that Admin wants to reset event history (2 prompts)
            string resetPrompt = "Are you sure you want to delete all event history?\n\n" +
                "Note: This will not remove tracked files or affect user accounts.";
            string resetPrompt2 = "Are you absolutely sure you want to delete all event history?";
            string caption = "FileAid Event History";
            bool wantsReset = (Messenger.ShowYesNo(resetPrompt, caption) == DialogResult.Yes);
            if (!wantsReset) return;
            wantsReset = (Messenger.ShowYesNo(resetPrompt2, caption) == DialogResult.Yes);
            if (!wantsReset) return;

            bool wasDeleted = EventManager.DeleteEventHistory();
            if (wasDeleted) FillListView(); // Refresh GUI
        }

        private void btnEventsSearch_Click(object sender, EventArgs e) {
            // Validate date pickers
            bool isValidRange = (EventsStartdateTimePicker.Value <= EventsEnddateTimePicker.Value);
            if (!isValidRange) {
                string badRangePrompt = "Start date must be less than or equal to end date.";
                Messenger.Show(badRangePrompt, caption);
                return;
            }
            FillListView(); // Update GUI with filtered events
        }

        private void btnEventsReport_Click(object sender, EventArgs e) {
            Messenger.Show("Placeholder for Events report", caption);
            Report eventsRpt = ReportManager.GetReportByName("Events");
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

        private static string WildcardToRegular(string value) {
            return "^" + Regex.Escape(value).Replace("\\?", ".").Replace("\\*", ".*") + "$";
        }
    }
}
