namespace FileAid.GUI
{
    partial class FormFileAidTicklers
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
            this.TicklerslistView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblMainInfo = new System.Windows.Forms.Label();
            this.btnResolved = new System.Windows.Forms.Button();
            this.btnPushToOutlook = new System.Windows.Forms.Button();
            this.TicklerstoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // TicklerslistView
            // 
            this.TicklerslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.TicklerslistView.FullRowSelect = true;
            this.TicklerslistView.GridLines = true;
            this.TicklerslistView.Location = new System.Drawing.Point(81, 96);
            this.TicklerslistView.Name = "TicklerslistView";
            this.TicklerslistView.Size = new System.Drawing.Size(868, 475);
            this.TicklerslistView.TabIndex = 0;
            this.TicklerslistView.UseCompatibleStateImageBehavior = false;
            this.TicklerslistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 105;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "File Count";
            this.columnHeader3.Width = 116;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Pushed";
            this.columnHeader4.Width = 111;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Resolved";
            this.columnHeader5.Width = 124;
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMainInfo.Location = new System.Drawing.Point(179, 19);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(590, 37);
            this.lblMainInfo.TabIndex = 2;
            this.lblMainInfo.Text = "Welcome to FileAid Ticklers  Window.";
            // 
            // btnResolved
            // 
            this.btnResolved.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnResolved.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResolved.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolved.ForeColor = System.Drawing.Color.White;
            this.btnResolved.Location = new System.Drawing.Point(517, 613);
            this.btnResolved.Name = "btnResolved";
            this.btnResolved.Size = new System.Drawing.Size(170, 52);
            this.btnResolved.TabIndex = 11;
            this.btnResolved.Text = "Mark as Resolved";
            this.btnResolved.UseVisualStyleBackColor = false;
            // 
            // btnPushToOutlook
            // 
            this.btnPushToOutlook.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPushToOutlook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPushToOutlook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPushToOutlook.ForeColor = System.Drawing.Color.White;
            this.btnPushToOutlook.Location = new System.Drawing.Point(274, 613);
            this.btnPushToOutlook.Name = "btnPushToOutlook";
            this.btnPushToOutlook.Size = new System.Drawing.Size(170, 52);
            this.btnPushToOutlook.TabIndex = 12;
            this.btnPushToOutlook.Text = "Push to Outlook";
            this.btnPushToOutlook.UseVisualStyleBackColor = false;
            // 
            // TicklerstoolTip
            // 
            this.TicklerstoolTip.IsBalloon = true;
            // 
            // FormFileAidTicklers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 804);
            this.Controls.Add(this.btnPushToOutlook);
            this.Controls.Add(this.btnResolved);
            this.Controls.Add(this.lblMainInfo);
            this.Controls.Add(this.TicklerslistView);
            this.Name = "FormFileAidTicklers";
            this.Text = "FileAidTicklers";
            this.Load += new System.EventHandler(this.FormFileAidTicklers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView TicklerslistView;
        private System.Windows.Forms.Label lblMainInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnResolved;
        private System.Windows.Forms.Button btnPushToOutlook;
        private System.Windows.Forms.ToolTip TicklerstoolTip;
    }
}

