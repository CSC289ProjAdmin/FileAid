namespace FileAid.GUI
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMainInfo.Location = new System.Drawing.Point(96, 9);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(640, 37);
            this.lblMainInfo.TabIndex = 2;
            this.lblMainInfo.Text = "Welcome to FileAid  Permission Window.";
            // 
            // AdminPasscheckBox
            // 
            this.AdminPasscheckBox.AutoSize = true;
            this.AdminPasscheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPasscheckBox.ForeColor = System.Drawing.Color.Black;
            this.AdminPasscheckBox.Location = new System.Drawing.Point(103, 81);
            this.AdminPasscheckBox.Name = "AdminPasscheckBox";
            this.AdminPasscheckBox.Size = new System.Drawing.Size(265, 26);
            this.AdminPasscheckBox.TabIndex = 3;
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
            this.UserPasscheckBox.Location = new System.Drawing.Point(103, 138);
            this.UserPasscheckBox.Name = "UserPasscheckBox";
            this.UserPasscheckBox.Size = new System.Drawing.Size(246, 26);
            this.UserPasscheckBox.TabIndex = 4;
            this.UserPasscheckBox.Text = "Change User Password";
            this.UserPasscheckBox.UseVisualStyleBackColor = true;
            // 
            // GuestPasscheckBox
            // 
            this.GuestPasscheckBox.AutoSize = true;
            this.GuestPasscheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestPasscheckBox.ForeColor = System.Drawing.Color.Black;
            this.GuestPasscheckBox.Location = new System.Drawing.Point(103, 197);
            this.GuestPasscheckBox.Name = "GuestPasscheckBox";
            this.GuestPasscheckBox.Size = new System.Drawing.Size(257, 26);
            this.GuestPasscheckBox.TabIndex = 6;
            this.GuestPasscheckBox.Text = "Change Guest Password";
            this.GuestPasscheckBox.UseVisualStyleBackColor = true;
            // 
            // EnableUsercheckBox
            // 
            this.EnableUsercheckBox.AutoSize = true;
            this.EnableUsercheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnableUsercheckBox.ForeColor = System.Drawing.Color.Black;
            this.EnableUsercheckBox.Location = new System.Drawing.Point(103, 252);
            this.EnableUsercheckBox.Name = "EnableUsercheckBox";
            this.EnableUsercheckBox.Size = new System.Drawing.Size(146, 26);
            this.EnableUsercheckBox.TabIndex = 7;
            this.EnableUsercheckBox.Text = "Enable User";
            this.EnableUsercheckBox.UseVisualStyleBackColor = true;
            // 
            // EnableGuestcheckBox
            // 
            this.EnableGuestcheckBox.AutoSize = true;
            this.EnableGuestcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnableGuestcheckBox.ForeColor = System.Drawing.Color.Black;
            this.EnableGuestcheckBox.Location = new System.Drawing.Point(103, 321);
            this.EnableGuestcheckBox.Name = "EnableGuestcheckBox";
            this.EnableGuestcheckBox.Size = new System.Drawing.Size(157, 26);
            this.EnableGuestcheckBox.TabIndex = 8;
            this.EnableGuestcheckBox.Text = "Enable Guest";
            this.EnableGuestcheckBox.UseVisualStyleBackColor = true;
            // 
            // ResetUsercheckBox
            // 
            this.ResetUsercheckBox.AutoSize = true;
            this.ResetUsercheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetUsercheckBox.ForeColor = System.Drawing.Color.Black;
            this.ResetUsercheckBox.Location = new System.Drawing.Point(103, 394);
            this.ResetUsercheckBox.Name = "ResetUsercheckBox";
            this.ResetUsercheckBox.Size = new System.Drawing.Size(229, 26);
            this.ResetUsercheckBox.TabIndex = 9;
            this.ResetUsercheckBox.Text = "Reset User Password";
            this.ResetUsercheckBox.UseVisualStyleBackColor = true;
            // 
            // ResetGuestcheckBox
            // 
            this.ResetGuestcheckBox.AutoSize = true;
            this.ResetGuestcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetGuestcheckBox.ForeColor = System.Drawing.Color.Black;
            this.ResetGuestcheckBox.Location = new System.Drawing.Point(103, 461);
            this.ResetGuestcheckBox.Name = "ResetGuestcheckBox";
            this.ResetGuestcheckBox.Size = new System.Drawing.Size(240, 26);
            this.ResetGuestcheckBox.TabIndex = 10;
            this.ResetGuestcheckBox.Text = "Reset Guest Password";
            this.ResetGuestcheckBox.UseVisualStyleBackColor = true;
            // 
            // UnlockUsercheckBox
            // 
            this.UnlockUsercheckBox.AutoSize = true;
            this.UnlockUsercheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnlockUsercheckBox.ForeColor = System.Drawing.Color.Black;
            this.UnlockUsercheckBox.Location = new System.Drawing.Point(103, 520);
            this.UnlockUsercheckBox.Name = "UnlockUsercheckBox";
            this.UnlockUsercheckBox.Size = new System.Drawing.Size(145, 26);
            this.UnlockUsercheckBox.TabIndex = 11;
            this.UnlockUsercheckBox.Text = "Unlock User";
            this.UnlockUsercheckBox.UseVisualStyleBackColor = true;
            // 
            // UnlockGuestcheckBox
            // 
            this.UnlockGuestcheckBox.AutoSize = true;
            this.UnlockGuestcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnlockGuestcheckBox.ForeColor = System.Drawing.Color.Black;
            this.UnlockGuestcheckBox.Location = new System.Drawing.Point(103, 576);
            this.UnlockGuestcheckBox.Name = "UnlockGuestcheckBox";
            this.UnlockGuestcheckBox.Size = new System.Drawing.Size(156, 26);
            this.UnlockGuestcheckBox.TabIndex = 12;
            this.UnlockGuestcheckBox.Text = "Unlock Guest";
            this.UnlockGuestcheckBox.UseVisualStyleBackColor = true;
            // 
            // RestrictGuestcheckBox
            // 
            this.RestrictGuestcheckBox.AutoSize = true;
            this.RestrictGuestcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestrictGuestcheckBox.ForeColor = System.Drawing.Color.Black;
            this.RestrictGuestcheckBox.Location = new System.Drawing.Point(461, 81);
            this.RestrictGuestcheckBox.Name = "RestrictGuestcheckBox";
            this.RestrictGuestcheckBox.Size = new System.Drawing.Size(164, 26);
            this.RestrictGuestcheckBox.TabIndex = 13;
            this.RestrictGuestcheckBox.Text = "Restrict Guest";
            this.RestrictGuestcheckBox.UseVisualStyleBackColor = true;
            // 
            // ResetDBcheckBox
            // 
            this.ResetDBcheckBox.AutoSize = true;
            this.ResetDBcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetDBcheckBox.ForeColor = System.Drawing.Color.Black;
            this.ResetDBcheckBox.Location = new System.Drawing.Point(461, 138);
            this.ResetDBcheckBox.Name = "ResetDBcheckBox";
            this.ResetDBcheckBox.Size = new System.Drawing.Size(179, 26);
            this.ResetDBcheckBox.TabIndex = 14;
            this.ResetDBcheckBox.Text = "Reset Database";
            this.ResetDBcheckBox.UseVisualStyleBackColor = true;
            // 
            // BackupDBcheckBox
            // 
            this.BackupDBcheckBox.AutoSize = true;
            this.BackupDBcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupDBcheckBox.ForeColor = System.Drawing.Color.Black;
            this.BackupDBcheckBox.Location = new System.Drawing.Point(461, 197);
            this.BackupDBcheckBox.Name = "BackupDBcheckBox";
            this.BackupDBcheckBox.Size = new System.Drawing.Size(193, 26);
            this.BackupDBcheckBox.TabIndex = 15;
            this.BackupDBcheckBox.Text = "Backup Database";
            this.BackupDBcheckBox.UseVisualStyleBackColor = true;
            // 
            // RestoreDBcheckBox
            // 
            this.RestoreDBcheckBox.AutoSize = true;
            this.RestoreDBcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestoreDBcheckBox.ForeColor = System.Drawing.Color.Black;
            this.RestoreDBcheckBox.Location = new System.Drawing.Point(461, 252);
            this.RestoreDBcheckBox.Name = "RestoreDBcheckBox";
            this.RestoreDBcheckBox.Size = new System.Drawing.Size(197, 26);
            this.RestoreDBcheckBox.TabIndex = 16;
            this.RestoreDBcheckBox.Text = "Restore Database";
            this.RestoreDBcheckBox.UseVisualStyleBackColor = true;
            // 
            // BatchScancheckBox
            // 
            this.BatchScancheckBox.AutoSize = true;
            this.BatchScancheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatchScancheckBox.ForeColor = System.Drawing.Color.Black;
            this.BatchScancheckBox.Location = new System.Drawing.Point(461, 321);
            this.BatchScancheckBox.Name = "BatchScancheckBox";
            this.BatchScancheckBox.Size = new System.Drawing.Size(138, 26);
            this.BatchScancheckBox.TabIndex = 17;
            this.BatchScancheckBox.Text = "Batch Scan";
            this.BatchScancheckBox.UseVisualStyleBackColor = true;
            // 
            // ProgramSetcheckBox
            // 
            this.ProgramSetcheckBox.AutoSize = true;
            this.ProgramSetcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramSetcheckBox.ForeColor = System.Drawing.Color.Black;
            this.ProgramSetcheckBox.Location = new System.Drawing.Point(461, 394);
            this.ProgramSetcheckBox.Name = "ProgramSetcheckBox";
            this.ProgramSetcheckBox.Size = new System.Drawing.Size(169, 26);
            this.ProgramSetcheckBox.TabIndex = 18;
            this.ProgramSetcheckBox.Text = "Program Setup";
            this.ProgramSetcheckBox.UseVisualStyleBackColor = true;
            // 
            // LoginMancheckBox
            // 
            this.LoginMancheckBox.AutoSize = true;
            this.LoginMancheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginMancheckBox.ForeColor = System.Drawing.Color.Black;
            this.LoginMancheckBox.Location = new System.Drawing.Point(461, 461);
            this.LoginMancheckBox.Name = "LoginMancheckBox";
            this.LoginMancheckBox.Size = new System.Drawing.Size(204, 26);
            this.LoginMancheckBox.TabIndex = 19;
            this.LoginMancheckBox.Text = "Login Management";
            this.LoginMancheckBox.UseVisualStyleBackColor = true;
            // 
            // DBMancheckBox
            // 
            this.DBMancheckBox.AutoSize = true;
            this.DBMancheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBMancheckBox.ForeColor = System.Drawing.Color.Black;
            this.DBMancheckBox.Location = new System.Drawing.Point(461, 531);
            this.DBMancheckBox.Name = "DBMancheckBox";
            this.DBMancheckBox.Size = new System.Drawing.Size(240, 26);
            this.DBMancheckBox.TabIndex = 20;
            this.DBMancheckBox.Text = "Database Management";
            this.DBMancheckBox.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(701, 81);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 49);
            this.btnLogin.TabIndex = 21;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(701, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 49);
            this.button1.TabIndex = 22;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormFileAidPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogin);
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
            this.Name = "FormFileAidPermission";
            this.Text = "FileAid Permission";
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
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button button1;
    }
}

