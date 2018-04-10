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
    public partial class FormFileAidEvents : Form
    {
        private User currentUser;
        public FormFileAidEvents(User u)
        {
            InitializeComponent();
            currentUser = u;
        }

        private void FormFileAidEvents_Load(object sender, EventArgs e)
        {
            EventstoolTip.SetToolTip(btnReset, "Reset the events");
            EventstoolTip.SetToolTip(btnEventsReport, "Print the events report");
            EventstoolTip.SetToolTip(txtMemo, "Enter the memo");
            EventstoolTip.SetToolTip(btnEventsSearch, "Search the files");
            EventstoolTip.SetToolTip(EventsStartdateTimePicker, "Select start date");
            EventstoolTip.SetToolTip(EventsEnddateTimePicker, "Select end date");

            bool isAdmin = (currentUser.Username == "Admin");
            btnReset.Enabled = isAdmin; // Only Admin can reset the event history

            FillListView();
        }

        private void FillListView() {
            try {
                EventslistView.Items.Clear();
                List<Models.Event> allEvents = Models.EventManager.GetEvents();
                if (allEvents == null) return; // No events to load
                foreach (var ev in allEvents) {
                    string[] evDetails = new string[3];
                    evDetails[0] = ev.EventID.ToString();
                    evDetails[1] = ev.Description;
                    evDetails[2] = ev.OccurredOn.ToString();
                    ListViewItem row = new ListViewItem(evDetails);
                    EventslistView.Items.Add(row);
                }
            }
            catch (SqlException) {
                Models.Messenger.ShowDbMsg();
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

            // Fake resetting for now.
            //Messenger.Show("Resetting event history...", caption);
            bool wasDeleted = EventManager.DeleteEventHistory();
            if (wasDeleted) FillListView(); // Refresh GUI
        }
    }
}
