namespace FileAid.GUI {
    partial class FormFileAidRptFileHistory {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FileHistoryItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FileHistoryContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FileHistoryItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileHistoryContextBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportFileHistoryItem";
            reportDataSource1.Value = this.FileHistoryItemBindingSource;
            reportDataSource2.Name = "ReportFileHistoryContext";
            reportDataSource2.Value = this.FileHistoryContextBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FileAid.Reports.FileHistory.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(984, 912);
            this.reportViewer1.TabIndex = 0;
            // 
            // FileHistoryItemBindingSource
            // 
            this.FileHistoryItemBindingSource.DataSource = typeof(FileAid.GUI.FileHistoryItem);
            // 
            // FileHistoryContextBindingSource
            // 
            this.FileHistoryContextBindingSource.DataSource = typeof(FileAid.GUI.FileHistoryContext);
            // 
            // FormFileAidRptFileHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 912);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormFileAidRptFileHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FileAid File History";
            this.Load += new System.EventHandler(this.FormFileAidRptFileHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FileHistoryItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileHistoryContextBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FileHistoryItemBindingSource;
        private System.Windows.Forms.BindingSource FileHistoryContextBindingSource;
    }
}