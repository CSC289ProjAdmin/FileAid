using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileAid.GUI
{
    public partial class FormFileAidMain : Form
    {
        public FormFileAidMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            FormFileAidNewFile newfile = new FormFileAidNewFile();
            newfile.ShowDialog();
        }

        private void btnAddLink_Click(object sender, EventArgs e) {
            FormFileAidLink newLink = new FormFileAidLink();
            newLink.ShowDialog();
        }

        private void btnAddReminder_Click(object sender, EventArgs e) {
            FormFileAidReminder newReminder = new FormFileAidReminder();
            newReminder.ShowDialog();
        }

        private void FormFileAidMain_Load(object sender, EventArgs e)
        {
            FileAidMaintoolTip.SetToolTip(btnAdd, "Add new File");
            FileAidMaintoolTip.SetToolTip(btnStopTrack, "Stop file tracking");
            FileAidMaintoolTip.SetToolTip(btnTrack, "Restart file tracking");
            FileAidMaintoolTip.SetToolTip(btnAddLink, "Add file link");
            FileAidMaintoolTip.SetToolTip(btnAddReminder, "Add Reminder to files");
            FileAidMaintoolTip.SetToolTip(txtMemo, "Please enter the memo");
            FileAidMaintoolTip.SetToolTip(btnUpdate, "Update the memo");
            FileAidMaintoolTip.SetToolTip(btnMainPrintRepo, "Print report");
            FileAidMaintoolTip.SetToolTip(InactivecheckBox, "Show Inactive Files");
            FileAidMaintoolTip.SetToolTip(StartdateTimePicker, "Select date modified start date");
            FileAidMaintoolTip.SetToolTip(EnddateTimePicker, "Select date modified end date");
            FileAidMaintoolTip.SetToolTip(txtWild, "Please enter file name");
            FileAidMaintoolTip.SetToolTip(btnWildSearch, "Search the file");
            FileAidMaintoolTip.SetToolTip(btnViewHistory, "View history");


        }
    }
}
