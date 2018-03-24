namespace FileAid.GUI
{
    partial class FormFileAidFileLinks
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
            this.FileLinkslistView = new System.Windows.Forms.ListView();
            this.lblMainInfo = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // FileLinkslistView
            // 
            this.FileLinkslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.FileLinkslistView.FullRowSelect = true;
            this.FileLinkslistView.GridLines = true;
            this.FileLinkslistView.Location = new System.Drawing.Point(83, 87);
            this.FileLinkslistView.Name = "FileLinkslistView";
            this.FileLinkslistView.Size = new System.Drawing.Size(826, 447);
            this.FileLinkslistView.TabIndex = 0;
            this.FileLinkslistView.UseCompatibleStateImageBehavior = false;
            this.FileLinkslistView.View = System.Windows.Forms.View.Details;
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMainInfo.Location = new System.Drawing.Point(155, 23);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(607, 37);
            this.lblMainInfo.TabIndex = 2;
            this.lblMainInfo.Text = "Welcome to FileAid File Links Window.";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 194;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 229;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "File Count";
            this.columnHeader3.Width = 273;
            // 
            // FormFileAidFileLinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 607);
            this.Controls.Add(this.lblMainInfo);
            this.Controls.Add(this.FileLinkslistView);
            this.Name = "FormFileAidFileLinks";
            this.Text = "FileAid File Links";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView FileLinkslistView;
        private System.Windows.Forms.Label lblMainInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

