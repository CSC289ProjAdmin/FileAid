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

namespace FileAid.GUI
{
    public partial class FormFileAidFileLinks : Form
    {
        public FormFileAidFileLinks()
        {
            InitializeComponent();
        }

        private void FormFileAidFileLinks_Load(object sender, EventArgs e) {
            try {
                List<Models.FileLink> allLinks = Models.LinkManager.GetLinks();
                if (allLinks == null) {
                    // No links in system yet.
                    return;
                }
                foreach (var link in allLinks) {
                    string[] remDetails = new string[2];
                    remDetails[0] = link.LinkMemo;
                    if (string.IsNullOrEmpty(remDetails[0]))
                        remDetails[0] = "(No Description Given)";
                    remDetails[1] = link.GetFiles().Count.ToString();
                    ListViewItem row = new ListViewItem(remDetails);
                    FileLinkslistView.Items.Add(row);
                }
            }
            catch (SqlException) {
                Models.Messenger.ShowDbMsg();
            }

        }
    }
}
