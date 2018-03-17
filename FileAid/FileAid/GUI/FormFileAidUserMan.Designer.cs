namespace FileAid.GUI
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
            this.SuspendLayout();
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMainInfo.Location = new System.Drawing.Point(63, 9);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(749, 37);
            this.lblMainInfo.TabIndex = 1;
            this.lblMainInfo.Text = "Welcome to File Aid User Management Window.";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(319, 224);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(353, 26);
            this.txtPassword.TabIndex = 12;
            // 
            // txtRepeatPass
            // 
            this.txtRepeatPass.Location = new System.Drawing.Point(319, 287);
            this.txtRepeatPass.Name = "txtRepeatPass";
            this.txtRepeatPass.Size = new System.Drawing.Size(353, 26);
            this.txtRepeatPass.TabIndex = 13;
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
            this.RolecomboBox.Location = new System.Drawing.Point(319, 63);
            this.RolecomboBox.Name = "RolecomboBox";
            this.RolecomboBox.Size = new System.Drawing.Size(353, 33);
            this.RolecomboBox.TabIndex = 15;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPassword.Location = new System.Drawing.Point(83, 224);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(197, 22);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Password (requried):";
            // 
            // lblRepeatPass
            // 
            this.lblRepeatPass.AutoSize = true;
            this.lblRepeatPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeatPass.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRepeatPass.Location = new System.Drawing.Point(13, 288);
            this.lblRepeatPass.Name = "lblRepeatPass";
            this.lblRepeatPass.Size = new System.Drawing.Size(267, 22);
            this.lblRepeatPass.TabIndex = 22;
            this.lblRepeatPass.Text = "Repeat Password (requried):";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRole.Location = new System.Drawing.Point(223, 68);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(57, 22);
            this.lblRole.TabIndex = 23;
            this.lblRole.Text = "Role:";
            // 
            // btnLockUnlock
            // 
            this.btnLockUnlock.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLockUnlock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLockUnlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLockUnlock.ForeColor = System.Drawing.Color.White;
            this.btnLockUnlock.Location = new System.Drawing.Point(319, 125);
            this.btnLockUnlock.Name = "btnLockUnlock";
            this.btnLockUnlock.Size = new System.Drawing.Size(170, 52);
            this.btnLockUnlock.TabIndex = 24;
            this.btnLockUnlock.Text = "Lock/Unlock";
            this.btnLockUnlock.UseVisualStyleBackColor = false;
            // 
            // btnDisableEnable
            // 
            this.btnDisableEnable.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDisableEnable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisableEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisableEnable.ForeColor = System.Drawing.Color.White;
            this.btnDisableEnable.Location = new System.Drawing.Point(694, 125);
            this.btnDisableEnable.Name = "btnDisableEnable";
            this.btnDisableEnable.Size = new System.Drawing.Size(170, 52);
            this.btnDisableEnable.TabIndex = 25;
            this.btnDisableEnable.Text = "Disable/Enable";
            this.btnDisableEnable.UseVisualStyleBackColor = false;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(513, 365);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(170, 52);
            this.btnChangePassword.TabIndex = 26;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            // 
            // LockcheckBox
            // 
            this.LockcheckBox.AutoSize = true;
            this.LockcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LockcheckBox.ForeColor = System.Drawing.Color.DarkRed;
            this.LockcheckBox.Location = new System.Drawing.Point(94, 138);
            this.LockcheckBox.Name = "LockcheckBox";
            this.LockcheckBox.Size = new System.Drawing.Size(192, 26);
            this.LockcheckBox.TabIndex = 27;
            this.LockcheckBox.Text = "User Locked Out:";
            this.LockcheckBox.UseVisualStyleBackColor = true;
            // 
            // DisablecheckBox
            // 
            this.DisablecheckBox.AutoSize = true;
            this.DisablecheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisablecheckBox.ForeColor = System.Drawing.Color.DarkRed;
            this.DisablecheckBox.Location = new System.Drawing.Point(510, 138);
            this.DisablecheckBox.Name = "DisablecheckBox";
            this.DisablecheckBox.Size = new System.Drawing.Size(168, 26);
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
            this.btnResetPassword.Location = new System.Drawing.Point(319, 365);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(170, 52);
            this.btnResetPassword.TabIndex = 29;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            // 
            // FormFileAidUserMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 643);
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
            this.Name = "FormFileAidUserMan";
            this.Text = "FileAidUserManagent";
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
    }
}

