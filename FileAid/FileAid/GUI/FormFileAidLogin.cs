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
using System.Data.SqlClient;

namespace FileAid.GUI
{
    public partial class FormFileAidLogin : Form
    {
        public string LoggedInUsername { get; private set; }
        public FormFileAidLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) {
                lblErrorMsg.Text = "Username and password are both required.";
                txtUserName.Focus();
                return;
            }

            try {
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
                        bool wasIncremented = UserService.IncrementFailures(u);
                        if (wasIncremented) LogFailureIncrement(u);
                        bool needsLocking = (u.LoginFailures >= 3);
                        if (needsLocking) {
                            bool wasLocked = UserService.LockOut(u);
                            if (wasLocked) {
                                Messenger.Show("Account locked out for repeated failed logins.", "Account Locked");
                                DateTime unlocksAt = u.LockedOutOn + TimeSpan.FromHours(1);
                                lblErrorMsg.Text = $"Account is locked out until {unlocksAt.ToString()}.";
                                LogLockout(u);
                            }
                        }
                    }
                    return;
                }

                bool isDisabled = UserService.IsDisabled(u);
                if (isDisabled) {
                    lblErrorMsg.Text = "Account is disabled and cannot log in.";
                    txtUserName.Focus();
                    string reason = $"Access denied to {u.Username} because account is disabled.";
                    LogAccessDenied(u, reason);
                    return;
                }

                bool isLockedOut = UserService.IsLockedOut(u);
                if (isLockedOut) {
                    DateTime unlocksAt = u.LockedOutOn + TimeSpan.FromHours(1);
                    lblErrorMsg.Text = $"Account is locked out until {unlocksAt.ToString()}.";
                    txtUserName.Focus();
                    string reason = $"Access denied to {u.Username} because account is locked out.";
                    LogAccessDenied(u, reason);
                    return;
                }

                // Account is good otherwise. Reset failures and lockout datetime.
                UserService.ClearFailures(u);
                UserService.Unlock(u);
                LogSuccessfulLogin(u);
                // Calling form is responsible for getting account & rights. Just set the username
                LoggedInUsername = u.Username;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (SqlException) {
                Messenger.ShowDbMsg();
            }
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

        private void LogLockout(User u) {
            Event ev = new Event();
            ev.EventTypeID = EventTypes.AccountLockedOut;
            ev.OccurredOn = DateTime.Now;
            ev.UserID = u.UserID;
            ev.Description = $"{u.Username} locked out due to repeated login failures.";
            Logger.Log(ev);
        }

        private void LogAccessDenied(User u, string reason) {
            Event ev = new Event();
            ev.EventTypeID = EventTypes.LoginFailure;
            ev.OccurredOn = DateTime.Now;
            ev.UserID = u.UserID;
            ev.Description = reason;
            Logger.Log(ev);
        }

        private void LogSuccessfulLogin(User u) {
            Event ev = new Event();
            ev.EventTypeID = EventTypes.LoginSuccess;
            ev.OccurredOn = DateTime.Now;
            ev.UserID = u.UserID;
            ev.Description = $"{u.Username} logged in successfully.";
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
