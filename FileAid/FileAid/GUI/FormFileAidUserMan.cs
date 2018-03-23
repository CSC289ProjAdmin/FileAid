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
    public partial class FormFileAidUserMan : Form
    {
        public FormFileAidUserMan()
        {
            InitializeComponent();
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
        }
    }
}
