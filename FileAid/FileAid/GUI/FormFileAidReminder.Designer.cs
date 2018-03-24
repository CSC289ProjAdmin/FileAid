namespace FileAid.GUI
{
    partial class FormFileAidReminder
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
            this.lblMemo = new System.Windows.Forms.Label();
            this.txtReminderMemo = new System.Windows.Forms.TextBox();
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.btnAddReminder = new System.Windows.Forms.Button();
            this.btnDeleteReminder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPushToOutlook = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.RemindertoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMainInfo.Location = new System.Drawing.Point(111, 27);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(617, 37);
            this.lblMainInfo.TabIndex = 1;
            this.lblMainInfo.Text = "Welcome to File Aid Reminder Window.";
            // 
            // lblReminder
            // 
            this.lblReminder.AutoSize = true;
            this.lblReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReminder.ForeColor = System.Drawing.Color.DarkRed;
            this.lblReminder.Location = new System.Drawing.Point(62, 114);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(143, 22);
            this.lblReminder.TabIndex = 6;
            this.lblReminder.Text = "Reminder Due:";
            // 
            // ReminderdateTimePicker
            // 
            this.ReminderdateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.ReminderdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ReminderdateTimePicker.Location = new System.Drawing.Point(234, 110);
            this.ReminderdateTimePicker.Name = "ReminderdateTimePicker";
            this.ReminderdateTimePicker.ShowUpDown = true;
            this.ReminderdateTimePicker.Size = new System.Drawing.Size(197, 26);
            this.ReminderdateTimePicker.TabIndex = 7;
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMemo.Location = new System.Drawing.Point(137, 188);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(68, 22);
            this.lblMemo.TabIndex = 8;
            this.lblMemo.Text = "Memo:";
            // 
            // txtReminderMemo
            // 
            this.txtReminderMemo.Location = new System.Drawing.Point(234, 188);
            this.txtReminderMemo.Name = "txtReminderMemo";
            this.txtReminderMemo.Size = new System.Drawing.Size(306, 26);
            this.txtReminderMemo.TabIndex = 9;
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSelectFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFiles.ForeColor = System.Drawing.Color.White;
            this.btnSelectFiles.Location = new System.Drawing.Point(462, 98);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(170, 52);
            this.btnSelectFiles.TabIndex = 10;
            this.btnSelectFiles.Text = "Select Files";
            this.btnSelectFiles.UseVisualStyleBackColor = false;
            // 
            // btnAddReminder
            // 
            this.btnAddReminder.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddReminder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReminder.ForeColor = System.Drawing.Color.White;
            this.btnAddReminder.Location = new System.Drawing.Point(45, 308);
            this.btnAddReminder.Name = "btnAddReminder";
            this.btnAddReminder.Size = new System.Drawing.Size(170, 52);
            this.btnAddReminder.TabIndex = 11;
            this.btnAddReminder.Text = "Add Reminder";
            this.btnAddReminder.UseVisualStyleBackColor = false;
            // 
            // btnDeleteReminder
            // 
            this.btnDeleteReminder.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteReminder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteReminder.ForeColor = System.Drawing.Color.White;
            this.btnDeleteReminder.Location = new System.Drawing.Point(234, 308);
            this.btnDeleteReminder.Name = "btnDeleteReminder";
            this.btnDeleteReminder.Size = new System.Drawing.Size(170, 52);
            this.btnDeleteReminder.TabIndex = 12;
            this.btnDeleteReminder.Text = "Delete";
            this.btnDeleteReminder.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(421, 308);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(170, 52);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnPushToOutlook
            // 
            this.btnPushToOutlook.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPushToOutlook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPushToOutlook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPushToOutlook.ForeColor = System.Drawing.Color.White;
            this.btnPushToOutlook.Location = new System.Drawing.Point(618, 308);
            this.btnPushToOutlook.Name = "btnPushToOutlook";
            this.btnPushToOutlook.Size = new System.Drawing.Size(170, 52);
            this.btnPushToOutlook.TabIndex = 14;
            this.btnPushToOutlook.Text = "Push Outlook";
            this.btnPushToOutlook.UseVisualStyleBackColor = false;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(234, 239);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(306, 26);
            this.txtFileName.TabIndex = 16;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblName.Location = new System.Drawing.Point(99, 240);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(106, 22);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "File Name:";
            // 
            // RemindertoolTip
            // 
            this.RemindertoolTip.IsBalloon = true;
            // 
            // FormFileAidReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 508);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnPushToOutlook);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteReminder);
            this.Controls.Add(this.btnAddReminder);
            this.Controls.Add(this.btnSelectFiles);
            this.Controls.Add(this.txtReminderMemo);
            this.Controls.Add(this.lblMemo);
            this.Controls.Add(this.ReminderdateTimePicker);
            this.Controls.Add(this.lblReminder);
            this.Controls.Add(this.lblMainInfo);
            this.Name = "FormFileAidReminder";
            this.Text = "FileAidReminders";
            this.Load += new System.EventHandler(this.FormFileAidReminder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainInfo;
        private System.Windows.Forms.Label lblReminder;
        private System.Windows.Forms.DateTimePicker ReminderdateTimePicker;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.TextBox txtReminderMemo;
        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.Button btnAddReminder;
        private System.Windows.Forms.Button btnDeleteReminder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPushToOutlook;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ToolTip RemindertoolTip;
    }
}

