namespace FileAid.GUI
{
    partial class FormFileAidLink
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
            this.lblMemo = new System.Windows.Forms.Label();
            this.btnCancelLink = new System.Windows.Forms.Button();
            this.btnAddLink = new System.Windows.Forms.Button();
            this.txtLinkMemo = new System.Windows.Forms.TextBox();
            this.AddLinktoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AddLinklistView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMainInfo.Location = new System.Drawing.Point(210, 6);
            this.lblMainInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(424, 26);
            this.lblMainInfo.TabIndex = 1;
            this.lblMainInfo.Text = "Welcome to File Aid Add Link Window.";
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMemo.Location = new System.Drawing.Point(124, 334);
            this.lblMemo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(160, 15);
            this.lblMemo.TabIndex = 6;
            this.lblMemo.Text = "Group Memo (optional):";
            // 
            // btnCancelLink
            // 
            this.btnCancelLink.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelLink.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLink.ForeColor = System.Drawing.Color.White;
            this.btnCancelLink.Location = new System.Drawing.Point(444, 391);
            this.btnCancelLink.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelLink.Name = "btnCancelLink";
            this.btnCancelLink.Size = new System.Drawing.Size(113, 34);
            this.btnCancelLink.TabIndex = 9;
            this.btnCancelLink.Text = "Cancel";
            this.btnCancelLink.UseVisualStyleBackColor = false;
            this.btnCancelLink.Click += new System.EventHandler(this.btnCancelLink_Click);
            // 
            // btnAddLink
            // 
            this.btnAddLink.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddLink.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLink.ForeColor = System.Drawing.Color.White;
            this.btnAddLink.Location = new System.Drawing.Point(288, 391);
            this.btnAddLink.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddLink.Name = "btnAddLink";
            this.btnAddLink.Size = new System.Drawing.Size(113, 34);
            this.btnAddLink.TabIndex = 11;
            this.btnAddLink.Text = "Add Link";
            this.btnAddLink.UseVisualStyleBackColor = false;
            this.btnAddLink.Click += new System.EventHandler(this.btnAddLink_Click);
            // 
            // txtLinkMemo
            // 
            this.txtLinkMemo.BackColor = System.Drawing.SystemColors.Window;
            this.txtLinkMemo.Location = new System.Drawing.Point(288, 333);
            this.txtLinkMemo.Margin = new System.Windows.Forms.Padding(2);
            this.txtLinkMemo.Name = "txtLinkMemo";
            this.txtLinkMemo.Size = new System.Drawing.Size(269, 20);
            this.txtLinkMemo.TabIndex = 12;
            // 
            // AddLinktoolTip
            // 
            this.AddLinktoolTip.IsBalloon = true;
            // 
            // AddLinklistView
            // 
            this.AddLinklistView.AllowColumnReorder = true;
            this.AddLinklistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader4,
            this.columnHeader6});
            this.AddLinklistView.FullRowSelect = true;
            this.AddLinklistView.GridLines = true;
            this.AddLinklistView.Location = new System.Drawing.Point(23, 60);
            this.AddLinklistView.Margin = new System.Windows.Forms.Padding(2);
            this.AddLinklistView.Name = "AddLinklistView";
            this.AddLinklistView.Size = new System.Drawing.Size(799, 243);
            this.AddLinklistView.TabIndex = 13;
            this.AddLinklistView.UseCompatibleStateImageBehavior = false;
            this.AddLinklistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File Name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Extension";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Path";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date Modified";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Size";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Inactive";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Files to link:";
            // 
            // FormFileAidLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddLinklistView);
            this.Controls.Add(this.txtLinkMemo);
            this.Controls.Add(this.btnAddLink);
            this.Controls.Add(this.btnCancelLink);
            this.Controls.Add(this.lblMemo);
            this.Controls.Add(this.lblMainInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFileAidLink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FileAidLink";
            this.Load += new System.EventHandler(this.FormFileAidLink_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainInfo;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.Button btnCancelLink;
        private System.Windows.Forms.Button btnAddLink;
        private System.Windows.Forms.TextBox txtLinkMemo;
        private System.Windows.Forms.ToolTip AddLinktoolTip;
        private System.Windows.Forms.ListView AddLinklistView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
    }
}

