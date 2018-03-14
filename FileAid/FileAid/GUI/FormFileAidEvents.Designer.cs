namespace FileAid.GUI
{
    partial class FormFileAidEvents
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
            this.EventslistView = new System.Windows.Forms.ListView();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEventsReport = new System.Windows.Forms.Button();
            this.btnEventsFilters = new System.Windows.Forms.Button();
            this.lblEventsFilters = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMainInfo.Location = new System.Drawing.Point(293, 19);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(574, 37);
            this.lblMainInfo.TabIndex = 1;
            this.lblMainInfo.Text = "Welcome to File Aid Events Window.";
            // 
            // EventslistView
            // 
            this.EventslistView.AllowColumnReorder = true;
            this.EventslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.EventslistView.FullRowSelect = true;
            this.EventslistView.GridLines = true;
            this.EventslistView.Location = new System.Drawing.Point(13, 72);
            this.EventslistView.Name = "EventslistView";
            this.EventslistView.Size = new System.Drawing.Size(1361, 484);
            this.EventslistView.TabIndex = 2;
            this.EventslistView.UseCompatibleStateImageBehavior = false;
            this.EventslistView.View = System.Windows.Forms.View.Details;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(13, 596);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(170, 52);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnEventsReport
            // 
            this.btnEventsReport.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEventsReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEventsReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventsReport.ForeColor = System.Drawing.Color.White;
            this.btnEventsReport.Location = new System.Drawing.Point(228, 596);
            this.btnEventsReport.Name = "btnEventsReport";
            this.btnEventsReport.Size = new System.Drawing.Size(170, 52);
            this.btnEventsReport.TabIndex = 10;
            this.btnEventsReport.Text = "Print Report";
            this.btnEventsReport.UseVisualStyleBackColor = false;
            // 
            // btnEventsFilters
            // 
            this.btnEventsFilters.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEventsFilters.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEventsFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventsFilters.ForeColor = System.Drawing.Color.White;
            this.btnEventsFilters.Location = new System.Drawing.Point(813, 596);
            this.btnEventsFilters.Name = "btnEventsFilters";
            this.btnEventsFilters.Size = new System.Drawing.Size(170, 52);
            this.btnEventsFilters.TabIndex = 11;
            this.btnEventsFilters.Text = "Filters";
            this.btnEventsFilters.UseVisualStyleBackColor = false;
            // 
            // lblEventsFilters
            // 
            this.lblEventsFilters.AutoSize = true;
            this.lblEventsFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventsFilters.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEventsFilters.Location = new System.Drawing.Point(432, 611);
            this.lblEventsFilters.Name = "lblEventsFilters";
            this.lblEventsFilters.Size = new System.Drawing.Size(72, 22);
            this.lblEventsFilters.TabIndex = 12;
            this.lblEventsFilters.Text = "Filters:";
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(508, 610);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(284, 26);
            this.txtMemo.TabIndex = 18;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Manual Changes";
            this.columnHeader1.Width = 143;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Updates";
            this.columnHeader2.Width = 94;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Report Creation";
            this.columnHeader3.Width = 132;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Batch Updates";
            this.columnHeader4.Width = 133;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Errors Occur";
            this.columnHeader5.Width = 118;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Failure Count";
            this.columnHeader6.Width = 125;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "DB Backup/Reset";
            this.columnHeader7.Width = 161;
            // 
            // FileAidEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 742);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.lblEventsFilters);
            this.Controls.Add(this.btnEventsFilters);
            this.Controls.Add(this.btnEventsReport);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.EventslistView);
            this.Controls.Add(this.lblMainInfo);
            this.Name = "FileAidEvents";
            this.Text = "FileAidEvents";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainInfo;
        private System.Windows.Forms.ListView EventslistView;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEventsReport;
        private System.Windows.Forms.Button btnEventsFilters;
        private System.Windows.Forms.Label lblEventsFilters;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}

