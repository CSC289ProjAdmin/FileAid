namespace FileAid.GUI
{
    partial class FormFileAidReports
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
            this.ReportslistView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRunReport = new System.Windows.Forms.Button();
            this.ReporttoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMainInfo.Location = new System.Drawing.Point(156, 28);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(573, 37);
            this.lblMainInfo.TabIndex = 3;
            this.lblMainInfo.Text = "Welcome to FileAid Report  Window.";
            // 
            // ReportslistView
            // 
            this.ReportslistView.AllowColumnReorder = true;
            this.ReportslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ReportslistView.FullRowSelect = true;
            this.ReportslistView.GridLines = true;
            this.ReportslistView.Location = new System.Drawing.Point(59, 99);
            this.ReportslistView.Name = "ReportslistView";
            this.ReportslistView.Size = new System.Drawing.Size(777, 480);
            this.ReportslistView.TabIndex = 4;
            this.ReportslistView.UseCompatibleStateImageBehavior = false;
            this.ReportslistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 260;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 338;
            // 
            // btnRunReport
            // 
            this.btnRunReport.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRunReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRunReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunReport.ForeColor = System.Drawing.Color.White;
            this.btnRunReport.Location = new System.Drawing.Point(366, 602);
            this.btnRunReport.Name = "btnRunReport";
            this.btnRunReport.Size = new System.Drawing.Size(170, 52);
            this.btnRunReport.TabIndex = 11;
            this.btnRunReport.Text = "Run Report";
            this.btnRunReport.UseVisualStyleBackColor = false;
            // 
            // ReporttoolTip
            // 
            this.ReporttoolTip.IsBalloon = true;
            // 
            // FormFileAidReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 809);
            this.Controls.Add(this.btnRunReport);
            this.Controls.Add(this.ReportslistView);
            this.Controls.Add(this.lblMainInfo);
            this.Name = "FormFileAidReports";
            this.Text = "FileAid Reports";
            this.Load += new System.EventHandler(this.FormFileAidReports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainInfo;
        private System.Windows.Forms.ListView ReportslistView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnRunReport;
        private System.Windows.Forms.ToolTip ReporttoolTip;
    }
}

