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

        private void btnUpdateMode_Click(object sender, EventArgs e) {
            string promptTitle = "Update Mode";
            string promptMsg = "Do you want to put FileAid in Update Mode?\n\n" +
                "This will minimize FileAid to the system tray.";
            MessageBoxButtons promptBtns = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show(promptMsg, promptTitle, promptBtns);
            if (dr == DialogResult.Yes) {
                int tipDuration = 3000;
                string tipTitle = "Update Mode";
                string tipText = "FileAid is now in Update Mode.\nClick \"Show\" in menu to return to FileAid.";
                ToolTipIcon tipIcon = ToolTipIcon.Info;
                this.Hide();
                iconFileAidTray.Visible = true;
                iconFileAidTray.ShowBalloonTip(tipDuration, tipTitle, tipText, tipIcon);
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e) {
            iconFileAidTray.Visible = false;
            this.Show();
        }

        private void FormFileAidDash_Load(object sender, EventArgs e)
        {
            DashtoolTip.SetToolTip(btnTrackedFiles, "Open tracked files window");
            DashtoolTip.SetToolTip(btnReports, "Open reports Window");
            DashtoolTip.SetToolTip(btnUserMan, "Open user management window");
            DashtoolTip.SetToolTip(btnDBMan, "Open Database management window");
            DashtoolTip.SetToolTip(btnSettings, "Open program settings window");
            DashtoolTip.SetToolTip(btnLinks, "Open links/groups window");
            DashtoolTip.SetToolTip(btnLogEvents, "Open log events window");
            DashtoolTip.SetToolTip(btnBatchScan, "Open batch scan window");
            DashtoolTip.SetToolTip(btnGuestPerms, "Modify Guest Permissions");
            DashtoolTip.SetToolTip(btnViewTick, "Open ticklers window");
            DashtoolTip.SetToolTip(btnUpdateMode, "Open update mode window");
            DashtoolTip.SetToolTip(btnDataView, "Open data view window");
        }

        private void btnViewTick_Click(object sender, EventArgs e) {
            FormFileAidTicklers ticklers = new FormFileAidTicklers();
            ticklers.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e) {
            FormFileAidReports reports = new FormFileAidReports();
            reports.ShowDialog();
        }

        private void btnGuestPerms_Click(object sender, EventArgs e) {
            FormFileAidPermission perms = new FormFileAidPermission();
            perms.ShowDialog();
        }

        private void btnLinks_Click(object sender, EventArgs e) {
            FormFileAidFileLinks links = new FormFileAidFileLinks();
            links.ShowDialog();

        }
    }
}
