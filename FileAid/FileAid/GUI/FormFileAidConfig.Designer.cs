namespace FileAid.GUI
{
    partial class FormFileAidConfig
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
            this.PeriodicdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnPeriodicUpdate = new System.Windows.Forms.Button();
            this.btnModifiedFiles = new System.Windows.Forms.Button();
            this.lblPeriodicUpdate = new System.Windows.Forms.Label();
            this.ConfiglistView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConfigtoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMainInfo.Location = new System.Drawing.Point(101, 22);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(571, 37);
            this.lblMainInfo.TabIndex = 1;
            this.lblMainInfo.Text = "Welcome to File Aid Config Window.";
            // 
            // PeriodicdateTimePicker
            // 
            this.PeriodicdateTimePicker.CustomFormat = "m";
            this.PeriodicdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PeriodicdateTimePicker.Location = new System.Drawing.Point(322, 88);
            this.PeriodicdateTimePicker.Name = "PeriodicdateTimePicker";
            this.PeriodicdateTimePicker.ShowUpDown = true;
            this.PeriodicdateTimePicker.Size = new System.Drawing.Size(96, 26);
            this.PeriodicdateTimePicker.TabIndex = 2;
            // 
            // btnPeriodicUpdate
            // 
            this.btnPeriodicUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPeriodicUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPeriodicUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeriodicUpdate.ForeColor = System.Drawing.Color.White;
            this.btnPeriodicUpdate.Location = new System.Drawing.Point(424, 76);
            this.btnPeriodicUpdate.Name = "btnPeriodicUpdate";
            this.btnPeriodicUpdate.Size = new System.Drawing.Size(179, 52);
            this.btnPeriodicUpdate.TabIndex = 9;
            this.btnPeriodicUpdate.Text = "Periodic Update";
            this.btnPeriodicUpdate.UseVisualStyleBackColor = false;
            // 
            // btnModifiedFiles
            // 
            this.btnModifiedFiles.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnModifiedFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifiedFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifiedFiles.ForeColor = System.Drawing.Color.White;
            this.btnModifiedFiles.Location = new System.Drawing.Point(620, 76);
            this.btnModifiedFiles.Name = "btnModifiedFiles";
            this.btnModifiedFiles.Size = new System.Drawing.Size(154, 52);
            this.btnModifiedFiles.TabIndex = 10;
            this.btnModifiedFiles.Text = "Display Files";
            this.btnModifiedFiles.UseVisualStyleBackColor = false;
            // 
            // lblPeriodicUpdate
            // 
            this.lblPeriodicUpdate.AutoSize = true;
            this.lblPeriodicUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodicUpdate.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPeriodicUpdate.Location = new System.Drawing.Point(44, 88);
            this.lblPeriodicUpdate.Name = "lblPeriodicUpdate";
            this.lblPeriodicUpdate.Size = new System.Drawing.Size(256, 22);
            this.lblPeriodicUpdate.TabIndex = 11;
            this.lblPeriodicUpdate.Text = "Periodic Update in Minutes:";
            // 
            // ConfiglistView
            // 
            this.ConfiglistView.AllowColumnReorder = true;
            this.ConfiglistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ConfiglistView.FullRowSelect = true;
            this.ConfiglistView.GridLines = true;
            this.ConfiglistView.Location = new System.Drawing.Point(48, 143);
            this.ConfiglistView.Name = "ConfiglistView";
            this.ConfiglistView.Size = new System.Drawing.Size(713, 486);
            this.ConfiglistView.TabIndex = 12;
            this.ConfiglistView.UseCompatibleStateImageBehavior = false;
            this.ConfiglistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Modified Files";
            this.columnHeader1.Width = 178;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Inactive Files";
            this.columnHeader2.Width = 171;
            // 
            // ConfigtoolTip
            // 
            this.ConfigtoolTip.IsBalloon = true;
            // 
            // FormFileAidConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 692);
            this.Controls.Add(this.ConfiglistView);
            this.Controls.Add(this.lblPeriodicUpdate);
            this.Controls.Add(this.btnModifiedFiles);
            this.Controls.Add(this.btnPeriodicUpdate);
            this.Controls.Add(this.PeriodicdateTimePicker);
            this.Controls.Add(this.lblMainInfo);
            this.Name = "FormFileAidConfig";
            this.Text = "FileAidConfig";
            this.Load += new System.EventHandler(this.FileAidConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainInfo;
        private System.Windows.Forms.DateTimePicker PeriodicdateTimePicker;
        private System.Windows.Forms.Button btnPeriodicUpdate;
        private System.Windows.Forms.Button btnModifiedFiles;
        private System.Windows.Forms.Label lblPeriodicUpdate;
        private System.Windows.Forms.ListView ConfiglistView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolTip ConfigtoolTip;
    }
}

