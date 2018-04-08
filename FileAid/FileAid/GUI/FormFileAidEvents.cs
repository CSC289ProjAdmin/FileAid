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
    public partial class FormFileAidEvents : Form
    {
        public FormFileAidEvents()
        {
            InitializeComponent();
        }

        private void FormFileAidEvents_Load(object sender, EventArgs e)
        {
            EventstoolTip.SetToolTip(btnReset, "Reset the events");
            EventstoolTip.SetToolTip(btnEventsReport, "Print the events report");
            EventstoolTip.SetToolTip(txtMemo, "Enter the memo");
            EventstoolTip.SetToolTip(btnEventsSearch, "Search the files");
            EventstoolTip.SetToolTip(EventsStartdateTimePicker, "Select start date");
            EventstoolTip.SetToolTip(EventsEnddateTimePicker, "Select end date");

            try {
                List<Models.Event> allEvents = Models.EventManager.GetEvents();
                if (allEvents == null) {
                    Models.Messenger.Show("Unable to load event history.");
                    return;
                }
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
                Models.Messenger.Show("Could not communicate with database.");
            }
        }

    }
}
