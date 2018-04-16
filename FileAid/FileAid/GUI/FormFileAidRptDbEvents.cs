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
    public partial class FormFileAidRptDbEvents : Form {
        private ListView.ListViewItemCollection reportItems;
        public FormFileAidRptDbEvents(ListView.ListViewItemCollection listViewRows) {
            InitializeComponent();
            reportItems = listViewRows;
        }

        private void FormFileAidRptDbEvents_Load(object sender, EventArgs e) {
            BindingList<DbEventsReport> myEvents = new BindingList<DbEventsReport>();
            foreach (ListViewItem item in reportItems) {
                DbEventsReport ev = new DbEventsReport();
                ev.Date = item.SubItems[0].Text;
                ev.EventDescription = item.SubItems[1].Text;
                myEvents.Add(ev);
            }
            DbEventsReportBindingSource.DataSource = myEvents;
            this.reportViewer1.RefreshReport();
        }
    }

    public class DbEventsReport : Report {
        public string Date { get; set; }
        public string EventDescription { get; set; }
    }
}
