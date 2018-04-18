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
            bool wantsUpdate = (Messenger.ShowYesNo(promptMsg, promptTitle) == DialogResult.Yes);
            if (!wantsUpdate) return;

            Configs settings = ConfigManager.GetConfigs();
            int intervalInMinutes = (settings == null) ? 15 : settings.UpdateTimerInMinutes;
            updateTimer.Interval = intervalInMinutes * 60 * 1000; // milliseconds
            StartTimer();
            int tipDuration = 3000;
            string tipTitle = "Update Mode";
            string tipText = "FileAid is now in Update Mode.\nClick \"Show\" in menu to return to FileAid.";
            ToolTipIcon tipIcon = ToolTipIcon.Info;
            this.Hide();
            iconFileAidTray.Visible = true;
            iconFileAidTray.ShowBalloonTip(tipDuration, tipTitle, tipText, tipIcon);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e) {
            ExitUpdateMode();
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

            // Check for and initiate password reset
            bool needsNewPassword = (loggedUser.NeedsPasswordReset);
            if (needsNewPassword) {
                FormFileAidResetPassword reset = new FormFileAidResetPassword(loggedUser);
                if (reset.ShowDialog() != DialogResult.OK) {
                    Application.Exit();
                    return;
                } 
                btnAboutFileAid_Click(this, null);
            }

            // Disable / Enable buttons according to permission set
            btnBatchScan.Enabled = perms.BatchScan;
            btnUpdateMode.Enabled = perms.BatchScan;
            btnDBMan.Enabled = perms.DbMgmt;
            btnGuestPerms.Enabled = perms.RestrictGuest;
            btnSettings.Enabled = perms.ProgramSetup;
            btnUserMan.Enabled = perms.LoginMgmt;

            // These buttons don't have access rights / permissions yet
            btnLinks.Enabled = true;
            btnLogEvents.Enabled = true;
            btnReports.Enabled = true;
            btnTrackedFiles.Enabled = true;
            btnViewTick.Enabled = true;

            // Fill Listview with events relevant to user
            FillRelevantEvents();


            DashtoolTip.SetToolTip(btnTrackedFiles, "View files tracked in system");
            DashtoolTip.SetToolTip(btnReports, "Run reports");
            DashtoolTip.SetToolTip(btnUserMan, "Manage user accounts");
            DashtoolTip.SetToolTip(btnDBMan, "Manage database");
            DashtoolTip.SetToolTip(btnSettings, "Configure program settings");
            DashtoolTip.SetToolTip(btnLinks, "View file links / groups");
            DashtoolTip.SetToolTip(btnLogEvents, "View event history");
            DashtoolTip.SetToolTip(btnBatchScan, "Manually scan for tracked files");
            DashtoolTip.SetToolTip(btnGuestPerms, "Modify Guest Permissions");
            DashtoolTip.SetToolTip(btnViewTick, "View ticklers / reminders");
            DashtoolTip.SetToolTip(btnUpdateMode, "Put FileAid in Update Mode");
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
            List<FileLink> allLinks = LinkManager.GetLinks();
            FormFileAidFileLinks links = new FormFileAidFileLinks(allLinks);
            links.ShowDialog();
            FillRelevantEvents();
        }

        private void btnBatchScan_Click(object sender, EventArgs e) {
            // First confirm that user wants to manually scan
            string scanPrompt = "Are you sure you want to run a manual file scan?";
            string caption = "FileAid Manual Scan";
            bool wantsScan = (Messenger.ShowYesNo(scanPrompt, caption) == DialogResult.Yes);
            if (!wantsScan) return;

            Configs settings = ConfigManager.GetConfigs();
            string masterPath = (settings == null) ? "" : settings.MasterPath;
            Batch result = BatchManager.Scan(masterPath, false);
            string resultMsg = (result == null) ? "Manual scan failed" :
                $"Scan complete.\n{result.FilesAdded} added, {result.FilesModified} modified, {result.FilesDisabled} disabled";
            MessageBox.Show(resultMsg, caption);
            FillRelevantEvents();
        }

        private void StartTimer() {
            updateTimer.Start();
        }

        private void StopTimer() {
            updateTimer.Stop();
        }

        private void StartPeriodicUpdate() {
            StopTimer();
            // Balloon tooltip
            int tipDuration = 3000;
            string tipTitle = "FileAid Update";
            string tipText = "A periodic update has started.";
            ToolTipIcon tipIcon = ToolTipIcon.Info;
            iconFileAidTray.ShowBalloonTip(tipDuration, tipTitle, tipText, tipIcon);
            // Disable contextmenu Exit/Show
            var menuItems = contextMenuStrip1.Items;
            foreach (ToolStripItem menuEntry in menuItems) {
                menuEntry.Enabled = false;
            }
            // Run update
            Configs settings = ConfigManager.GetConfigs();
            string masterPath = (settings == null) ? "" : settings.MasterPath;
            Batch result = BatchManager.Scan(masterPath, true);
            // Balloon tooltip with details
            string resultMsg = (result == null) ? "Periodic update failed" :
                $"Scan complete.\n{result.FilesAdded} added, {result.FilesModified} modified, {result.FilesDisabled} disabled";
            iconFileAidTray.ShowBalloonTip(tipDuration, tipTitle, resultMsg, tipIcon);
            // Enable contextmenu Exit/Show
            foreach (ToolStripItem menuEntry in menuItems) {
                menuEntry.Enabled = true;
            }
            // Set next timer
            StartTimer();
        }

        private void ExitUpdateMode() {
            StopTimer();
            // Hide tray icon and show the dashboard
            iconFileAidTray.Visible = false;
            this.Show();
            FillRelevantEvents();
        }

        private void updateTimer_Tick(object sender, EventArgs e) {
            StartPeriodicUpdate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            // Make sure not to start update while prompting to exit
            StopTimer();
            // Prompt before exiting
            string exitPrompt = "Are you sure you want to exit FileAid?";
            string caption = "FileAid";
            bool wantsExit = (Messenger.ShowYesNo(exitPrompt, caption) == DialogResult.Yes);
            if (!wantsExit) {
                StartTimer();
                return;
            }
            Close();
        }

        private void btnAboutFileAid_Click(object sender, EventArgs e) {
            string aboutMsg = "FileAid tracks the modification history of MS Office files.\n\n"
                + "Files can be added manually or scanned for with user-initiated and periodic updates.\n\n"
                + "Visit the Program Settings screen to configure user accounts, default settings"
            + " and update search path.";
            Messenger.Show(aboutMsg, "About FileAid");
        }
    }
}
