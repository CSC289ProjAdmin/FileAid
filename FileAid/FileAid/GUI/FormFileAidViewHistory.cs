using System;
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
    }
}
