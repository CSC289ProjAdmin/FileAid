namespace FileAid.GUI
{
    partial class FormFileAidDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFileAidDash));
            this.lblDashMessage = new System.Windows.Forms.Label();
            this.btnTrackedFiles = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnUserMan = new System.Windows.Forms.Button();
            this.btnDBMan = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLinks = new System.Windows.Forms.Button();
            this.btnLogEvents = new System.Windows.Forms.Button();
            this.btnViewTick = new System.Windows.Forms.Button();
            this.btnUpdateMode = new System.Windows.Forms.Button();
            this.btnGuestPerms = new System.Windows.Forms.Button();
            this.btnBatchScan = new System.Windows.Forms.Button();
            this.btnDataView = new System.Windows.Forms.Button();
            this.iconFileAidTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDashMessage
            // 
            this.lblDashMessage.AutoSize = true;
            this.lblDashMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashMessage.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblDashMessage.Location = new System.Drawing.Point(23, 13);
            this.lblDashMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDashMessage.Name = "lblDashMessage";
            this.lblDashMessage.Size = new System.Drawing.Size(333, 20);
            this.lblDashMessage.TabIndex = 0;
            this.lblDashMessage.Text = "Welcome to File Aid Dashboard Window.";
            // 
            // btnTrackedFiles
            // 
            this.btnTrackedFiles.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTrackedFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrackedFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrackedFiles.ForeColor = System.Drawing.Color.White;
            this.btnTrackedFiles.Location = new System.Drawing.Point(34, 44);
            this.btnTrackedFiles.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrackedFiles.Name = "btnTrackedFiles";
            this.btnTrackedFiles.Size = new System.Drawing.Size(133, 32);
            this.btnTrackedFiles.TabIndex = 1;
            this.btnTrackedFiles.Text = "Tracked Files";
            this.btnTrackedFiles.UseVisualStyleBackColor = false;
            this.btnTrackedFiles.Click += new System.EventHandler(this.btnTrackedFiles_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(34, 95);
            this.btnReports.Margin = new System.Windows.Forms.Padding(2);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(133, 32);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnUserMan
            // 
            this.btnUserMan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUserMan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUserMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserMan.ForeColor = System.Drawing.Color.White;
            this.btnUserMan.Location = new System.Drawing.Point(34, 153);
            this.btnUserMan.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserMan.Name = "btnUserMan";
            this.btnUserMan.Size = new System.Drawing.Size(133, 32);
            this.btnUserMan.TabIndex = 3;
            this.btnUserMan.Text = "User Management";
            this.btnUserMan.UseVisualStyleBackColor = false;
            this.btnUserMan.Click += new System.EventHandler(this.btnUserMan_Click);
            // 
            // btnDBMan
            // 
            this.btnDBMan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDBMan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDBMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBMan.ForeColor = System.Drawing.Color.White;
            this.btnDBMan.Location = new System.Drawing.Point(34, 211);
            this.btnDBMan.Margin = new System.Windows.Forms.Padding(2);
            this.btnDBMan.Name = "btnDBMan";
            this.btnDBMan.Size = new System.Drawing.Size(133, 32);
            this.btnDBMan.TabIndex = 4;
            this.btnDBMan.Text = "DB Management";
            this.btnDBMan.UseVisualStyleBackColor = false;
            this.btnDBMan.Click += new System.EventHandler(this.btnDBMan_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(34, 270);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(133, 32);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Program Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLinks
            // 
            this.btnLinks.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLinks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinks.ForeColor = System.Drawing.Color.White;
            this.btnLinks.Location = new System.Drawing.Point(34, 330);
            this.btnLinks.Margin = new System.Windows.Forms.Padding(2);
            this.btnLinks.Name = "btnLinks";
            this.btnLinks.Size = new System.Drawing.Size(133, 32);
            this.btnLinks.TabIndex = 6;
            this.btnLinks.Text = "Links / Groups";
            this.btnLinks.UseVisualStyleBackColor = false;
            this.btnLinks.Click += new System.EventHandler(this.btnLinks_Click);
            // 
            // btnLogEvents
            // 
            this.btnLogEvents.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogEvents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogEvents.ForeColor = System.Drawing.Color.White;
            this.btnLogEvents.Location = new System.Drawing.Point(201, 44);
            this.btnLogEvents.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogEvents.Name = "btnLogEvents";
            this.btnLogEvents.Size = new System.Drawing.Size(133, 32);
            this.btnLogEvents.TabIndex = 7;
            this.btnLogEvents.Text = "Log Events";
            this.btnLogEvents.UseVisualStyleBackColor = false;
            this.btnLogEvents.Click += new System.EventHandler(this.btnLogEvents_Click);
            // 
            // btnViewTick
            // 
            this.btnViewTick.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnViewTick.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTick.ForeColor = System.Drawing.Color.White;
            this.btnViewTick.Location = new System.Drawing.Point(201, 217);
            this.btnViewTick.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewTick.Name = "btnViewTick";
            this.btnViewTick.Size = new System.Drawing.Size(133, 32);
            this.btnViewTick.TabIndex = 8;
            this.btnViewTick.Text = "View Ticklers";
            this.btnViewTick.UseVisualStyleBackColor = false;
            this.btnViewTick.Click += new System.EventHandler(this.btnViewTick_Click);
            // 
            // btnUpdateMode
            // 
            this.btnUpdateMode.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMode.ForeColor = System.Drawing.Color.White;
            this.btnUpdateMode.Location = new System.Drawing.Point(201, 270);
            this.btnUpdateMode.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateMode.Name = "btnUpdateMode";
            this.btnUpdateMode.Size = new System.Drawing.Size(133, 32);
            this.btnUpdateMode.TabIndex = 9;
            this.btnUpdateMode.Text = "Update Mode";
            this.btnUpdateMode.UseVisualStyleBackColor = false;
            this.btnUpdateMode.Click += new System.EventHandler(this.btnUpdateMode_Click);
            // 
            // btnGuestPerms
            // 
            this.btnGuestPerms.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuestPerms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuestPerms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuestPerms.ForeColor = System.Drawing.Color.White;
            this.btnGuestPerms.Location = new System.Drawing.Point(201, 153);
            this.btnGuestPerms.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuestPerms.Name = "btnGuestPerms";
            this.btnGuestPerms.Size = new System.Drawing.Size(133, 32);
            this.btnGuestPerms.TabIndex = 10;
            this.btnGuestPerms.Text = "Permissions";
            this.btnGuestPerms.UseVisualStyleBackColor = false;
            this.btnGuestPerms.Click += new System.EventHandler(this.btnGuestPerms_Click);
            // 
            // btnBatchScan
            // 
            this.btnBatchScan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBatchScan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBatchScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatchScan.ForeColor = System.Drawing.Color.White;
            this.btnBatchScan.Location = new System.Drawing.Point(201, 95);
            this.btnBatchScan.Margin = new System.Windows.Forms.Padding(2);
            this.btnBatchScan.Name = "btnBatchScan";
            this.btnBatchScan.Size = new System.Drawing.Size(133, 32);
            this.btnBatchScan.TabIndex = 11;
            this.btnBatchScan.Text = "Batch Scan";
            this.btnBatchScan.UseVisualStyleBackColor = false;
            // 
            // btnDataView
            // 
            this.btnDataView.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDataView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDataView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataView.ForeColor = System.Drawing.Color.White;
            this.btnDataView.Location = new System.Drawing.Point(201, 330);
            this.btnDataView.Margin = new System.Windows.Forms.Padding(2);
            this.btnDataView.Name = "btnDataView";
            this.btnDataView.Size = new System.Drawing.Size(133, 32);
            this.btnDataView.TabIndex = 12;
            this.btnDataView.Text = "Data View";
            this.btnDataView.UseVisualStyleBackColor = false;
            // 
            // iconFileAidTray
            // 
            this.iconFileAidTray.ContextMenuStrip = this.contextMenuStrip1;
            this.iconFileAidTray.Icon = ((System.Drawing.Icon)(resources.GetObject("iconFileAidTray.Icon")));
            this.iconFileAidTray.Text = "FileAidIcon";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 70);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // FormFileAidDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 437);
            this.Controls.Add(this.btnDataView);
            this.Controls.Add(this.btnBatchScan);
            this.Controls.Add(this.btnGuestPerms);
            this.Controls.Add(this.btnUpdateMode);
            this.Controls.Add(this.btnViewTick);
            this.Controls.Add(this.btnLogEvents);
            this.Controls.Add(this.btnLinks);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnDBMan);
            this.Controls.Add(this.btnUserMan);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnTrackedFiles);
            this.Controls.Add(this.lblDashMessage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFileAidDash";
            this.Text = "File Aid Dashboard";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDashMessage;
        private System.Windows.Forms.Button btnTrackedFiles;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnUserMan;
        private System.Windows.Forms.Button btnDBMan;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLinks;
        private System.Windows.Forms.Button btnLogEvents;
        private System.Windows.Forms.Button btnViewTick;
        private System.Windows.Forms.Button btnUpdateMode;
        private System.Windows.Forms.Button btnGuestPerms;
        private System.Windows.Forms.Button btnBatchScan;
        private System.Windows.Forms.Button btnDataView;
        private System.Windows.Forms.NotifyIcon iconFileAidTray;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

