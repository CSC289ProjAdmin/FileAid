﻿namespace FileAid.GUI
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
            this.lblUserDatabase = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.DBManlistView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDbPrintRepo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserDatabase
            // 
            this.lblUserDatabase.AutoSize = true;
            this.lblUserDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDatabase.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblUserDatabase.Location = new System.Drawing.Point(188, 24);
            this.lblUserDatabase.Name = "lblUserDatabase";
            this.lblUserDatabase.Size = new System.Drawing.Size(557, 37);
            this.lblUserDatabase.TabIndex = 1;
            this.lblUserDatabase.Text = "Welcome to Database Management";
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Location = new System.Drawing.Point(64, 98);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(200, 49);
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = false;
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.Location = new System.Drawing.Point(64, 217);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(200, 49);
            this.btnRestore.TabIndex = 3;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = false;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.ForeColor = System.Drawing.Color.White;
            this.btnSelectFile.Location = new System.Drawing.Point(64, 329);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(200, 49);
            this.btnSelectFile.TabIndex = 4;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(64, 450);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(200, 49);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // DBManlistView
            // 
            this.DBManlistView.AllowColumnReorder = true;
            this.DBManlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.DBManlistView.FullRowSelect = true;
            this.DBManlistView.GridLines = true;
            this.DBManlistView.Location = new System.Drawing.Point(292, 98);
            this.DBManlistView.Name = "DBManlistView";
            this.DBManlistView.Size = new System.Drawing.Size(574, 517);
            this.DBManlistView.TabIndex = 6;
            this.DBManlistView.UseCompatibleStateImageBehavior = false;
            this.DBManlistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last Backup Data";
            this.columnHeader2.Width = 152;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Restore Data";
            this.columnHeader3.Width = 124;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Reset Data";
            this.columnHeader4.Width = 122;
            // 
            // btnDbPrintRepo
            // 
            this.btnDbPrintRepo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDbPrintRepo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDbPrintRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbPrintRepo.ForeColor = System.Drawing.Color.White;
            this.btnDbPrintRepo.Location = new System.Drawing.Point(64, 556);
            this.btnDbPrintRepo.Name = "btnDbPrintRepo";
            this.btnDbPrintRepo.Size = new System.Drawing.Size(200, 49);
            this.btnDbPrintRepo.TabIndex = 7;
            this.btnDbPrintRepo.Text = "Print Report";
            this.btnDbPrintRepo.UseVisualStyleBackColor = false;
            // 
            // FileAidDbMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 1038);
            this.Controls.Add(this.btnDbPrintRepo);
            this.Controls.Add(this.DBManlistView);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.lblUserDatabase);
            this.Name = "FileAidDbMgmt";
            this.Text = "FileAid Database Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserDatabase;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListView DBManlistView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnDbPrintRepo;
    }
}
