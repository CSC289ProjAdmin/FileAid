namespace FileAid.GUI {
    partial class FormFileAidRptViewer {
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
            this.trackedFilesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trackedFilesDataSet = new FileAid.Reports.TrackedFilesDataSet();
            this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackedFilesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackedFilesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportFileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // trackedFilesDataSetBindingSource
            // 
            this.trackedFilesDataSetBindingSource.DataSource = this.trackedFilesDataSet;
            this.trackedFilesDataSetBindingSource.Position = 0;
            // 
            // trackedFilesDataSet
            // 
            this.trackedFilesDataSet.DataSetName = "TrackedFilesDataSet";
            this.trackedFilesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptViewer
            // 
            this.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RptSourceTrackedFiles";
            reportDataSource1.Value = this.ReportFileBindingSource;
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.rptViewer.LocalReport.ReportEmbeddedResource = "FileAid.Reports.RptFiles.rdlc";
            this.rptViewer.Location = new System.Drawing.Point(0, 0);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.Size = new System.Drawing.Size(984, 912);
            this.rptViewer.TabIndex = 0;
            // 
            // ReportFileBindingSource
            // 
            this.ReportFileBindingSource.DataSource = typeof(FileAid.GUI.ReportFile);
            // 
            // FormFileAidRptViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 912);
            this.Controls.Add(this.rptViewer);
            this.Name = "FormFileAidRptViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FileAid Tracked Files";
            this.Load += new System.EventHandler(this.FormFileAidRptViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackedFilesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackedFilesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportFileBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer rptViewer;
        private System.Windows.Forms.BindingSource trackedFilesDataSetBindingSource;
        private Reports.TrackedFilesDataSet trackedFilesDataSet;
        private System.Windows.Forms.BindingSource ReportFileBindingSource;
    }
}