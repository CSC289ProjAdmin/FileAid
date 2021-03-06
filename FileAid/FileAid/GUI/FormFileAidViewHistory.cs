﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FileAid.Models;

namespace FileAid.GUI
{
    public partial class FormFileAidViewHistory : Form
    {
        private string caption = "File History";
        private TrackedFile selectedFile;
        public FormFileAidViewHistory(TrackedFile tf)
        {
            InitializeComponent();
            selectedFile = tf;
            StringBuilder fullFilename = new StringBuilder();
            fullFilename.Append(tf.FilePath);
            if (!tf.FilePath.EndsWith("\\")) fullFilename.Append("\\");
            fullFilename.Append(tf.Filename);
            fullFilename.Append(".");
            fullFilename.Append(tf.FileExtension);
            lblFilename.Text = fullFilename.ToString();

            FillListView();
        }

        private void FillListView() {
            try {
                ViewHistorylistView.Items.Clear();
                List<Event> history = selectedFile.GetHistory();
                if (history == null) return; // No history in system for selected file
                foreach (var ev in history) {
                    string[] evDetails = new string[5];
                    evDetails[0] = ev.OccurredOn.ToString();
                    evDetails[1] = ev.EventTypeID.ToString();
                    evDetails[2] = ev.Description;
                    evDetails[3] = ev.Initial;
                    evDetails[4] = ev.New;
                    ListViewItem row = new ListViewItem(evDetails);
                    ViewHistorylistView.Items.Add(row);
                }
            }
            catch (SqlException) {
                Messenger.ShowDbMsg();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnReport_Click(object sender, EventArgs e) {
            FormFileAidRptFileHistory rptForm = new FormFileAidRptFileHistory(ViewHistorylistView.Items, 
                lblFilename.Text);
            rptForm.ShowDialog();
            //Messenger.Show("Placeholder for Events report", caption);
            Report eventsRpt = ReportManager.GetReportByName("File History");
            if (eventsRpt == null) return; // Could not find report
            bool wasLogged = LogReportRun(eventsRpt.ReportID, eventsRpt.Name);
            if (wasLogged) FillListView(); // Refresh GUI
        }

        private bool LogReportRun(int reportID, string reportName) {
            Event ev = new Event();
            ev.EventTypeID = EventTypes.ReportRun;
            ev.ReportID = reportID;
            ev.OccurredOn = DateTime.Now;
            ev.Description = $"Report run: {reportName}";
            bool wasLogged = Logger.Log(ev);
            return wasLogged;
        }
    }
}
