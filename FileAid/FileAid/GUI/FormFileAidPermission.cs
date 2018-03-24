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
    public partial class FormFileAidPermission : Form
    {
        public FormFileAidPermission()
        {
            InitializeComponent();
        }
        
        private void FormFileAidPermission_Load(object sender, EventArgs e)
        {
            PermissiontoolTip.SetToolTip(AdminPasscheckBox, "Allows changing Admin password.");
            PermissiontoolTip.SetToolTip(UserPasscheckBox, "Allows changing User Password.");
            PermissiontoolTip.SetToolTip(GuestPasscheckBox, "Allows changing Guest Password.");
            PermissiontoolTip.SetToolTip(EnableUsercheckBox, "Allows enabling User account.");
            PermissiontoolTip.SetToolTip(EnableGuestcheckBox, "Allows enabling Guest account.");
            PermissiontoolTip.SetToolTip(ResetUsercheckBox, "Allows reseting User Password.");
            PermissiontoolTip.SetToolTip(ResetGuestcheckBox, "Allows reseting Guest Password.");
            PermissiontoolTip.SetToolTip(UnlockUsercheckBox, "Allows Unlocking User account.");
            PermissiontoolTip.SetToolTip(UnlockGuestcheckBox, "Allows Unlocking Guest account.");
            PermissiontoolTip.SetToolTip(RestrictGuestcheckBox, "Allows restricting Guest account.");
            PermissiontoolTip.SetToolTip(ResetDBcheckBox, "Allows reseting Database.");
            PermissiontoolTip.SetToolTip(BackupDBcheckBox, "Allows backing up Database.");
            PermissiontoolTip.SetToolTip(RestoreDBcheckBox, "Allows restoring Database.");
            PermissiontoolTip.SetToolTip(BatchScancheckBox, "Allows Batch Scaning.");
            PermissiontoolTip.SetToolTip(ProgramSetcheckBox, "Allows Program Setup.");
            PermissiontoolTip.SetToolTip(LoginMancheckBox, "Allows Managing Login.");
            PermissiontoolTip.SetToolTip(DBMancheckBox, "Allows Managing Database.");
           
        }

        
    }
}
