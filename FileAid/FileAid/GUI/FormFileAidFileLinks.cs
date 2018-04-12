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
    public partial class FormFileAidFileLinks : Form
    {
        private List<FileLink> myLinks;
        public FormFileAidFileLinks(List<FileLink> links)
        {
            InitializeComponent();
            myLinks = links;
        }

        private void FormFileAidFileLinks_Load(object sender, EventArgs e) {
            try {
                if (myLinks == null) {
                    // No links in system yet.
                    return;
                }
                foreach (var link in myLinks) {
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
                Messenger.ShowDbMsg();
            }

        }
    }
}
