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
    public partial class FormFileAidRptReminderDetails : Form {
        private ListView.ListViewItemCollection reportItems;
        public FormFileAidRptReminderDetails(ListView.ListViewItemCollection listViewRows) {
            InitializeComponent();
            reportItems = listViewRows;
        }

        private void FormFileAidRptReminderDetails_Load(object sender, EventArgs e) {
            /*
            BindingList<ReminderDetailsItem> myFiles = new BindingList<ReminderDetailsItem>();
            foreach (ListViewItem item in reportItems) {
                ReminderDetailsItem file = new ReminderDetailsItem();
                file.Filename = item.SubItems[0].Text;
                file.Extension = item.SubItems[1].Text;
                file.Path = item.SubItems[2].Text;
                file.Size = item.SubItems[3].Text;
                file.DateModified = item.SubItems[4].Text;
                file.Inactive = item.SubItems[5].Text;
                myFiles.Add(file);
            }
            // binding contexts
            */
            this.reportViewer1.RefreshReport();
        }
    }
    
    public class ReminderDetailsItem {
        public string Filename { get; set; }
        public string Extension { get; set; }
        public string Path { get; set; }
        public string Size { get; set; }
        public string DateModified { get; set; }
        public string Inactive { get; set; }
    }
    
    public class ReminderContext {
        public string Name { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
    }

}
