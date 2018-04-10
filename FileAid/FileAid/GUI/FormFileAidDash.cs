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

namespace FileAid.GUI
{
    public partial class FormFileAidDash : Form
    {
        private User loggedUser;
        public FormFileAidDash()
        {
            InitializeComponent();
        }

        private void btnTrackedFiles_Click(object sender, EventArgs e) {
            FormFileAidMain main = new FormFileAidMain();
            main.ShowDialog();
            FillRelevantEvents();
        }

        private void btnDBMan_Click(object sender, EventArgs e) {
            FormFileAidDbMgmt dbmgmt = new FormFileAidDbMgmt();
            dbmgmt.ShowDialog();
            FillRelevantEvents();
        }

        private void btnLogEvents_Click(object sender, EventArgs e) {
            FormFileAidEvents events = new FormFileAidEvents(loggedUser);
            events.ShowDialog();
            FillRelevantEvents();
        }

        private void btnSettings_Click(object sender, EventArgs e) {
            FormFileAidConfig config = new FormFileAidConfig();
            config.ShowDialog();
            FillRelevantEvents();
        }

        private void btnUserMan_Click(object sender, EventArgs e) {
            FormFileAidUserMan userMgmt = new FormFileAidUserMan(loggedUser);
            userMgmt.ShowDialog();
            FillRelevantEvents();
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
            FillRelevantEvents();
        }

        private void FormFileAidDash_Load(object sender, EventArgs e)
        {
            // Make user login
            FormFileAidLogin login = new FormFileAidLogin();
            if (login.ShowDialog() != DialogResult.OK) {
                Application.Exit();
                return;
            }
            // Get logged in account
            string username = login.LoggedInUsername;
            loggedUser = UserService.Find(username);
            Permissions perms = PermissionsManager.GetPermissionSet(loggedUser.UserID);

            // Disable / Enable buttons according to permission set
            btnBatchScan.Enabled = perms.BatchScan;
            btnDBMan.Enabled = perms.DbMgmt;
            btnGuestPerms.Enabled = perms.RestrictGuest;
            btnSettings.Enabled = perms.ProgramSetup;
            btnUserMan.Enabled = perms.LoginMgmt;

            // These buttons don't have access rights / permissions yet
            btnLinks.Enabled = true;
            btnLogEvents.Enabled = true;
            btnReports.Enabled = true;
            btnTrackedFiles.Enabled = true;
            btnUpdateMode.Enabled = true;
            btnViewTick.Enabled = true;

            // Fill Listview with events relevant to user
            FillRelevantEvents();


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
        }

        private void FillRelevantEvents() {
            List<EventTypes> relevantTypes = new List<EventTypes>();
            switch (loggedUser.Username) {
                case "Admin":
                    relevantTypes.Add(EventTypes.AccountDisabled);
                    relevantTypes.Add(EventTypes.AccountEnabled);
                    relevantTypes.Add(EventTypes.AccountLockedOut);
                    relevantTypes.Add(EventTypes.AccountPasswordChanged);
                    relevantTypes.Add(EventTypes.AccountPasswordReset);
                    relevantTypes.Add(EventTypes.AccountPermsChanged);
                    relevantTypes.Add(EventTypes.AccountUnlocked);
                    relevantTypes.Add(EventTypes.DbBackedUp);
                    relevantTypes.Add(EventTypes.DbReset);
                    relevantTypes.Add(EventTypes.DbRestored);
                    relevantTypes.Add(EventTypes.LoginSuccess);
                    relevantTypes.Add(EventTypes.ProgramSettingsChanged);
                    relevantTypes.Add(EventTypes.BatchCompleted);
                    relevantTypes.Add(EventTypes.FileModified);
                    break;
                case "User":
                    relevantTypes.Add(EventTypes.DbBackedUp);
                    relevantTypes.Add(EventTypes.DbReset);
                    relevantTypes.Add(EventTypes.DbRestored);
                    relevantTypes.Add(EventTypes.BatchCompleted);
                    relevantTypes.Add(EventTypes.FileModified);
                    break;
                case "Guest":
                    relevantTypes.Add(EventTypes.FileModified);
                    break;
                default:
                    break;
            }

            DashboardlistView.Items.Clear();
            List<Event> allEvents = EventManager.GetEvents();
            if (allEvents == null) return; // No events to load
            var relevantEvents = from ev in allEvents
                where relevantTypes.Contains(ev.EventTypeID)
                select ev;
            if (relevantEvents == null) return; // No events to load
            foreach (Event ev in relevantEvents) {
                string [] evDetails = new string[2];
                evDetails[0] = ev.OccurredOn.ToString();
                evDetails[1] = ev.Description;
                ListViewItem row = new ListViewItem(evDetails);
                DashboardlistView.Items.Add(row);
            }
        }

        private void btnViewTick_Click(object sender, EventArgs e) {
            FormFileAidTicklers ticklers = new FormFileAidTicklers();
            ticklers.ShowDialog();
            FillRelevantEvents();
        }

        private void btnReports_Click(object sender, EventArgs e) {
            FormFileAidReports reports = new FormFileAidReports();
            reports.ShowDialog();
            FillRelevantEvents();
        }

        private void btnGuestPerms_Click(object sender, EventArgs e) {
            FormFileAidPermission perms = new FormFileAidPermission();
            perms.ShowDialog();
            FillRelevantEvents();
        }

        private void btnLinks_Click(object sender, EventArgs e) {
            FormFileAidFileLinks links = new FormFileAidFileLinks();
            links.ShowDialog();
            FillRelevantEvents();
        }

        private void btnBatchScan_Click(object sender, EventArgs e) {
            // First confirm that user wants to manually scan
            string scanPrompt = "Are you sure you want to run a manual file scan?";
            string caption = "FileAid Manual Scan";
            bool wantsScan = (Messenger.ShowYesNo(scanPrompt, caption) == DialogResult.Yes);
            if (!wantsScan) return;

            Batch result = BatchManager.Scan(null, false);
            string resultMsg = (result == null) ? "Batch update failed" :
                $"Scan complete.\n{result.FilesAdded} added, {result.FilesModified} modified, {result.FilesDisabled} disabled";
            MessageBox.Show(resultMsg, caption);
            FillRelevantEvents();
        }
    }
}
