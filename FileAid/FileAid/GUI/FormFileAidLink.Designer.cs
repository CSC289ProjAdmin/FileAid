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
            this.SuspendLayout();
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMainInfo.Location = new System.Drawing.Point(106, 9);
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
            this.lblMemo.Location = new System.Drawing.Point(94, 90);
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
            this.btnCancelLink.Location = new System.Drawing.Point(652, 167);
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
            this.btnAddLink.Location = new System.Drawing.Point(652, 75);
            this.btnAddLink.Name = "btnAddLink";
            this.btnAddLink.Size = new System.Drawing.Size(170, 52);
            this.btnAddLink.TabIndex = 11;
            this.btnAddLink.Text = "Add Link";
            this.btnAddLink.UseVisualStyleBackColor = false;
            // 
            // txtLinkMemo
            // 
            this.txtLinkMemo.BackColor = System.Drawing.SystemColors.Window;
            this.txtLinkMemo.Location = new System.Drawing.Point(180, 90);
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
            this.columnHeader2});
            this.AddLinklistView.FullRowSelect = true;
            this.AddLinklistView.GridLines = true;
            this.AddLinklistView.Location = new System.Drawing.Point(168, 188);
            this.AddLinklistView.Name = "AddLinklistView";
            this.AddLinklistView.Size = new System.Drawing.Size(455, 182);
            this.AddLinklistView.TabIndex = 13;
            this.AddLinklistView.UseCompatibleStateImageBehavior = false;
            this.AddLinklistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 155;
            // 
            // FormFileAidLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 438);
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
    }
}

