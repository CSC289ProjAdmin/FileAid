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
    public partial class FormFileAidTicklers : Form
    {
        public FormFileAidTicklers()
        {
            InitializeComponent();
        }

        private void FormFileAidTicklers_Load(object sender, EventArgs e)
        {
            TicklerstoolTip.SetToolTip(btnPushToOutlook, "Push to outlook");
            TicklerstoolTip.SetToolTip(btnResolved, "Mark as resolved");

            try {
                List<Models.Reminder> allReminders = Models.ReminderManager.GetReminders();
                if (allReminders == null) {
                    Models.Messenger.Show("Unable to load reminder details.");
                    return;
                }
                foreach (var rem in allReminders) {
                    string[] remDetails = new string[6];
                    remDetails[0] = rem.Name;
                    remDetails[1] = rem.Memo;
                    remDetails[2] = rem.GetFiles().Count.ToString();
                    remDetails[3] = rem.DueOn.ToString();
                    remDetails[4] = (rem.ResolvedOn > new DateTime()) ? "X" : "";
                    remDetails[5] = (rem.PushedOn > new DateTime()) ? "X" : "";
                    ListViewItem row = new ListViewItem(remDetails);
                    TicklerslistView.Items.Add(row);
                }
            }
            catch (SqlException) {
                Models.Messenger.Show("Could not communicate with database.");
            }
        }
    }
}
