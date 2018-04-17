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
    public partial class FormFileAidRptLinkedFiles : Form {
        private ListView.ListViewItemCollection reportItems;
        private LinkedFilesContext context;
        public FormFileAidRptLinkedFiles(ListView.ListViewItemCollection listViewRows, string linkMemo) {
            reportItems = listViewRows;
            context = new LinkedFilesContext();
            context.LinkMemo = linkMemo;
            InitializeComponent();
        }

        private void FormFileAidRptLinkedFiles_Load(object sender, EventArgs e) {
            BindingList<LinkedFilesItem> myFiles = new BindingList<LinkedFilesItem>();
            foreach (ListViewItem item in reportItems) {
                LinkedFilesItem file = new LinkedFilesItem();
                file.Filename = item.SubItems[0].Text;
                file.Extension = item.SubItems[1].Text;
                file.Path = item.SubItems[2].Text;
                file.Size = item.SubItems[3].Text;
                file.DateModified = item.SubItems[4].Text;
                file.Inactive = item.SubItems[5].Text;
                myFiles.Add(file);
            }
            LinkedFilesContextBindingSource.DataSource = context;
            LinkedFilesItemBindingSource.DataSource = myFiles;
            this.reportViewer1.RefreshReport();
        }
    }

    public class LinkedFilesContext {
        public string LinkMemo { get; set; }
    }

    public class LinkedFilesItem {
        public string Filename { get; set; }
        public string Extension { get; set; }
        public string Path { get; set; }
        public string Size { get; set; }
        public string DateModified { get; set; }
        public string Inactive { get; set; }
    }
}
