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
    public partial class FormFileAidRptReminders : Form {
        private ListView.ListViewItemCollection reportItems;
        public FormFileAidRptReminders(ListView.ListViewItemCollection listViewRows) {
            InitializeComponent();
            reportItems = listViewRows;
        }

        private void FormFileAidRptReminders_Load(object sender, EventArgs e) {
            BindingList<RemindersReport> myRems = new BindingList<RemindersReport>();
            foreach (ListViewItem item in reportItems) {
                RemindersReport rem = new RemindersReport();
                rem.RemName = item.SubItems[0].Text;
                rem.RemDesc = item.SubItems[1].Text;
                rem.FileCount = item.SubItems[2].Text;
                rem.DueOn = item.SubItems[3].Text;
                rem.Resolved = item.SubItems[4].Text;
                rem.Pushed = item.SubItems[5].Text;
                myRems.Add(rem);
            }
            RemindersReportBindingSource.DataSource = myRems;
            this.reportViewer1.RefreshReport();
        }
    }

    public class RemindersReport : Report {
        public string RemName { get; set; }
        public string RemDesc { get; set; }
        public string FileCount { get; set; }
        public string DueOn { get; set; }
        public string Resolved { get; set; }
        public string Pushed { get; set; }
    }
}
