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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.lblMemo = new System.Windows.Forms.Label();
            this.btnViewFiles = new System.Windows.Forms.Button();
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
            this.FileLinkslistView.Margin = new System.Windows.Forms.Padding(2);
            this.FileLinkslistView.MultiSelect = false;
            this.FileLinkslistView.Name = "FileLinkslistView";
            this.FileLinkslistView.Size = new System.Drawing.Size(552, 292);
            this.FileLinkslistView.TabIndex = 5;
            this.FileLinkslistView.UseCompatibleStateImageBehavior = false;
            this.FileLinkslistView.View = System.Windows.Forms.View.Details;
            this.FileLinkslistView.SelectedIndexChanged += new System.EventHandler(this.FileLinkslistView_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 485;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "File Count";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMainInfo.Location = new System.Drawing.Point(228, 15);
            this.lblMainInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(195, 26);
            this.lblMainInfo.TabIndex = 0;
            this.lblMainInfo.Text = "FileAid File Links";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(461, 403);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 34);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(159, 412);
            this.txtMemo.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(291, 20);
            this.txtMemo.TabIndex = 3;
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMemo.Location = new System.Drawing.Point(76, 413);
            this.lblMemo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(82, 15);
            this.lblMemo.TabIndex = 2;
            this.lblMemo.Text = "Link Memo:";
            // 
            // btnViewFiles
            // 
            this.btnViewFiles.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnViewFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFiles.ForeColor = System.Drawing.Color.White;
            this.btnViewFiles.Location = new System.Drawing.Point(269, 353);
            this.btnViewFiles.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewFiles.Name = "btnViewFiles";
            this.btnViewFiles.Size = new System.Drawing.Size(113, 34);
            this.btnViewFiles.TabIndex = 1;
            this.btnViewFiles.Text = "View Files";
            this.btnViewFiles.UseVisualStyleBackColor = false;
            this.btnViewFiles.Click += new System.EventHandler(this.btnViewFiles_Click);
            // 
            // FormFileAidFileLinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 481);
            this.Controls.Add(this.btnViewFiles);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.lblMemo);
            this.Controls.Add(this.lblMainInfo);
            this.Controls.Add(this.FileLinkslistView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFileAidFileLinks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.Button btnViewFiles;
    }
}

