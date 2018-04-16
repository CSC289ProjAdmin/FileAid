using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileAid.Models;

namespace FileAid.GUI {
    public partial class FormFileAidRptEvents : Form {
        private ListView.ListViewItemCollection reportItems;
        public FormFileAidRptEvents(ListView.ListViewItemCollection listViewRows) {
            InitializeComponent();
            reportItems = listViewRows;
        }

        private void FormFileAidRptEvents_Load(object sender, EventArgs e) {
            BindingList<EventHistory> myEvents = new BindingList<EventHistory>();
            foreach (ListViewItem item in reportItems) {
                EventHistory evHistory = new EventHistory();
                evHistory.Date = item.SubItems[0].Text;
                evHistory.EventDescription = item.SubItems[1].Text;
                evHistory.Initial = item.SubItems[2].Text;
                evHistory.New = item.SubItems[3].Text;

                myEvents.Add(evHistory);
            }
            EventHistoryBindingSource.DataSource = myEvents;
            this.reportViewer1.RefreshReport();
            /*
                        BindingList<ReportFile> myFiles = new BindingList<ReportFile>();
                        foreach (ListViewItem item in reportItems) {
                            ReportFile rptFile = new ReportFile();
                            rptFile.FileName = item.SubItems[0].Text;
                            rptFile.Extension = item.SubItems[1].Text;
                            rptFile.Path = item.SubItems[2].Text;
                            rptFile.Size = item.SubItems[3].Text;
                            rptFile.DateModified = item.SubItems[4].Text;
                            rptFile.NumLinks = item.SubItems[5].Text;
                            rptFile.Reminder = item.SubItems[6].Text;
                            rptFile.Inactive = item.SubItems[7].Text;

                            myFiles.Add(rptFile);
                        }
                        ReportFileBindingSource.DataSource = myFiles;
                        this.rptViewer.RefreshReport();
                    }

            */
        }
    }

    public class EventHistory : Report {
        public string Date { get; set; }
        public string EventDescription { get; set; }
        public string Initial { get; set; }
        public string New { get; set; }
    }
}
