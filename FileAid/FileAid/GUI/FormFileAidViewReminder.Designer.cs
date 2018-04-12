namespace FileAid.GUI
{
    partial class FormFileAidViewReminder
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
            this.lblReminder = new System.Windows.Forms.Label();
            this.ReminderdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnRemoveFile = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtReminderName = new System.Windows.Forms.TextBox();
            this.lblReminderName = new System.Windows.Forms.Label();
            this.RemindertoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ReminderlistView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMainInfo.Location = new System.Drawing.Point(195, 18);
            this.lblMainInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(434, 26);
            this.lblMainInfo.TabIndex = 1;
            this.lblMainInfo.Text = "Welcome to File Aid Reminder Window.";
            // 
            // lblReminder
            // 
            this.lblReminder.AutoSize = true;
            this.lblReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReminder.ForeColor = System.Drawing.Color.DarkRed;
            this.lblReminder.Location = new System.Drawing.Point(198, 336);
            this.lblReminder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(71, 15);
            this.lblReminder.TabIndex = 6;
            this.lblReminder.Text = "Due Date:";
            // 
            // ReminderdateTimePicker
            // 
            this.ReminderdateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.ReminderdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ReminderdateTimePicker.Location = new System.Drawing.Point(273, 332);
            this.ReminderdateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.ReminderdateTimePicker.Name = "ReminderdateTimePicker";
            this.ReminderdateTimePicker.ShowUpDown = true;
            this.ReminderdateTimePicker.Size = new System.Drawing.Size(133, 20);
            this.ReminderdateTimePicker.TabIndex = 7;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDescription.Location = new System.Drawing.Point(119, 410);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(150, 15);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description (optional):";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(273, 409);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(279, 20);
            this.txtDescription.TabIndex = 9;
            // 
            // btnRemoveFile
            // 
            this.btnRemoveFile.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRemoveFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFile.ForeColor = System.Drawing.Color.White;
            this.btnRemoveFile.Location = new System.Drawing.Point(273, 449);
            this.btnRemoveFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.Size = new System.Drawing.Size(113, 34);
            this.btnRemoveFile.TabIndex = 11;
            this.btnRemoveFile.Text = "Remove File";
            this.btnRemoveFile.UseVisualStyleBackColor = false;
            this.btnRemoveFile.Click += new System.EventHandler(this.btnRemoveFile_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(439, 449);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 34);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtReminderName
            // 
            this.txtReminderName.Location = new System.Drawing.Point(273, 369);
            this.txtReminderName.Margin = new System.Windows.Forms.Padding(2);
            this.txtReminderName.Name = "txtReminderName";
            this.txtReminderName.Size = new System.Drawing.Size(279, 20);
            this.txtReminderName.TabIndex = 16;
            // 
            // lblReminderName
            // 
            this.lblReminderName.AutoSize = true;
            this.lblReminderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReminderName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblReminderName.Location = new System.Drawing.Point(153, 372);
            this.lblReminderName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReminderName.Name = "lblReminderName";
            this.lblReminderName.Size = new System.Drawing.Size(116, 15);
            this.lblReminderName.TabIndex = 17;
            this.lblReminderName.Text = "Reminder Name:";
            // 
            // RemindertoolTip
            // 
            this.RemindertoolTip.IsBalloon = true;
            // 
            // ReminderlistView
            // 
            this.ReminderlistView.AllowColumnReorder = true;
            this.ReminderlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.ReminderlistView.FullRowSelect = true;
            this.ReminderlistView.GridLines = true;
            this.ReminderlistView.Location = new System.Drawing.Point(11, 66);
            this.ReminderlistView.Margin = new System.Windows.Forms.Padding(2);
            this.ReminderlistView.MultiSelect = false;
            this.ReminderlistView.Name = "ReminderlistView";
            this.ReminderlistView.Size = new System.Drawing.Size(799, 243);
            this.ReminderlistView.TabIndex = 19;
            this.ReminderlistView.UseCompatibleStateImageBehavior = false;
            this.ReminderlistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File Name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Extension";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Path";
            this.columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Size";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date Modified";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 130;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Inactive";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Files attached to reminder:";
            // 
            // FormFileAidViewReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 528);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReminderlistView);
            this.Controls.Add(this.lblReminderName);
            this.Controls.Add(this.txtReminderName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRemoveFile);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.ReminderdateTimePicker);
            this.Controls.Add(this.lblReminder);
            this.Controls.Add(this.lblMainInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFileAidViewReminder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FileAidReminders";
            this.Load += new System.EventHandler(this.FormFileAidReminder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainInfo;
        private System.Windows.Forms.Label lblReminder;
        private System.Windows.Forms.DateTimePicker ReminderdateTimePicker;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnRemoveFile;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtReminderName;
        private System.Windows.Forms.Label lblReminderName;
        private System.Windows.Forms.ToolTip RemindertoolTip;
        private System.Windows.Forms.ListView ReminderlistView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label1;
    }
}

