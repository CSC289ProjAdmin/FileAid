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
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMainInfo.Location = new System.Drawing.Point(271, 9);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(606, 37);
            this.lblMainInfo.TabIndex = 1;
            this.lblMainInfo.Text = "Welcome to File Aid Add Link Window.";
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMemo.Location = new System.Drawing.Point(31, 105);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(68, 22);
            this.lblMemo.TabIndex = 6;
            this.lblMemo.Text = "Memo:";
            // 
            // btnCancelLink
            // 
            this.btnCancelLink.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelLink.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLink.ForeColor = System.Drawing.Color.White;
            this.btnCancelLink.Location = new System.Drawing.Point(858, 90);
            this.btnCancelLink.Name = "btnCancelLink";
            this.btnCancelLink.Size = new System.Drawing.Size(170, 52);
            this.btnCancelLink.TabIndex = 9;
            this.btnCancelLink.Text = "Cancel";
            this.btnCancelLink.UseVisualStyleBackColor = false;
            // 
            // btnAddLink
            // 
            this.btnAddLink.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddLink.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLink.ForeColor = System.Drawing.Color.White;
            this.btnAddLink.Location = new System.Drawing.Point(596, 91);
            this.btnAddLink.Name = "btnAddLink";
            this.btnAddLink.Size = new System.Drawing.Size(170, 52);
            this.btnAddLink.TabIndex = 11;
            this.btnAddLink.Text = "Add Link";
            this.btnAddLink.UseVisualStyleBackColor = false;
            // 
            // txtLinkMemo
            // 
            this.txtLinkMemo.BackColor = System.Drawing.SystemColors.Window;
            this.txtLinkMemo.Location = new System.Drawing.Point(116, 105);
            this.txtLinkMemo.Name = "txtLinkMemo";
            this.txtLinkMemo.Size = new System.Drawing.Size(426, 26);
            this.txtLinkMemo.TabIndex = 12;
            // 
            // AddLinktoolTip
            // 
            this.AddLinktoolTip.IsBalloon = true;
            // 
            // AddLinklistView
            // 
            this.AddLinklistView.AllowColumnReorder = true;
            this.AddLinklistView.CheckBoxes = true;
            this.AddLinklistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.AddLinklistView.FullRowSelect = true;
            this.AddLinklistView.GridLines = true;
            this.AddLinklistView.Location = new System.Drawing.Point(35, 186);
            this.AddLinklistView.Name = "AddLinklistView";
            this.AddLinklistView.Size = new System.Drawing.Size(1243, 372);
            this.AddLinklistView.TabIndex = 13;
            this.AddLinklistView.UseCompatibleStateImageBehavior = false;
            this.AddLinklistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File Name";
            this.columnHeader1.Width = 113;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "File Path";
            this.columnHeader2.Width = 124;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "File Size";
            this.columnHeader3.Width = 101;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date Modified";
            this.columnHeader4.Width = 128;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Update History";
            this.columnHeader5.Width = 139;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "File Extension";
            this.columnHeader6.Width = 123;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tracked Files";
            this.columnHeader7.Width = 113;
            // 
            // FormFileAidLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 618);
            this.Controls.Add(this.AddLinklistView);
            this.Controls.Add(this.txtLinkMemo);
            this.Controls.Add(this.btnAddLink);
            this.Controls.Add(this.btnCancelLink);
            this.Controls.Add(this.lblMemo);
            this.Controls.Add(this.lblMainInfo);
            this.Name = "FormFileAidLink";
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
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}

