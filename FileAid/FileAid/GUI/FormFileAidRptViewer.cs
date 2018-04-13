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
    public partial class FormFileAidRptViewer : Form {

        private ListView.ListViewItemCollection reportItems;
        public FormFileAidRptViewer(ListView.ListViewItemCollection listViewRows) {
            InitializeComponent();
            reportItems = listViewRows;
        }

        private void FormFileAidRptViewer_Load(object sender, EventArgs e) {
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
    }

    public class ReportFile : Report {
        public string FileName { get; set; }
        public string Extension { get; set; }
        public string Path { get; set; }
        public string Size { get; set; }
        public string DateModified { get; set; }
        public string NumLinks { get; set; }
        public string Reminder { get; set; }
        public string Inactive { get; set; }
    }

}
