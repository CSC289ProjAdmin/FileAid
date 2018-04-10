﻿namespace FileAid.GUI
{
    partial class FormFileAidUserMan
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRepeatPass = new System.Windows.Forms.TextBox();
            this.RolecomboBox = new System.Windows.Forms.ComboBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRepeatPass = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnLockUnlock = new System.Windows.Forms.Button();
            this.btnDisableEnable = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.LockcheckBox = new System.Windows.Forms.CheckBox();
            this.DisablecheckBox = new System.Windows.Forms.CheckBox();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.UserMantoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMainInfo.Location = new System.Drawing.Point(42, 6);
            this.lblMainInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(525, 26);
            this.lblMainInfo.TabIndex = 1;
            this.lblMainInfo.Text = "Welcome to File Aid User Management Window.";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(213, 146);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(263, 20);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtRepeatPass
            // 
            this.txtRepeatPass.Location = new System.Drawing.Point(213, 187);
            this.txtRepeatPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtRepeatPass.Name = "txtRepeatPass";
            this.txtRepeatPass.Size = new System.Drawing.Size(263, 20);
            this.txtRepeatPass.TabIndex = 13;
            this.txtRepeatPass.UseSystemPasswordChar = true;
            // 
            // RolecomboBox
            // 
            this.RolecomboBox.DropDownHeight = 150;
            this.RolecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RolecomboBox.FormattingEnabled = true;
            this.RolecomboBox.IntegralHeight = false;
            this.RolecomboBox.Items.AddRange(new object[] {
            "Admin",
            "User",
            "Guest"});
            this.RolecomboBox.Location = new System.Drawing.Point(213, 41);
            this.RolecomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.RolecomboBox.Name = "RolecomboBox";
            this.RolecomboBox.Size = new System.Drawing.Size(237, 24);
            this.RolecomboBox.TabIndex = 15;
            this.RolecomboBox.SelectedIndexChanged += new System.EventHandler(this.RolecomboBox_SelectedIndexChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPassword.Location = new System.Drawing.Point(55, 146);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(141, 15);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Password (requried):";
            // 
            // lblRepeatPass
            // 
            this.lblRepeatPass.AutoSize = true;
            this.lblRepeatPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeatPass.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRepeatPass.Location = new System.Drawing.Point(9, 187);
            this.lblRepeatPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRepeatPass.Name = "lblRepeatPass";
            this.lblRepeatPass.Size = new System.Drawing.Size(191, 15);
            this.lblRepeatPass.TabIndex = 22;
            this.lblRepeatPass.Text = "Repeat Password (requried):";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRole.Location = new System.Drawing.Point(149, 44);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(41, 15);
            this.lblRole.TabIndex = 23;
            this.lblRole.Text = "Role:";
            // 
            // btnLockUnlock
            // 
            this.btnLockUnlock.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLockUnlock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLockUnlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLockUnlock.ForeColor = System.Drawing.Color.White;
            this.btnLockUnlock.Location = new System.Drawing.Point(213, 81);
            this.btnLockUnlock.Margin = new System.Windows.Forms.Padding(2);
            this.btnLockUnlock.Name = "btnLockUnlock";
            this.btnLockUnlock.Size = new System.Drawing.Size(113, 34);
            this.btnLockUnlock.TabIndex = 24;
            this.btnLockUnlock.Text = "Lock/Unlock";
            this.btnLockUnlock.UseVisualStyleBackColor = false;
            this.btnLockUnlock.Click += new System.EventHandler(this.btnLockUnlock_Click);
            // 
            // btnDisableEnable
            // 
            this.btnDisableEnable.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDisableEnable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisableEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisableEnable.ForeColor = System.Drawing.Color.White;
            this.btnDisableEnable.Location = new System.Drawing.Point(463, 81);
            this.btnDisableEnable.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisableEnable.Name = "btnDisableEnable";
            this.btnDisableEnable.Size = new System.Drawing.Size(113, 34);
            this.btnDisableEnable.TabIndex = 25;
            this.btnDisableEnable.Text = "Disable/Enable";
            this.btnDisableEnable.UseVisualStyleBackColor = false;
            this.btnDisableEnable.Click += new System.EventHandler(this.btnDisableEnable_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(213, 248);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(113, 34);
            this.btnChangePassword.TabIndex = 26;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // LockcheckBox
            // 
            this.LockcheckBox.AutoSize = true;
            this.LockcheckBox.Enabled = false;
            this.LockcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LockcheckBox.ForeColor = System.Drawing.Color.DarkRed;
            this.LockcheckBox.Location = new System.Drawing.Point(63, 90);
            this.LockcheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.LockcheckBox.Name = "LockcheckBox";
            this.LockcheckBox.Size = new System.Drawing.Size(136, 19);
            this.LockcheckBox.TabIndex = 27;
            this.LockcheckBox.Text = "User Locked Out:";
            this.LockcheckBox.UseVisualStyleBackColor = true;
            // 
            // DisablecheckBox
            // 
            this.DisablecheckBox.AutoSize = true;
            this.DisablecheckBox.Enabled = false;
            this.DisablecheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisablecheckBox.ForeColor = System.Drawing.Color.DarkRed;
            this.DisablecheckBox.Location = new System.Drawing.Point(340, 90);
            this.DisablecheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.DisablecheckBox.Name = "DisablecheckBox";
            this.DisablecheckBox.Size = new System.Drawing.Size(121, 19);
            this.DisablecheckBox.TabIndex = 28;
            this.DisablecheckBox.Text = "User Disabled:";
            this.DisablecheckBox.UseVisualStyleBackColor = true;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Location = new System.Drawing.Point(361, 248);
            this.btnResetPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(113, 34);
            this.btnResetPassword.TabIndex = 29;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // UserMantoolTip
            // 
            this.UserMantoolTip.IsBalloon = true;
            // 
            // FormFileAidUserMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 418);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.DisablecheckBox);
            this.Controls.Add(this.LockcheckBox);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnDisableEnable);
            this.Controls.Add(this.btnLockUnlock);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblRepeatPass);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.RolecomboBox);
            this.Controls.Add(this.txtRepeatPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblMainInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFileAidUserMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FileAidUserManagent";
            this.Load += new System.EventHandler(this.FormFileAidUserMan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainInfo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRepeatPass;
        private System.Windows.Forms.ComboBox RolecomboBox;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRepeatPass;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnLockUnlock;
        private System.Windows.Forms.Button btnDisableEnable;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.CheckBox LockcheckBox;
        private System.Windows.Forms.CheckBox DisablecheckBox;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.ToolTip UserMantoolTip;
    }
}

