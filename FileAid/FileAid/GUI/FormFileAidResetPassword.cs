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
    public partial class FormFileAidResetPassword : Form
    {
        private string caption = "FileAdd Password Reset";
        private User loggedUser;
        public FormFileAidResetPassword(User currentUser)
        {
            InitializeComponent();
            loggedUser = currentUser;
        }

        private void btnResetPassword_Click(object sender, EventArgs e) {
            // checks:
            // all fields filled
            // current password is correct
            // new + repeat match
            // new != current
            // new meets password requirements

            string currPass = txtCurrentPassword.Text.Trim();
            string newPass = txtNewPassword.Text.Trim();
            string rptPass = txtRepeatPassword.Text.Trim();

            bool areRequiredFieldsFilled = (!string.IsNullOrEmpty(currPass) &&
                !string.IsNullOrEmpty(newPass) &&
                !string.IsNullOrEmpty(rptPass));
            if (!areRequiredFieldsFilled) {
                lblErrorMsg.Text = "All fields are required.";
                txtCurrentPassword.Focus();
                return;
            }
            try {
                bool currentPassMatches = UserService.VerifyCredentials(loggedUser, currPass);
                if (!currentPassMatches) {
                    lblErrorMsg.Text = "Current password entered is incorrect.";
                    txtCurrentPassword.Focus();
                    return;
                }

                bool newPasswordsMatch = (newPass == rptPass);
                if (!newPasswordsMatch) {
                    lblErrorMsg.Text = "New password fields must match.";
                    txtNewPassword.Focus();
                    return;
                }

                bool isDifferentPassword = (newPass != currPass);
                if (!isDifferentPassword) {
                    lblErrorMsg.Text = "New password must be different from current password.";
                    txtNewPassword.Focus();
                    return;
                }

                bool isValidPassword = UserService.VerifyPasswordRequirements(newPass);
                if (!isValidPassword) {
                    lblErrorMsg.Text = "New password does neet meet password rules:\n" +
                        "8+ characters, 1+ digit, 1+ uppercase, 1+ symbol in *&%$#@";
                    txtNewPassword.Focus();
                    return;
                }

                lblErrorMsg.Text = "";

                // Set new password
                bool wasChanged = UserService.ChangePassword(loggedUser, newPass);
                if (wasChanged) {
                    Messenger.Show($"{loggedUser.Username} password changed.", caption);
                    LogPasswordChange();

                    // Change reset flag
                    UserService.ClearResetFlag(loggedUser);
                } else {
                    Messenger.Show("Password was NOT changed.", caption);
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (SqlException) {
                Messenger.ShowDbMsg();
            }
        }

        private void LogPasswordChange() {
            Event ev = new Event();
            ev.OccurredOn = DateTime.Now;
            ev.EventTypeID = EventTypes.AccountPasswordChanged;
            ev.UserID = loggedUser.UserID;
            ev.Description = $"Account Management: {loggedUser.Username} changed their password during login.";
            Logger.Log(ev);
        }

        private void FormFileAidLogin_Load(object sender, EventArgs e)
        {
            LogintoolTip.SetToolTip(txtCurrentPassword, "Enter current password");
            LogintoolTip.SetToolTip(txtNewPassword, "Enter new password");
            LogintoolTip.SetToolTip(btnResetPassword, "Reset Password");
            txtCurrentPassword.Focus();
        }
    }
}
