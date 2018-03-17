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
            this.lblMainInfo = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.btnDeleteLink = new System.Windows.Forms.Button();
            this.btnComment = new System.Windows.Forms.Button();
            this.btnAddLink = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtLinkFileName = new System.Windows.Forms.TextBox();
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
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.ForeColor = System.Drawing.Color.DarkRed;
            this.lblComment.Location = new System.Drawing.Point(87, 138);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(99, 22);
            this.lblComment.TabIndex = 6;
            this.lblComment.Text = "Comment:";
            // 
            // btnDeleteLink
            // 
            this.btnDeleteLink.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteLink.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLink.ForeColor = System.Drawing.Color.White;
            this.btnDeleteLink.Location = new System.Drawing.Point(528, 229);
            this.btnDeleteLink.Name = "btnDeleteLink";
            this.btnDeleteLink.Size = new System.Drawing.Size(170, 52);
            this.btnDeleteLink.TabIndex = 9;
            this.btnDeleteLink.Text = "Delete";
            this.btnDeleteLink.UseVisualStyleBackColor = false;
            // 
            // btnComment
            // 
            this.btnComment.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnComment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComment.ForeColor = System.Drawing.Color.White;
            this.btnComment.Location = new System.Drawing.Point(82, 229);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(170, 52);
            this.btnComment.TabIndex = 10;
            this.btnComment.Text = "Add Comment";
            this.btnComment.UseVisualStyleBackColor = false;
            // 
            // btnAddLink
            // 
            this.btnAddLink.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddLink.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLink.ForeColor = System.Drawing.Color.White;
            this.btnAddLink.Location = new System.Drawing.Point(305, 229);
            this.btnAddLink.Name = "btnAddLink";
            this.btnAddLink.Size = new System.Drawing.Size(170, 52);
            this.btnAddLink.TabIndex = 11;
            this.btnAddLink.Text = "Add Link";
            this.btnAddLink.UseVisualStyleBackColor = false;
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.SystemColors.Window;
            this.txtComment.Location = new System.Drawing.Point(203, 138);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(309, 26);
            this.txtComment.TabIndex = 12;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFileName.Location = new System.Drawing.Point(87, 83);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(100, 22);
            this.lblFileName.TabIndex = 13;
            this.lblFileName.Text = "FileName:";
            // 
            // txtLinkFileName
            // 
            this.txtLinkFileName.BackColor = System.Drawing.SystemColors.Window;
            this.txtLinkFileName.Location = new System.Drawing.Point(203, 83);
            this.txtLinkFileName.Name = "txtLinkFileName";
            this.txtLinkFileName.Size = new System.Drawing.Size(309, 26);
            this.txtLinkFileName.TabIndex = 14;
            // 
            // FormFileAidLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 438);
            this.Controls.Add(this.txtLinkFileName);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.btnAddLink);
            this.Controls.Add(this.btnComment);
            this.Controls.Add(this.btnDeleteLink);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblMainInfo);
            this.Name = "FormFileAidLink";
            this.Text = "FileAidLink";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainInfo;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Button btnDeleteLink;
        private System.Windows.Forms.Button btnComment;
        private System.Windows.Forms.Button btnAddLink;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtLinkFileName;
    }
}

