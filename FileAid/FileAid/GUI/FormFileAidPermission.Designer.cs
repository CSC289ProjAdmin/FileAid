﻿namespace FileAid.GUI
{
    partial class FormFileAidPermission
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMainInfo = new System.Windows.Forms.Label();
            this.AdminPasscheckBox = new System.Windows.Forms.CheckBox();
            this.PermissiontoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.UserPasscheckBox = new System.Windows.Forms.CheckBox();
            this.GuestPasscheckBox = new System.Windows.Forms.CheckBox();
            this.EnableUsercheckBox = new System.Windows.Forms.CheckBox();
            this.EnableGuestcheckBox = new System.Windows.Forms.CheckBox();
            this.ResetUsercheckBox = new System.Windows.Forms.CheckBox();
            this.ResetGuestcheckBox = new System.Windows.Forms.CheckBox();
            this.UnlockUsercheckBox = new System.Windows.Forms.CheckBox();
            this.UnlockGuestcheckBox = new System.Windows.Forms.CheckBox();
            this.RestrictGuestcheckBox = new System.Windows.Forms.CheckBox();
            this.ResetDBcheckBox = new System.Windows.Forms.CheckBox();
            this.BackupDBcheckBox = new System.Windows.Forms.CheckBox();
            this.RestoreDBcheckBox = new System.Windows.Forms.CheckBox();
            this.BatchScancheckBox = new System.Windows.Forms.CheckBox();
            this.ProgramSetcheckBox = new System.Windows.Forms.CheckBox();
            this.LoginMancheckBox = new System.Windows.Forms.CheckBox();
            this.DBMancheckBox = new System.Windows.Forms.CheckBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnPerCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMainInfo.Location = new System.Drawing.Point(284, 6);
            this.lblMainInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(231, 26);
            this.lblMainInfo.TabIndex = 0;
            this.lblMainInfo.Text = "FileAid Guest Rights";
            // 
            // AdminPasscheckBox
            // 
            this.AdminPasscheckBox.AutoSize = true;
            this.AdminPasscheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPasscheckBox.ForeColor = System.Drawing.Color.Black;
            this.AdminPasscheckBox.Location = new System.Drawing.Point(378, 71);
            this.AdminPasscheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.AdminPasscheckBox.Name = "AdminPasscheckBox";
            this.AdminPasscheckBox.Size = new System.Drawing.Size(189, 19);
            this.AdminPasscheckBox.TabIndex = 10;
            this.AdminPasscheckBox.Text = "Change Admin Password ";
            this.PermissiontoolTip.SetToolTip(this.AdminPasscheckBox, "Check the CheckBox");
            this.AdminPasscheckBox.UseVisualStyleBackColor = true;
            // 
            // PermissiontoolTip
            // 
            this.PermissiontoolTip.IsBalloon = true;
            this.PermissiontoolTip.StripAmpersands = true;
            // 
            // UserPasscheckBox
            // 
            this.UserPasscheckBox.AutoSize = true;
            this.UserPasscheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPasscheckBox.ForeColor = System.Drawing.Color.Black;
            this.UserPasscheckBox.Location = new System.Drawing.Point(378, 108);
            this.UserPasscheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.UserPasscheckBox.Name = "UserPasscheckBox";
            this.UserPasscheckBox.Size = new System.Drawing.Size(175, 19);
            this.UserPasscheckBox.TabIndex = 11;
            this.UserPasscheckBox.Text = "Change User Password";
            this.UserPasscheckBox.UseVisualStyleBackColor = true;
            // 
            // GuestPasscheckBox
            // 
            this.GuestPasscheckBox.AutoSize = true;
            this.GuestPasscheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestPasscheckBox.ForeColor = System.Drawing.Color.Black;
            this.GuestPasscheckBox.Location = new System.Drawing.Point(378, 145);
            this.GuestPasscheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.GuestPasscheckBox.Name = "GuestPasscheckBox";
            this.GuestPasscheckBox.Size = new System.Drawing.Size(182, 19);
            this.GuestPasscheckBox.TabIndex = 12;
            this.GuestPasscheckBox.Text = "Change Guest Password";
            this.GuestPasscheckBox.UseVisualStyleBackColor = true;
            // 
            // EnableUsercheckBox
            // 
            this.EnableUsercheckBox.AutoSize = true;
            this.EnableUsercheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnableUsercheckBox.ForeColor = System.Drawing.Color.Black;
            this.EnableUsercheckBox.Location = new System.Drawing.Point(210, 143);
            this.EnableUsercheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.EnableUsercheckBox.Name = "EnableUsercheckBox";
            this.EnableUsercheckBox.Size = new System.Drawing.Size(105, 19);
            this.EnableUsercheckBox.TabIndex = 8;
            this.EnableUsercheckBox.Text = "Enable User";
            this.EnableUsercheckBox.UseVisualStyleBackColor = true;
            // 
            // EnableGuestcheckBox
            // 
            this.EnableGuestcheckBox.AutoSize = true;
            this.EnableGuestcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnableGuestcheckBox.ForeColor = System.Drawing.Color.Black;
            this.EnableGuestcheckBox.Location = new System.Drawing.Point(210, 180);
            this.EnableGuestcheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.EnableGuestcheckBox.Name = "EnableGuestcheckBox";
            this.EnableGuestcheckBox.Size = new System.Drawing.Size(112, 19);
            this.EnableGuestcheckBox.TabIndex = 9;
            this.EnableGuestcheckBox.Text = "Enable Guest";
            this.EnableGuestcheckBox.UseVisualStyleBackColor = true;
            // 
            // ResetUsercheckBox
            // 
            this.ResetUsercheckBox.AutoSize = true;
            this.ResetUsercheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetUsercheckBox.ForeColor = System.Drawing.Color.Black;
            this.ResetUsercheckBox.Location = new System.Drawing.Point(378, 184);
            this.ResetUsercheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.ResetUsercheckBox.Name = "ResetUsercheckBox";
            this.ResetUsercheckBox.Size = new System.Drawing.Size(163, 19);
            this.ResetUsercheckBox.TabIndex = 13;
            this.ResetUsercheckBox.Text = "Reset User Password";
            this.ResetUsercheckBox.UseVisualStyleBackColor = true;
            // 
            // ResetGuestcheckBox
            // 
            this.ResetGuestcheckBox.AutoSize = true;
            this.ResetGuestcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetGuestcheckBox.ForeColor = System.Drawing.Color.Black;
            this.ResetGuestcheckBox.Location = new System.Drawing.Point(378, 222);
            this.ResetGuestcheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.ResetGuestcheckBox.Name = "ResetGuestcheckBox";
            this.ResetGuestcheckBox.Size = new System.Drawing.Size(170, 19);
            this.ResetGuestcheckBox.TabIndex = 14;
            this.ResetGuestcheckBox.Text = "Reset Guest Password";
            this.ResetGuestcheckBox.UseVisualStyleBackColor = true;
            // 
            // UnlockUsercheckBox
            // 
            this.UnlockUsercheckBox.AutoSize = true;
            this.UnlockUsercheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnlockUsercheckBox.ForeColor = System.Drawing.Color.Black;
            this.UnlockUsercheckBox.Location = new System.Drawing.Point(210, 71);
            this.UnlockUsercheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.UnlockUsercheckBox.Name = "UnlockUsercheckBox";
            this.UnlockUsercheckBox.Size = new System.Drawing.Size(104, 19);
            this.UnlockUsercheckBox.TabIndex = 6;
            this.UnlockUsercheckBox.Text = "Unlock User";
            this.UnlockUsercheckBox.UseVisualStyleBackColor = true;
            // 
            // UnlockGuestcheckBox
            // 
            this.UnlockGuestcheckBox.AutoSize = true;
            this.UnlockGuestcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnlockGuestcheckBox.ForeColor = System.Drawing.Color.Black;
            this.UnlockGuestcheckBox.Location = new System.Drawing.Point(210, 108);
            this.UnlockGuestcheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.UnlockGuestcheckBox.Name = "UnlockGuestcheckBox";
            this.UnlockGuestcheckBox.Size = new System.Drawing.Size(111, 19);
            this.UnlockGuestcheckBox.TabIndex = 7;
            this.UnlockGuestcheckBox.Text = "Unlock Guest";
            this.UnlockGuestcheckBox.UseVisualStyleBackColor = true;
            // 
            // RestrictGuestcheckBox
            // 
            this.RestrictGuestcheckBox.AutoSize = true;
            this.RestrictGuestcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestrictGuestcheckBox.ForeColor = System.Drawing.Color.Black;
            this.RestrictGuestcheckBox.Location = new System.Drawing.Point(11, 184);
            this.RestrictGuestcheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.RestrictGuestcheckBox.Name = "RestrictGuestcheckBox";
            this.RestrictGuestcheckBox.Size = new System.Drawing.Size(137, 19);
            this.RestrictGuestcheckBox.TabIndex = 4;
            this.RestrictGuestcheckBox.Text = "Edit Guest Rights";
            this.RestrictGuestcheckBox.UseVisualStyleBackColor = true;
            // 
            // ResetDBcheckBox
            // 
            this.ResetDBcheckBox.AutoSize = true;
            this.ResetDBcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetDBcheckBox.ForeColor = System.Drawing.Color.Black;
            this.ResetDBcheckBox.Location = new System.Drawing.Point(631, 112);
            this.ResetDBcheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.ResetDBcheckBox.Name = "ResetDBcheckBox";
            this.ResetDBcheckBox.Size = new System.Drawing.Size(128, 19);
            this.ResetDBcheckBox.TabIndex = 16;
            this.ResetDBcheckBox.Text = "Reset Database";
            this.ResetDBcheckBox.UseVisualStyleBackColor = true;
            // 
            // BackupDBcheckBox
            // 
            this.BackupDBcheckBox.AutoSize = true;
            this.BackupDBcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupDBcheckBox.ForeColor = System.Drawing.Color.Black;
            this.BackupDBcheckBox.Location = new System.Drawing.Point(631, 71);
            this.BackupDBcheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.BackupDBcheckBox.Name = "BackupDBcheckBox";
            this.BackupDBcheckBox.Size = new System.Drawing.Size(138, 19);
            this.BackupDBcheckBox.TabIndex = 15;
            this.BackupDBcheckBox.Text = "Backup Database";
            this.BackupDBcheckBox.UseVisualStyleBackColor = true;
            // 
            // RestoreDBcheckBox
            // 
            this.RestoreDBcheckBox.AutoSize = true;
            this.RestoreDBcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestoreDBcheckBox.ForeColor = System.Drawing.Color.Black;
            this.RestoreDBcheckBox.Location = new System.Drawing.Point(631, 154);
            this.RestoreDBcheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.RestoreDBcheckBox.Name = "RestoreDBcheckBox";
            this.RestoreDBcheckBox.Size = new System.Drawing.Size(141, 19);
            this.RestoreDBcheckBox.TabIndex = 17;
            this.RestoreDBcheckBox.Text = "Restore Database";
            this.RestoreDBcheckBox.UseVisualStyleBackColor = true;
            // 
            // BatchScancheckBox
            // 
            this.BatchScancheckBox.AutoSize = true;
            this.BatchScancheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchScancheckBox.ForeColor = System.Drawing.Color.Black;
            this.BatchScancheckBox.Location = new System.Drawing.Point(11, 71);
            this.BatchScancheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.BatchScancheckBox.Name = "BatchScancheckBox";
            this.BatchScancheckBox.Size = new System.Drawing.Size(135, 19);
            this.BatchScancheckBox.TabIndex = 1;
            this.BatchScancheckBox.Text = "Run Batch Scans";
            this.BatchScancheckBox.UseVisualStyleBackColor = true;
            // 
            // ProgramSetcheckBox
            // 
            this.ProgramSetcheckBox.AutoSize = true;
            this.ProgramSetcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramSetcheckBox.ForeColor = System.Drawing.Color.Black;
            this.ProgramSetcheckBox.Location = new System.Drawing.Point(11, 108);
            this.ProgramSetcheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.ProgramSetcheckBox.Name = "ProgramSetcheckBox";
            this.ProgramSetcheckBox.Size = new System.Drawing.Size(122, 19);
            this.ProgramSetcheckBox.TabIndex = 2;
            this.ProgramSetcheckBox.Text = "Program Setup";
            this.ProgramSetcheckBox.UseVisualStyleBackColor = true;
            // 
            // LoginMancheckBox
            // 
            this.LoginMancheckBox.AutoSize = true;
            this.LoginMancheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginMancheckBox.ForeColor = System.Drawing.Color.Black;
            this.LoginMancheckBox.Location = new System.Drawing.Point(11, 145);
            this.LoginMancheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.LoginMancheckBox.Name = "LoginMancheckBox";
            this.LoginMancheckBox.Size = new System.Drawing.Size(144, 19);
            this.LoginMancheckBox.TabIndex = 3;
            this.LoginMancheckBox.Text = "User Management";
            this.LoginMancheckBox.UseVisualStyleBackColor = true;
            // 
            // DBMancheckBox
            // 
            this.DBMancheckBox.AutoSize = true;
            this.DBMancheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBMancheckBox.ForeColor = System.Drawing.Color.Black;
            this.DBMancheckBox.Location = new System.Drawing.Point(11, 222);
            this.DBMancheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.DBMancheckBox.Name = "DBMancheckBox";
            this.DBMancheckBox.Size = new System.Drawing.Size(175, 19);
            this.DBMancheckBox.TabIndex = 5;
            this.DBMancheckBox.Text = "Database Management";
            this.DBMancheckBox.UseVisualStyleBackColor = true;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(242, 304);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(133, 32);
            this.btnSaveChanges.TabIndex = 18;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnPerCancel
            // 
            this.btnPerCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPerCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPerCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerCancel.ForeColor = System.Drawing.Color.White;
            this.btnPerCancel.Location = new System.Drawing.Point(423, 304);
            this.btnPerCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnPerCancel.Name = "btnPerCancel";
            this.btnPerCancel.Size = new System.Drawing.Size(133, 32);
            this.btnPerCancel.TabIndex = 19;
            this.btnPerCancel.Text = "Cancel";
            this.btnPerCancel.UseVisualStyleBackColor = false;
            this.btnPerCancel.Click += new System.EventHandler(this.btnPerCancel_Click);
            // 
            // FormFileAidPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 434);
            this.Controls.Add(this.btnPerCancel);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.DBMancheckBox);
            this.Controls.Add(this.LoginMancheckBox);
            this.Controls.Add(this.ProgramSetcheckBox);
            this.Controls.Add(this.BatchScancheckBox);
            this.Controls.Add(this.RestoreDBcheckBox);
            this.Controls.Add(this.BackupDBcheckBox);
            this.Controls.Add(this.ResetDBcheckBox);
            this.Controls.Add(this.RestrictGuestcheckBox);
            this.Controls.Add(this.UnlockGuestcheckBox);
            this.Controls.Add(this.UnlockUsercheckBox);
            this.Controls.Add(this.ResetGuestcheckBox);
            this.Controls.Add(this.ResetUsercheckBox);
            this.Controls.Add(this.EnableGuestcheckBox);
            this.Controls.Add(this.EnableUsercheckBox);
            this.Controls.Add(this.GuestPasscheckBox);
            this.Controls.Add(this.UserPasscheckBox);
            this.Controls.Add(this.AdminPasscheckBox);
            this.Controls.Add(this.lblMainInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFileAidPermission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FileAid Guest Rights";
            this.Load += new System.EventHandler(this.FormFileAidPermission_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainInfo;
        private System.Windows.Forms.CheckBox AdminPasscheckBox;
        private System.Windows.Forms.ToolTip PermissiontoolTip;
        private System.Windows.Forms.CheckBox UserPasscheckBox;
        private System.Windows.Forms.CheckBox GuestPasscheckBox;
        private System.Windows.Forms.CheckBox EnableUsercheckBox;
        private System.Windows.Forms.CheckBox EnableGuestcheckBox;
        private System.Windows.Forms.CheckBox ResetUsercheckBox;
        private System.Windows.Forms.CheckBox ResetGuestcheckBox;
        private System.Windows.Forms.CheckBox UnlockUsercheckBox;
        private System.Windows.Forms.CheckBox UnlockGuestcheckBox;
        private System.Windows.Forms.CheckBox RestrictGuestcheckBox;
        private System.Windows.Forms.CheckBox ResetDBcheckBox;
        private System.Windows.Forms.CheckBox BackupDBcheckBox;
        private System.Windows.Forms.CheckBox RestoreDBcheckBox;
        private System.Windows.Forms.CheckBox BatchScancheckBox;
        private System.Windows.Forms.CheckBox ProgramSetcheckBox;
        private System.Windows.Forms.CheckBox LoginMancheckBox;
        private System.Windows.Forms.CheckBox DBMancheckBox;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnPerCancel;
    }
}

