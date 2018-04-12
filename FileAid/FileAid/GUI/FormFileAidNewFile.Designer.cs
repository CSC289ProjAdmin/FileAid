namespace FileAid.GUI
{
    partial class FormFileAidNewFile
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
            this.btnNewSelectFiles = new System.Windows.Forms.Button();
            this.NewFiletoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddFiles = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.AddFilelistView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoveFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMainInfo.Location = new System.Drawing.Point(204, 13);
            this.lblMainInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(417, 26);
            this.lblMainInfo.TabIndex = 1;
            this.lblMainInfo.Text = "Welcome to File Aid NewFile Window.";
            // 
            // btnNewSelectFiles
            // 
            this.btnNewSelectFiles.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewSelectFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewSelectFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSelectFiles.ForeColor = System.Drawing.Color.White;
            this.btnNewSelectFiles.Location = new System.Drawing.Point(11, 393);
            this.btnNewSelectFiles.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewSelectFiles.Name = "btnNewSelectFiles";
            this.btnNewSelectFiles.Size = new System.Drawing.Size(113, 34);
            this.btnNewSelectFiles.TabIndex = 9;
            this.btnNewSelectFiles.Text = "Select Files";
            this.btnNewSelectFiles.UseVisualStyleBackColor = false;
            this.btnNewSelectFiles.Click += new System.EventHandler(this.btnNewSelectFiles_Click);
            // 
            // NewFiletoolTip
            // 
            this.NewFiletoolTip.IsBalloon = true;
            // 
            // btnAddFiles
            // 
            this.btnAddFiles.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFiles.ForeColor = System.Drawing.Color.White;
            this.btnAddFiles.Location = new System.Drawing.Point(280, 444);
            this.btnAddFiles.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.Size = new System.Drawing.Size(113, 34);
            this.btnAddFiles.TabIndex = 23;
            this.btnAddFiles.Text = "Add Files";
            this.btnAddFiles.UseVisualStyleBackColor = false;
            this.btnAddFiles.Click += new System.EventHandler(this.btnAddFiles_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(432, 444);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 34);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddFilelistView
            // 
            this.AddFilelistView.AllowColumnReorder = true;
            this.AddFilelistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader4});
            this.AddFilelistView.FullRowSelect = true;
            this.AddFilelistView.GridLines = true;
            this.AddFilelistView.Location = new System.Drawing.Point(11, 68);
            this.AddFilelistView.Margin = new System.Windows.Forms.Padding(2);
            this.AddFilelistView.MultiSelect = false;
            this.AddFilelistView.Name = "AddFilelistView";
            this.AddFilelistView.Size = new System.Drawing.Size(799, 321);
            this.AddFilelistView.TabIndex = 25;
            this.AddFilelistView.UseCompatibleStateImageBehavior = false;
            this.AddFilelistView.View = System.Windows.Forms.View.Details;
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
            this.columnHeader3.Width = 230;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Size";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date Modified";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Already Exists";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Files To Add:";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "fakefirst";
            this.columnHeader7.Width = 0;
            // 
            // btnRemoveFile
            // 
            this.btnRemoveFile.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRemoveFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFile.ForeColor = System.Drawing.Color.White;
            this.btnRemoveFile.Location = new System.Drawing.Point(128, 393);
            this.btnRemoveFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.Size = new System.Drawing.Size(113, 34);
            this.btnRemoveFile.TabIndex = 27;
            this.btnRemoveFile.Text = "Remove File";
            this.btnRemoveFile.UseVisualStyleBackColor = false;
            this.btnRemoveFile.Click += new System.EventHandler(this.btnRemoveFile_Click);
            // 
            // FormFileAidNewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 512);
            this.Controls.Add(this.btnRemoveFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddFilelistView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddFiles);
            this.Controls.Add(this.btnNewSelectFiles);
            this.Controls.Add(this.lblMainInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFileAidNewFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FileAidNewFile";
            this.Load += new System.EventHandler(this.FormFileAidNewFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainInfo;
        private System.Windows.Forms.Button btnNewSelectFiles;
        private System.Windows.Forms.ToolTip NewFiletoolTip;
        private System.Windows.Forms.Button btnAddFiles;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView AddFilelistView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnRemoveFile;
    }
}

