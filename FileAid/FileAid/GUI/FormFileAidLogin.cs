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
                return;
            }

            bool passMatches = UserService.VerifyCredentials(u, password);
            if (!passMatches) {
                lblErrorMsg.Text = "Invalid credentials.";
                bool isAdmin = !(u.Username == "Admin");
                bool isLocked = UserService.IsLockedOut(u);
                if (!isAdmin && !isLocked) {
                    UserService.IncrementFailures(u);
                    // Log increment event
                    bool needsLocking = (u.LoginFailures >= 3);
                    if (needsLocking) {
                        bool wasLocked = UserService.LockOut(u);
                        if (wasLocked) {
                            // Notify and log event
                            Messenger.Show("Account locked out for repeated failed logins.", "Account Locked");
                        }
                    }
                }
                return;
            }

            bool isLockedOut = UserService.IsLockedOut(u);
            if (isLockedOut) {
                DateTime unlocksAt = u.LockedOutOn + TimeSpan.FromHours(1);
                lblErrorMsg.Text = $"Account is locked out until {unlocksAt.ToString()}.";
                return;
            }

            bool isDisabled = UserService.IsDisabled(u);
            if (isDisabled) {
                lblErrorMsg.Text = "Account is disabled and cannot log in.";
                return;
            }

            // Account is good otherwise.
            // TODO: clear account (Unlock, ClearFailures)
            // Calling form is responsible for getting account & rights.
            DialogResult = DialogResult.OK;
            Close();
        }

        private void FormFileAidLogin_Load(object sender, EventArgs e)
        {
            LogintoolTip.SetToolTip(txtUserName, "Enter username");
            LogintoolTip.SetToolTip(txtPassword, "Enter password");
            LogintoolTip.SetToolTip(btnLogin, "Login to FileAid");
        }
    }
}
