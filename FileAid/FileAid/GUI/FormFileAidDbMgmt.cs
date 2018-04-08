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
    public partial class FormFileAidDbMgmt : Form
    {
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

            try {
                List<Models.Event> allEvents = Models.EventManager.GetEvents();
                if (allEvents == null) {
                    Models.Messenger.Show("Unable to load event history.");
                    return;
                }
                var dbEventIDs = new Models.EventTypes[]{
                    Models.EventTypes.DbBackedUp,
                    Models.EventTypes.DbReset,
                    Models.EventTypes.DbRestored
                };
                var dbEvents = from ev in allEvents
                               where dbEventIDs.Contains(ev.EventTypeID)
                               select ev;                 
                foreach (var ev in dbEvents) {
                    string[] evDetails = new string[3];
                    evDetails[0] = ev.EventID.ToString();
                    evDetails[1] = ev.Description;
                    evDetails[2] = ev.OccurredOn.ToString();
                    ListViewItem row = new ListViewItem(evDetails);
                    DBManlistView.Items.Add(row);
                }
            }
            catch (SqlException) {
                Models.Messenger.Show("Could not communicate with database.");
            }
        }
    }
}
