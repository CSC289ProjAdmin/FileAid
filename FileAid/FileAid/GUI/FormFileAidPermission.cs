﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FileAid.Models;
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

            try
            {
                User guest = UserService.Find("Guest");
                if (guest == null) {
                    MessageBox.Show("Unable to load guest account rights");
                    return;
                }

                Permissions guestPerms = PermissionsManager.GetPermissionSet(guest.UserID);
                if(guestPerms == null)
                {
                    MessageBox.Show("Unable to load guest account rights");
                    return;
                }

                AdminPasscheckBox.Checked = guestPerms.ChangeAdminPass;
                UserPasscheckBox.Checked = guestPerms.ChangeUserPass;
                GuestPasscheckBox.Checked = guestPerms.ChangeGuestPass;
                EnableUsercheckBox.Checked = guestPerms.EnableUser;
                EnableGuestcheckBox.Checked = guestPerms.EnableGuest;
                ResetUsercheckBox.Checked = guestPerms.ResetUserPass;
                ResetGuestcheckBox.Checked = guestPerms.ResetGuestPass;
                UnlockUsercheckBox.Checked = guestPerms.UnlockUser;
                UnlockGuestcheckBox.Checked = guestPerms.UnlockGuest;
                RestrictGuestcheckBox.Checked = guestPerms.RestrictGuest;
                ResetDBcheckBox.Checked = guestPerms.ResetDb;
                BackupDBcheckBox.Checked = guestPerms.BackupDb;
                RestoreDBcheckBox.Checked = guestPerms.RestoreDb;
                BatchScancheckBox.Checked = guestPerms.BatchScan;
                ProgramSetcheckBox.Checked = guestPerms.ProgramSetup;
                LoginMancheckBox.Checked = guestPerms.LoginMgmt;
                DBMancheckBox.Checked = guestPerms.DbMgmt;
            }
            catch (SqlException)
            {
                Messenger.ShowDbMsg();
            }


        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

            try
            {
                User guest = UserService.Find("Guest");
                if (guest == null) {
                    MessageBox.Show("Unable to load guest account rights. Cannot save changes.");
                    return;
                }

                Permissions guestPerms = PermissionsManager.GetPermissionSet(guest.UserID);
                if (guestPerms == null)
                {
                    MessageBox.Show("Unable to load guest account rights. Cannot save changes.");
                    return;
                }
                
                guestPerms.ChangeAdminPass = AdminPasscheckBox.Checked;
                guestPerms.ChangeUserPass = UserPasscheckBox.Checked;
                guestPerms.ChangeGuestPass = GuestPasscheckBox.Checked;
                guestPerms.EnableUser = EnableUsercheckBox.Checked;
                guestPerms.EnableGuest = EnableGuestcheckBox.Checked;
                guestPerms.ResetUserPass = ResetUsercheckBox.Checked;
                guestPerms.ResetGuestPass = ResetGuestcheckBox.Checked;
                guestPerms.UnlockUser = UnlockUsercheckBox.Checked;
                guestPerms.UnlockGuest = UnlockGuestcheckBox.Checked;
                guestPerms.RestrictGuest = RestrictGuestcheckBox.Checked;
                guestPerms.ResetDb = ResetDBcheckBox.Checked;
                guestPerms.BackupDb = BackupDBcheckBox.Checked;
                guestPerms.RestoreDb = RestoreDBcheckBox.Checked;
                guestPerms.BatchScan = BatchScancheckBox.Checked;
                guestPerms.ProgramSetup = ProgramSetcheckBox.Checked;
                guestPerms.LoginMgmt = LoginMancheckBox.Checked;
                guestPerms.DbMgmt = DBMancheckBox.Checked;

                bool wasUpdate = PermissionsManager.UpdatePermissionSet(guestPerms);
                if (wasUpdate)
                {
                    bool wasLogged = LogPermission(guestPerms.PermID);
                    if (!wasLogged)
                    {
                        Messenger.Show("Failed to record setting change event.");
                    }
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to save changes");
                    DialogResult = DialogResult.None; 
                }
              
            }
            catch (SqlException)
            {
                Messenger.ShowDbMsg();
            }
        }

        private void btnPerCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool LogPermission(int permissionId)
        {
            Event ev = new Event();
            ev.EventTypeID = EventTypes.AccountPermsChanged;
            ev.ReportID = permissionId;
            ev.OccurredOn = DateTime.Now;
            ev.Description = "Guest rights modified";
            bool wasLogged = Logger.Log(ev);
            return wasLogged;
        }
    }
}
