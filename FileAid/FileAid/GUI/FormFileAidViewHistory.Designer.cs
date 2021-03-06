﻿namespace FileAid.GUI
{
    partial class FormFileAidViewHistory
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
            this.ViewHistorylistView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSelectedFile = new System.Windows.Forms.Label();
            this.lblFilename = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMainInfo.Location = new System.Drawing.Point(326, 9);
            this.lblMainInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(214, 26);
            this.lblMainInfo.TabIndex = 0;
            this.lblMainInfo.Text = "FileAid File History";
            // 
            // ViewHistorylistView
            // 
            this.ViewHistorylistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5});
            this.ViewHistorylistView.FullRowSelect = true;
            this.ViewHistorylistView.GridLines = true;
            this.ViewHistorylistView.Location = new System.Drawing.Point(10, 65);
            this.ViewHistorylistView.Margin = new System.Windows.Forms.Padding(2);
            this.ViewHistorylistView.MultiSelect = false;
            this.ViewHistorylistView.Name = "ViewHistorylistView";
            this.ViewHistorylistView.Size = new System.Drawing.Size(846, 326);
            this.ViewHistorylistView.TabIndex = 3;
            this.ViewHistorylistView.UseCompatibleStateImageBehavior = false;
            this.ViewHistorylistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Event Type";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Initial";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "New";
            this.columnHeader5.Width = 140;
            // 
            // lblSelectedFile
            // 
            this.lblSelectedFile.AutoSize = true;
            this.lblSelectedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedFile.Location = new System.Drawing.Point(12, 47);
            this.lblSelectedFile.Name = "lblSelectedFile";
            this.lblSelectedFile.Size = new System.Drawing.Size(71, 13);
            this.lblSelectedFile.TabIndex = 1;
            this.lblSelectedFile.Text = "Selected File:";
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilename.Location = new System.Drawing.Point(89, 47);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(41, 13);
            this.lblFilename.TabIndex = 2;
            this.lblFilename.Text = "label1";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(435, 413);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 34);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(318, 413);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(113, 34);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "Print Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // FormFileAidViewHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 472);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.lblSelectedFile);
            this.Controls.Add(this.ViewHistorylistView);
            this.Controls.Add(this.lblMainInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFileAidViewHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FileAid File History";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainInfo;
        private System.Windows.Forms.ListView ViewHistorylistView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblSelectedFile;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReport;
    }
}

