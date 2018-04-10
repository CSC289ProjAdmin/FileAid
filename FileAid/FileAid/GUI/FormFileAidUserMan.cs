﻿using System;
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
    public partial class FormFileAidUserMan : Form
    {
        private User loggedUser;
        private Permissions perms;
        private User selectedAcct;
        public FormFileAidUserMan(User u)
        {
            InitializeComponent();
            loggedUser = u;
            perms = PermissionsManager.GetPermissionSet(loggedUser.UserID);
        }

        private void FormFileAidUserMan_Load(object sender, EventArgs e)
        {
            UserMantoolTip.SetToolTip(RolecomboBox, "Select the role");
            UserMantoolTip.SetToolTip(LockcheckBox, "User locked out");
            UserMantoolTip.SetToolTip(btnLockUnlock, "Lock/Unlock user account");
            UserMantoolTip.SetToolTip(DisablecheckBox, "User disabled");
            UserMantoolTip.SetToolTip(btnDisableEnable, "Disable/Enable user account");
            UserMantoolTip.SetToolTip(txtPassword, "Enter new password");
            UserMantoolTip.SetToolTip(txtRepeatPass, "Enter same password");
            UserMantoolTip.SetToolTip(btnResetPassword, "Reset password to default");
            UserMantoolTip.SetToolTip(btnChangePassword, "Change password");

            FillDropdown();
            RolecomboBox.SelectedIndex = 0;
        }

        private void FillDropdown() {
            // Fill dropdown based on account rights
            RolecomboBox.Items.Clear();
            bool canModifyAdmin = perms.ChangeAdminPass;
            bool canModifyUser = perms.ChangeUserPass || perms.EnableUser || perms.UnlockUser;
            bool canModifyGuest = perms.ChangeGuestPass || perms.EnableGuest || perms.UnlockGuest;
            if (canModifyAdmin) RolecomboBox.Items.Add("Admin");
            if (canModifyUser) RolecomboBox.Items.Add("User");
            if (canModifyGuest) RolecomboBox.Items.Add("Guest");
        }

        private void SetupPage() {
            // Set button and checkbox state according to permissions
            string acctName = RolecomboBox.SelectedItem.ToString();
            selectedAcct = UserService.Find(acctName);
            switch (acctName) {
                case "Admin":
                    btnLockUnlock.Enabled = false; // Admin cannot be locked
                    LockcheckBox.Checked = false;

                    btnDisableEnable.Enabled = false; // Admin cannot be disabled
                    DisablecheckBox.Checked = false;

                    btnResetPassword.Enabled = false; // Admin password cannot be reset

                    btnChangePassword.Enabled = perms.ChangeAdminPass;
                    break;

                case "User":
                    btnLockUnlock.Enabled = perms.UnlockUser;
                    LockcheckBox.Checked = UserService.IsLockedOut(selectedAcct);

                    btnDisableEnable.Enabled = perms.EnableUser;
                    DisablecheckBox.Checked = UserService.IsDisabled(selectedAcct);

                    btnResetPassword.Enabled = perms.ResetUserPass;

                    btnChangePassword.Enabled = perms.ChangeUserPass;
                    break;

                case "Guest":
                    btnLockUnlock.Enabled = perms.UnlockGuest;
                    LockcheckBox.Checked = UserService.IsLockedOut(selectedAcct);

                    btnDisableEnable.Enabled = perms.EnableGuest;
                    DisablecheckBox.Checked = UserService.IsDisabled(selectedAcct);

                    btnResetPassword.Enabled = perms.ResetGuestPass;

                    btnChangePassword.Enabled = perms.ChangeGuestPass;
                    break;
                default:
                    break;
            }
        }

        private void RolecomboBox_SelectedIndexChanged(object sender, EventArgs e) {
            SetupPage();
        }

        private void btnLockUnlock_Click(object sender, EventArgs e) {
            bool isLocked = LockcheckBox.Checked;
            if (isLocked) UserService.Unlock(selectedAcct);
            else UserService.LockOut(selectedAcct);
            SetupPage();
        }

        private void btnDisableEnable_Click(object sender, EventArgs e) {
            bool isDisabled = DisablecheckBox.Checked;
            if (isDisabled) UserService.Enable(selectedAcct);
            else UserService.Disable(selectedAcct);
            SetupPage();
        }

        private void btnChangePassword_Click(object sender, EventArgs e) {
            string newPassword = txtPassword.Text;
            string rptPassword = txtRepeatPass.Text;
            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(rptPassword)) {
                Messenger.Show("Both password fields are required.");
                return;
            }

            if (newPassword != rptPassword) {
                Messenger.Show("Passwords fields must match.");
                return;
            }

            bool isAlreadyPassword = UserService.VerifyCredentials(selectedAcct, newPassword);
            if (isAlreadyPassword) {
                Messenger.Show("New password must be different than current.");
                return;
            }

            bool isValidPassword = UserService.VerifyPasswordRequirements(newPassword);
            if (!isValidPassword) {
                Messenger.Show("Password does not meet requirements.\n\n" +
                    "8+ characters, 1+ digit, 1+ uppercase, 1+ symbol in *&%$#@");
                return;
            }

            // Set new password
            bool wasChanged = UserService.ChangePassword(selectedAcct, newPassword);
            if (wasChanged) {
                Messenger.Show($"{selectedAcct.Username} password changed.");
                // Log event
            } else {
                Messenger.Show("Password was NOT changed.");
            }
        }
    }
}
