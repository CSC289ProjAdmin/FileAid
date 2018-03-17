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
    public partial class FormFileAidDash : Form
    {
        public FormFileAidDash()
        {
            InitializeComponent();
        }

        private void btnTrackedFiles_Click(object sender, EventArgs e) {
            FormFileAidMain main = new FormFileAidMain();
            main.ShowDialog();
        }

        private void btnDBMan_Click(object sender, EventArgs e) {
            FormFileAidDbMgmt dbmgmt = new FormFileAidDbMgmt();
            dbmgmt.ShowDialog();
        }

        private void btnLogEvents_Click(object sender, EventArgs e) {
            FormFileAidEvents events = new FormFileAidEvents();
            events.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e) {
            FormFileAidConfig config = new FormFileAidConfig();
            config.ShowDialog();
        }

        private void btnUserMan_Click(object sender, EventArgs e) {
            FormFileAidUserMan userMgmt = new FormFileAidUserMan();
            userMgmt.ShowDialog();
        }
    }
}
