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
    public partial class FormFileAidRptFileLinks : Form {
        private ListView.ListViewItemCollection reportItems;
        public FormFileAidRptFileLinks(ListView.ListViewItemCollection listViewRows) {
            InitializeComponent();
            reportItems = listViewRows;
        }

        private void FormFileAidRptFileLinks_Load(object sender, EventArgs e) {
            BindingList<FileLinksReport> myLinks = new BindingList<FileLinksReport>();
            foreach (ListViewItem item in reportItems) {
                FileLinksReport link = new FileLinksReport();
                link.LinkDescription = item.SubItems[0].Text;
                link.FileCount = item.SubItems[1].Text;
                myLinks.Add(link);
            }
            FileLinksReportBindingSource.DataSource = myLinks;
            this.reportViewer1.RefreshReport();
        }
    }

    public class FileLinksReport : Report {
        public string LinkDescription { get; set; }
        public string FileCount { get; set; }
    }
}
