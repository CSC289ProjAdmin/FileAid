namespace FileAid.GUI {
    partial class FormFileAidRptLinkedFiles {
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
            this.LinkedFilesItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LinkedFilesContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LinkedFilesItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinkedFilesContextBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportLinkedFiles";
            reportDataSource1.Value = this.LinkedFilesItemBindingSource;
            reportDataSource2.Name = "ReportLinkedFilesContext";
            reportDataSource2.Value = this.LinkedFilesContextBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FileAid.Reports.LinkedFiles.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(984, 912);
            this.reportViewer1.TabIndex = 0;
            // 
            // LinkedFilesItemBindingSource
            // 
            this.LinkedFilesItemBindingSource.DataSource = typeof(FileAid.GUI.LinkedFilesItem);
            // 
            // LinkedFilesContextBindingSource
            // 
            this.LinkedFilesContextBindingSource.DataSource = typeof(FileAid.GUI.LinkedFilesContext);
            // 
            // FormFileAidRptLinkedFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 912);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormFileAidRptLinkedFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FileAid Linked Files";
            this.Load += new System.EventHandler(this.FormFileAidRptLinkedFiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LinkedFilesItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinkedFilesContextBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LinkedFilesItemBindingSource;
        private System.Windows.Forms.BindingSource LinkedFilesContextBindingSource;
    }
}