namespace FileAid.GUI
{
    partial class FormFileAidTicklers
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
            this.TicklerslistView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblMainInfo = new System.Windows.Forms.Label();
            this.btnResolved = new System.Windows.Forms.Button();
            this.btnPushToOutlook = new System.Windows.Forms.Button();
            this.TicklerstoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnViewFiles = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TicklerslistView
            // 
            this.TicklerslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader5,
            this.columnHeader4});
            this.TicklerslistView.FullRowSelect = true;
            this.TicklerslistView.GridLines = true;
            this.TicklerslistView.Location = new System.Drawing.Point(54, 62);
            this.TicklerslistView.Margin = new System.Windows.Forms.Padding(2);
            this.TicklerslistView.Name = "TicklerslistView";
            this.TicklerslistView.Size = new System.Drawing.Size(580, 310);
            this.TicklerslistView.TabIndex = 1;
            this.TicklerslistView.UseCompatibleStateImageBehavior = false;
            this.TicklerslistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 105;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "File Count";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Due On";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Resolved";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Pushed";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMainInfo.Location = new System.Drawing.Point(183, 12);
            this.lblMainInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(311, 26);
            this.lblMainInfo.TabIndex = 0;
            this.lblMainInfo.Text = "FileAid Reminders / Ticklers";
            // 
            // btnResolved
            // 
            this.btnResolved.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnResolved.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResolved.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolved.ForeColor = System.Drawing.Color.White;
            this.btnResolved.Location = new System.Drawing.Point(209, 413);
            this.btnResolved.Margin = new System.Windows.Forms.Padding(2);
            this.btnResolved.Name = "btnResolved";
            this.btnResolved.Size = new System.Drawing.Size(113, 34);
            this.btnResolved.TabIndex = 3;
            this.btnResolved.Text = "Mark as Resolved";
            this.btnResolved.UseVisualStyleBackColor = false;
            this.btnResolved.Click += new System.EventHandler(this.btnResolved_Click);
            // 
            // btnPushToOutlook
            // 
            this.btnPushToOutlook.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPushToOutlook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPushToOutlook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPushToOutlook.ForeColor = System.Drawing.Color.White;
            this.btnPushToOutlook.Location = new System.Drawing.Point(364, 413);
            this.btnPushToOutlook.Margin = new System.Windows.Forms.Padding(2);
            this.btnPushToOutlook.Name = "btnPushToOutlook";
            this.btnPushToOutlook.Size = new System.Drawing.Size(113, 34);
            this.btnPushToOutlook.TabIndex = 4;
            this.btnPushToOutlook.Text = "Push to Outlook";
            this.btnPushToOutlook.UseVisualStyleBackColor = false;
            this.btnPushToOutlook.Click += new System.EventHandler(this.btnPushToOutlook_Click);
            // 
            // TicklerstoolTip
            // 
            this.TicklerstoolTip.IsBalloon = true;
            // 
            // btnViewFiles
            // 
            this.btnViewFiles.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnViewFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFiles.ForeColor = System.Drawing.Color.White;
            this.btnViewFiles.Location = new System.Drawing.Point(54, 413);
            this.btnViewFiles.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewFiles.Name = "btnViewFiles";
            this.btnViewFiles.Size = new System.Drawing.Size(113, 34);
            this.btnViewFiles.TabIndex = 2;
            this.btnViewFiles.Text = "View Files";
            this.btnViewFiles.UseVisualStyleBackColor = false;
            this.btnViewFiles.Click += new System.EventHandler(this.btnViewFiles_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(519, 413);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(113, 34);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "Print Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // FormFileAidTicklers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 523);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnViewFiles);
            this.Controls.Add(this.btnPushToOutlook);
            this.Controls.Add(this.btnResolved);
            this.Controls.Add(this.lblMainInfo);
            this.Controls.Add(this.TicklerslistView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFileAidTicklers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FileAid Reminders";
            this.Load += new System.EventHandler(this.FormFileAidTicklers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView TicklerslistView;
        private System.Windows.Forms.Label lblMainInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnResolved;
        private System.Windows.Forms.Button btnPushToOutlook;
        private System.Windows.Forms.ToolTip TicklerstoolTip;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnViewFiles;
        private System.Windows.Forms.Button btnReport;
    }
}

