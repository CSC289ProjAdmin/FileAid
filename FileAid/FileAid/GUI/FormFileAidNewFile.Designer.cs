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
            this.btnNewFilePrintRepo = new System.Windows.Forms.Button();
            this.NewFilelistView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NewFiletoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMainInfo.Location = new System.Drawing.Point(119, 20);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(594, 37);
            this.lblMainInfo.TabIndex = 1;
            this.lblMainInfo.Text = "Welcome to File Aid NewFile Window.";
            // 
            // btnNewSelectFiles
            // 
            this.btnNewSelectFiles.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewSelectFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewSelectFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSelectFiles.ForeColor = System.Drawing.Color.White;
            this.btnNewSelectFiles.Location = new System.Drawing.Point(12, 97);
            this.btnNewSelectFiles.Name = "btnNewSelectFiles";
            this.btnNewSelectFiles.Size = new System.Drawing.Size(170, 52);
            this.btnNewSelectFiles.TabIndex = 9;
            this.btnNewSelectFiles.Text = "Select Files";
            this.btnNewSelectFiles.UseVisualStyleBackColor = false;
            // 
            // btnNewFilePrintRepo
            // 
            this.btnNewFilePrintRepo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewFilePrintRepo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewFilePrintRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewFilePrintRepo.ForeColor = System.Drawing.Color.White;
            this.btnNewFilePrintRepo.Location = new System.Drawing.Point(12, 225);
            this.btnNewFilePrintRepo.Name = "btnNewFilePrintRepo";
            this.btnNewFilePrintRepo.Size = new System.Drawing.Size(170, 52);
            this.btnNewFilePrintRepo.TabIndex = 11;
            this.btnNewFilePrintRepo.Text = "Print Report";
            this.btnNewFilePrintRepo.UseVisualStyleBackColor = false;
            // 
            // NewFilelistView
            // 
            this.NewFilelistView.AllowColumnReorder = true;
            this.NewFilelistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.NewFilelistView.FullRowSelect = true;
            this.NewFilelistView.GridLines = true;
            this.NewFilelistView.Location = new System.Drawing.Point(207, 97);
            this.NewFilelistView.Name = "NewFilelistView";
            this.NewFilelistView.Size = new System.Drawing.Size(691, 504);
            this.NewFilelistView.TabIndex = 22;
            this.NewFilelistView.UseCompatibleStateImageBehavior = false;
            this.NewFilelistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Path";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date Modified";
            this.columnHeader3.Width = 132;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "File Size";
            this.columnHeader4.Width = 123;
            // 
            // NewFiletoolTip
            // 
            this.NewFiletoolTip.IsBalloon = true;
            // 
            // FormFileAidNewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 787);
            this.Controls.Add(this.NewFilelistView);
            this.Controls.Add(this.btnNewFilePrintRepo);
            this.Controls.Add(this.btnNewSelectFiles);
            this.Controls.Add(this.lblMainInfo);
            this.Name = "FormFileAidNewFile";
            this.Text = "FileAidNewFile";
            this.Load += new System.EventHandler(this.FormFileAidNewFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainInfo;
        private System.Windows.Forms.Button btnNewSelectFiles;
        private System.Windows.Forms.Button btnNewFilePrintRepo;
        private System.Windows.Forms.ListView NewFilelistView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolTip NewFiletoolTip;
    }
}

