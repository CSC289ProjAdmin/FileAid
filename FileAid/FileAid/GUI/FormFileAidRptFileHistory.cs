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
    public partial class FormFileAidRptFileHistory : Form {
        private ListView.ListViewItemCollection reportItems;
        private FileHistoryContext context;
        public FormFileAidRptFileHistory(ListView.ListViewItemCollection listViewRows, string filename) {
            InitializeComponent();
            reportItems = listViewRows;
            context = new FileHistoryContext();
            context.Filename = filename;
        }

        private void FormFileAidRptFileHistory_Load(object sender, EventArgs e) {
            BindingList<FileHistoryItem> myHistory = new BindingList<FileHistoryItem>();
            foreach (ListViewItem item in reportItems) {
                FileHistoryItem history = new FileHistoryItem();
                history.Date = item.SubItems[0].Text;
                history.EventType = item.SubItems[1].Text;
                history.EventDescription = item.SubItems[2].Text;
                history.Initial = item.SubItems[3].Text;
                history.New = item.SubItems[4].Text;
                myHistory.Add(history);
            }

            FileHistoryContextBindingSource.DataSource = context;
            FileHistoryItemBindingSource.DataSource = myHistory;

            this.reportViewer1.RefreshReport();
        }
    }

    public class FileHistoryContext {
        public string Filename { get; set; }

    }

    public class FileHistoryItem {
        public string Date { get; set; }
        public string EventType { get; set; }
        public string EventDescription { get; set; }
        public string Initial { get; set; }
        public string New { get; set; }
    }
}
