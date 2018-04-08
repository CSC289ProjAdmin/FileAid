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
    public partial class FormFileAidReports : Form
    {
        public FormFileAidReports()
        {
            InitializeComponent();
        }

        private void FormFileAidReports_Load(object sender, EventArgs e)
        {
            ReporttoolTip.SetToolTip(btnRunReport, "Run report");
            try {
                List<Models.Report> allReports = Models.ReportManager.GetReports();
                if (allReports == null) {
                    Models.Messenger.Show("Unable to load report details.");
                    return;
                }
                foreach (var rpt in allReports) {
                    string[] reportDetails = new string[2];
                    reportDetails[0] = rpt.Name;
                    reportDetails[1] = rpt.Description;
                    ListViewItem row = new ListViewItem(reportDetails);
                    ReportslistView.Items.Add(row);
                }
            } catch (SqlException) {
                Models.Messenger.Show("Could not communicate with database.");
            }
        }
    }
}
