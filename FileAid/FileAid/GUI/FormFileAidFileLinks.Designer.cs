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
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblMainInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FileLinkslistView
            // 
            this.FileLinkslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.FileLinkslistView.FullRowSelect = true;
            this.FileLinkslistView.GridLines = true;
            this.FileLinkslistView.Location = new System.Drawing.Point(55, 57);
            this.FileLinkslistView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FileLinkslistView.Name = "FileLinkslistView";
            this.FileLinkslistView.Size = new System.Drawing.Size(552, 292);
            this.FileLinkslistView.TabIndex = 0;
            this.FileLinkslistView.UseCompatibleStateImageBehavior = false;
            this.FileLinkslistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 485;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "File Count";
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMainInfo.Location = new System.Drawing.Point(103, 15);
            this.lblMainInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(426, 26);
            this.lblMainInfo.TabIndex = 2;
            this.lblMainInfo.Text = "Welcome to FileAid File Links Window.";
            // 
            // FormFileAidFileLinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 395);
            this.Controls.Add(this.lblMainInfo);
            this.Controls.Add(this.FileLinkslistView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormFileAidFileLinks";
            this.Text = "FileAid File Links";
            this.Load += new System.EventHandler(this.FormFileAidFileLinks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView FileLinkslistView;
        private System.Windows.Forms.Label lblMainInfo;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

