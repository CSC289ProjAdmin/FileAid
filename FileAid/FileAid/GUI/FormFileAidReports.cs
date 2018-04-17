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
                List<Report> allReports = ReportManager.GetReports();
                if (allReports == null) {
                    Messenger.Show("Unable to load report details.");
                    return;
                }
                foreach (var rpt in allReports) {
                    string[] reportDetails = new string[2];
                    reportDetails[0] = rpt.Name;
                    reportDetails[1] = rpt.Description;
                    ListViewItem row = new ListViewItem(reportDetails);
                    row.Tag = rpt.ReportID;
                    ReportslistView.Items.Add(row);
                }
            } catch (SqlException) {
                Messenger.ShowDbMsg();
            }
        }

        private void btnRunReport_Click(object sender, EventArgs e) {
            // stub - not all reports implemented yet
            // currently logs that a report was run (even if it wasn't)
            if (ReportslistView.SelectedItems.Count != 1) {
                Messenger.Show("Please select a report to run.");
                return;
            }
            try {
                ListViewItem row = ReportslistView.SelectedItems[0];
                int rptID = (int) row.Tag;
                string rptName = row.SubItems[0].Text;
                // TODO: Determine and run the report
                // NOTE: Incredibly hacky way of running the reports.  No time to do correctly.
                switch (rptName) {
                    case "Logins":
                        FormFileAidRptLogins loginRpt = new FormFileAidRptLogins();
                        loginRpt.ShowDialog();
                        break;
                    case "Events": // Really "Batches".  Using placeholder name to show report.
                        FormFileAidRptBatches batchRpt = new FormFileAidRptBatches();
                        batchRpt.ShowDialog();
                        break;
                    default:
                        Messenger.Show("Placeholder for reports.", "FileAid Reports");
                        break;
                }
                bool wasLogged = LogReportRun(rptID, rptName);
                if (!wasLogged) {
                    Messenger.Show("Failed to log report run.");
                }
            }
            catch (SqlException) {
                Messenger.ShowDbMsg();
            }
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
