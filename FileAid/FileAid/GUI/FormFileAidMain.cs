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
            FileAidMaintoolTip.SetToolTip(btnAdd, "Click Add Button to add new File");
            FileAidMaintoolTip.SetToolTip(btnStopTrack, "Click Stop Tracking Button to stop the file tracking");
            FileAidMaintoolTip.SetToolTip(btnTrack, "Click Track Button to track new File");
            FileAidMaintoolTip.SetToolTip(btnAddLink, "Click Add Link Button to add file link");
            FileAidMaintoolTip.SetToolTip(btnAddReminder, "Click Add Reminder Button to add reminder File");
            FileAidMaintoolTip.SetToolTip(txtMemo, "Please enter the memo");
            FileAidMaintoolTip.SetToolTip(btnUpdate, "Click Update Button to update the memo");
            FileAidMaintoolTip.SetToolTip(btnMainPrintRepo, "Click Print Report Button to print report");
            FileAidMaintoolTip.SetToolTip(FiltercheckBox, "Check Filter Checkbox");
            FileAidMaintoolTip.SetToolTip(InactivecheckBox, "Check Inactive Files CheckBox");
            FileAidMaintoolTip.SetToolTip(StartdateTimePicker, "Select the start date");
            FileAidMaintoolTip.SetToolTip(EnddateTimePicker, "Select the end date");
            FileAidMaintoolTip.SetToolTip(txtWild, "Please enter file name");
            FileAidMaintoolTip.SetToolTip(btnWildSearch, "Click Search Button to search the file");


        }
    }
}
