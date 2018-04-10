﻿namespace FileAid.GUI
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddReminder = new System.Windows.Forms.Button();
            this.btnReminderCancel = new System.Windows.Forms.Button();
            this.txtReminderName = new System.Windows.Forms.TextBox();
            this.lblReminderName = new System.Windows.Forms.Label();
            this.RemindertoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ReminderlistView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMainInfo.Location = new System.Drawing.Point(74, 18);
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
            this.lblReminder.Location = new System.Drawing.Point(15, 74);
            this.lblReminder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(104, 15);
            this.lblReminder.TabIndex = 6;
            this.lblReminder.Text = "Reminder Due:";
            // 
            // ReminderdateTimePicker
            // 
            this.ReminderdateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.ReminderdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ReminderdateTimePicker.Location = new System.Drawing.Point(128, 74);
            this.ReminderdateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.lblDescription.Location = new System.Drawing.Point(33, 151);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(84, 15);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(128, 150);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(279, 20);
            this.txtDescription.TabIndex = 9;
            // 
            // btnAddReminder
            // 
            this.btnAddReminder.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddReminder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReminder.ForeColor = System.Drawing.Color.White;
            this.btnAddReminder.Location = new System.Drawing.Point(119, 188);
            this.btnAddReminder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddReminder.Name = "btnAddReminder";
            this.btnAddReminder.Size = new System.Drawing.Size(113, 34);
            this.btnAddReminder.TabIndex = 11;
            this.btnAddReminder.Text = "Add Reminder";
            this.btnAddReminder.UseVisualStyleBackColor = false;
            // 
            // btnReminderCancel
            // 
            this.btnReminderCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReminderCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReminderCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReminderCancel.ForeColor = System.Drawing.Color.White;
            this.btnReminderCancel.Location = new System.Drawing.Point(284, 188);
            this.btnReminderCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReminderCancel.Name = "btnReminderCancel";
            this.btnReminderCancel.Size = new System.Drawing.Size(113, 34);
            this.btnReminderCancel.TabIndex = 13;
            this.btnReminderCancel.Text = "Cancel";
            this.btnReminderCancel.UseVisualStyleBackColor = false;
            // 
            // txtReminderName
            // 
            this.txtReminderName.Location = new System.Drawing.Point(128, 112);
            this.txtReminderName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtReminderName.Name = "txtReminderName";
            this.txtReminderName.Size = new System.Drawing.Size(279, 20);
            this.txtReminderName.TabIndex = 16;
            // 
            // lblReminderName
            // 
            this.lblReminderName.AutoSize = true;
            this.lblReminderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReminderName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblReminderName.Location = new System.Drawing.Point(5, 112);
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
            this.ReminderlistView.CheckBoxes = true;
            this.ReminderlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.ReminderlistView.FullRowSelect = true;
            this.ReminderlistView.GridLines = true;
            this.ReminderlistView.Location = new System.Drawing.Point(438, 74);
            this.ReminderlistView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReminderlistView.Name = "ReminderlistView";
            this.ReminderlistView.Size = new System.Drawing.Size(207, 327);
            this.ReminderlistView.TabIndex = 18;
            this.ReminderlistView.UseCompatibleStateImageBehavior = false;
            this.ReminderlistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Reminder Files";
            this.columnHeader2.Width = 280;
            // 
            // FormFileAidReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 421);
            this.Controls.Add(this.ReminderlistView);
            this.Controls.Add(this.lblReminderName);
            this.Controls.Add(this.txtReminderName);
            this.Controls.Add(this.btnReminderCancel);
            this.Controls.Add(this.btnAddReminder);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.ReminderdateTimePicker);
            this.Controls.Add(this.lblReminder);
            this.Controls.Add(this.lblMainInfo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormFileAidReminder";
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
        private System.Windows.Forms.Button btnAddReminder;
        private System.Windows.Forms.Button btnReminderCancel;
        private System.Windows.Forms.TextBox txtReminderName;
        private System.Windows.Forms.Label lblReminderName;
        private System.Windows.Forms.ToolTip RemindertoolTip;
        private System.Windows.Forms.ListView ReminderlistView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

