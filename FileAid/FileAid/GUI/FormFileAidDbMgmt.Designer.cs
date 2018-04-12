namespace FileAid.GUI
{
    partial class FormFileAidDbMgmt
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
            this.lblUserDatabase = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.DBManlistView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDbPrintRepo = new System.Windows.Forms.Button();
            this.DBMantoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblUserDatabase
            // 
            this.lblUserDatabase.AutoSize = true;
            this.lblUserDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDatabase.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblUserDatabase.Location = new System.Drawing.Point(125, 16);
            this.lblUserDatabase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserDatabase.Name = "lblUserDatabase";
            this.lblUserDatabase.Size = new System.Drawing.Size(390, 26);
            this.lblUserDatabase.TabIndex = 1;
            this.lblUserDatabase.Text = "Welcome to Database Management";
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Location = new System.Drawing.Point(11, 64);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(133, 32);
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.Location = new System.Drawing.Point(11, 153);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(133, 32);
            this.btnRestore.TabIndex = 3;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(11, 242);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(133, 32);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // DBManlistView
            // 
            this.DBManlistView.AllowColumnReorder = true;
            this.DBManlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader3});
            this.DBManlistView.FullRowSelect = true;
            this.DBManlistView.GridLines = true;
            this.DBManlistView.Location = new System.Drawing.Point(148, 64);
            this.DBManlistView.Margin = new System.Windows.Forms.Padding(2);
            this.DBManlistView.Name = "DBManlistView";
            this.DBManlistView.Size = new System.Drawing.Size(465, 337);
            this.DBManlistView.TabIndex = 6;
            this.DBManlistView.UseCompatibleStateImageBehavior = false;
            this.DBManlistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 310;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date";
            this.columnHeader4.Width = 120;
            // 
            // btnDbPrintRepo
            // 
            this.btnDbPrintRepo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDbPrintRepo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDbPrintRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbPrintRepo.ForeColor = System.Drawing.Color.White;
            this.btnDbPrintRepo.Location = new System.Drawing.Point(11, 331);
            this.btnDbPrintRepo.Margin = new System.Windows.Forms.Padding(2);
            this.btnDbPrintRepo.Name = "btnDbPrintRepo";
            this.btnDbPrintRepo.Size = new System.Drawing.Size(133, 32);
            this.btnDbPrintRepo.TabIndex = 7;
            this.btnDbPrintRepo.Text = "Print Report";
            this.btnDbPrintRepo.UseVisualStyleBackColor = false;
            this.btnDbPrintRepo.Click += new System.EventHandler(this.btnDbPrintRepo_Click);
            // 
            // DBMantoolTip
            // 
            this.DBMantoolTip.IsBalloon = true;
            // 
            // FormFileAidDbMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 473);
            this.Controls.Add(this.btnDbPrintRepo);
            this.Controls.Add(this.DBManlistView);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.lblUserDatabase);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFileAidDbMgmt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FileAid Database Management";
            this.Load += new System.EventHandler(this.FormFileAidDbMgmt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserDatabase;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListView DBManlistView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnDbPrintRepo;
        private System.Windows.Forms.ToolTip DBMantoolTip;
    }
}

