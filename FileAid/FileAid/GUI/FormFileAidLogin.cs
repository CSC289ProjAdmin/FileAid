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
    public partial class FormFileAidLogin : Form
    {
        public FormFileAidLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) {
                lblErrorMsg.Text = "Username and password are both required.";
                return;
            }

            User u = UserService.Find(username);
            if (u == null) {
                lblErrorMsg.Text = "Invalid credentials.";
                txtUserName.Focus();
                // TODO?: Log unauthorized access attempt?
                return;
            }

            bool passMatches = UserService.VerifyCredentials(u, password);
            if (!passMatches) {
                lblErrorMsg.Text = "Invalid credentials.";
                txtUserName.Focus();
                LogBadCreds(u);
                bool isAdmin = (u.Username == "Admin");
                bool isLocked = UserService.IsLockedOut(u);
                bool isDisable = UserService.IsDisabled(u);
                if (!isAdmin && !isLocked && !isDisable) { // Never lock out Admin or disabled accounts
                    UserService.IncrementFailures(u);
                    LogFailureIncrement(u);
                    bool needsLocking = (u.LoginFailures >= 3);
                    if (needsLocking) {
                        bool wasLocked = UserService.LockOut(u);
                        if (wasLocked) {
                            Messenger.Show("Account locked out for repeated failed logins.", "Account Locked");
                            DateTime unlocksAt = u.LockedOutOn + TimeSpan.FromHours(1);
                            lblErrorMsg.Text = $"Account is locked out until {unlocksAt.ToString()}.";
                            // TODO: Log lockout event
                        }
                    }
                }
                return;
            }

            bool isDisabled = UserService.IsDisabled(u);
            if (isDisabled) {
                lblErrorMsg.Text = "Account is disabled and cannot log in.";
                txtUserName.Focus();
                // TODO: Log failed login due to disabled account
                return;
            }

            bool isLockedOut = UserService.IsLockedOut(u);
            if (isLockedOut) {
                DateTime unlocksAt = u.LockedOutOn + TimeSpan.FromHours(1);
                lblErrorMsg.Text = $"Account is locked out until {unlocksAt.ToString()}.";
                txtUserName.Focus();
                // TODO: Log failed login due to lockout
                return;
            }

            // Account is good otherwise.
            // TODO: clear account (Unlock, ClearFailures)
            // Calling form is responsible for getting account & rights.
            DialogResult = DialogResult.OK;
            Close();
        }

        private void LogBadCreds(User u) {
            Event ev = new Event();
            ev.EventTypeID = EventTypes.LoginFailure;
            ev.OccurredOn = DateTime.Now;
            ev.UserID = u.UserID;
            ev.Description = $"Login failure for {u.Username} due to incorrect password.";
            Logger.Log(ev);
        }

        private void LogFailureIncrement(User u) {
            Event ev = new Event();
            ev.EventTypeID = EventTypes.LoginFailure;
            ev.OccurredOn = DateTime.Now;
            ev.UserID = u.UserID;
            ev.Description = $"Login failure count for {u.Username} incremented.";
            ev.Initial = (u.LoginFailures - 1).ToString();
            ev.New = u.LoginFailures.ToString();
            Logger.Log(ev);
        }

        private void FormFileAidLogin_Load(object sender, EventArgs e)
        {
            LogintoolTip.SetToolTip(txtUserName, "Enter username");
            LogintoolTip.SetToolTip(txtPassword, "Enter password");
            LogintoolTip.SetToolTip(btnLogin, "Login to FileAid");
        }
    }
}
