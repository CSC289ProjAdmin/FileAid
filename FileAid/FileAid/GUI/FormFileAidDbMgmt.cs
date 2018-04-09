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
                Models.Messenger.ShowDbMsg();
            }
        }

        private void btnBackup_Click(object sender, EventArgs e) {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = $"Choose location to save database backup.";
            if (dlg.ShowDialog() == DialogResult.OK) {
                bool wasBackedUp = Models.DbManager.Backup(dlg.SelectedPath);
                Models.Messenger.Show(wasBackedUp ? "Backup successful." : "Backup failed.");
            }
        }

        private void btnRestore_Click(object sender, EventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL Server database backup files|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK) {
                bool wasRestored = Models.DbManager.Restore(dlg.FileName);
                Models.Messenger.Show(wasRestored ? "Restore successful." : "Restore failed.");
            }
        }
    }
}
