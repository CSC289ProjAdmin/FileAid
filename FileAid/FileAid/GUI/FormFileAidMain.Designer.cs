namespace FileAid.GUI
{
    partial class FormFileAidMain
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
            this.MainListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FiltercheckBox = new System.Windows.Forms.CheckBox();
            this.InactivecheckBox = new System.Windows.Forms.CheckBox();
            this.StartdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.EnddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnStopTrack = new System.Windows.Forms.Button();
            this.btnTrack = new System.Windows.Forms.Button();
            this.btnAddLink = new System.Windows.Forms.Button();
            this.btnAddReminder = new System.Windows.Forms.Button();
            this.txtWild = new System.Windows.Forms.TextBox();
            this.btnWildSearch = new System.Windows.Forms.Button();
            this.lblMemo = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnMainPrintRepo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMainInfo.Location = new System.Drawing.Point(330, 9);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(546, 37);
            this.lblMainInfo.TabIndex = 0;
            this.lblMainInfo.Text = "Welcome to File Aid main Window.";
            // 
            // MainListView
            // 
            this.MainListView.AllowColumnReorder = true;
            this.MainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.MainListView.FullRowSelect = true;
            this.MainListView.GridLines = true;
            this.MainListView.Location = new System.Drawing.Point(190, 82);
            this.MainListView.Name = "MainListView";
            this.MainListView.Size = new System.Drawing.Size(1042, 365);
            this.MainListView.TabIndex = 1;
            this.MainListView.UseCompatibleStateImageBehavior = false;
            this.MainListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File Name";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "File Path";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "File Size";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date Modified";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Update History";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "File Extension";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tracked Files";
            this.columnHeader7.Width = 120;
            // 
            // FiltercheckBox
            // 
            this.FiltercheckBox.AutoSize = true;
            this.FiltercheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltercheckBox.ForeColor = System.Drawing.Color.DarkRed;
            this.FiltercheckBox.Location = new System.Drawing.Point(190, 54);
            this.FiltercheckBox.Name = "FiltercheckBox";
            this.FiltercheckBox.Size = new System.Drawing.Size(92, 26);
            this.FiltercheckBox.TabIndex = 2;
            this.FiltercheckBox.Text = "Filters";
            this.FiltercheckBox.UseVisualStyleBackColor = true;
            // 
            // InactivecheckBox
            // 
            this.InactivecheckBox.AutoSize = true;
            this.InactivecheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InactivecheckBox.ForeColor = System.Drawing.Color.DarkRed;
            this.InactivecheckBox.Location = new System.Drawing.Point(289, 54);
            this.InactivecheckBox.Name = "InactivecheckBox";
            this.InactivecheckBox.Size = new System.Drawing.Size(154, 26);
            this.InactivecheckBox.TabIndex = 3;
            this.InactivecheckBox.Text = "Inactive Files";
            this.InactivecheckBox.UseVisualStyleBackColor = true;
            // 
            // StartdateTimePicker
            // 
            this.StartdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartdateTimePicker.Location = new System.Drawing.Point(520, 52);
            this.StartdateTimePicker.Name = "StartdateTimePicker";
            this.StartdateTimePicker.ShowUpDown = true;
            this.StartdateTimePicker.Size = new System.Drawing.Size(124, 26);
            this.StartdateTimePicker.TabIndex = 4;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.DarkRed;
            this.lblStart.Location = new System.Drawing.Point(458, 55);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(59, 22);
            this.lblStart.TabIndex = 5;
            this.lblStart.Text = "Start:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEnd.Location = new System.Drawing.Point(650, 54);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(51, 22);
            this.lblEnd.TabIndex = 6;
            this.lblEnd.Text = "End:";
            // 
            // EnddateTimePicker
            // 
            this.EnddateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EnddateTimePicker.Location = new System.Drawing.Point(707, 51);
            this.EnddateTimePicker.Name = "EnddateTimePicker";
            this.EnddateTimePicker.ShowUpDown = true;
            this.EnddateTimePicker.Size = new System.Drawing.Size(120, 26);
            this.EnddateTimePicker.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(14, 82);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 52);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnStopTrack
            // 
            this.btnStopTrack.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStopTrack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStopTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopTrack.ForeColor = System.Drawing.Color.White;
            this.btnStopTrack.Location = new System.Drawing.Point(14, 153);
            this.btnStopTrack.Name = "btnStopTrack";
            this.btnStopTrack.Size = new System.Drawing.Size(170, 52);
            this.btnStopTrack.TabIndex = 9;
            this.btnStopTrack.Text = "Stop Tracking";
            this.btnStopTrack.UseVisualStyleBackColor = false;
            // 
            // btnTrack
            // 
            this.btnTrack.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTrack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrack.ForeColor = System.Drawing.Color.White;
            this.btnTrack.Location = new System.Drawing.Point(14, 235);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(170, 52);
            this.btnTrack.TabIndex = 10;
            this.btnTrack.Text = "Track";
            this.btnTrack.UseVisualStyleBackColor = false;
            // 
            // btnAddLink
            // 
            this.btnAddLink.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddLink.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLink.ForeColor = System.Drawing.Color.White;
            this.btnAddLink.Location = new System.Drawing.Point(14, 314);
            this.btnAddLink.Name = "btnAddLink";
            this.btnAddLink.Size = new System.Drawing.Size(170, 52);
            this.btnAddLink.TabIndex = 11;
            this.btnAddLink.Text = "Add Link";
            this.btnAddLink.UseVisualStyleBackColor = false;
            // 
            // btnAddReminder
            // 
            this.btnAddReminder.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddReminder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReminder.ForeColor = System.Drawing.Color.White;
            this.btnAddReminder.Location = new System.Drawing.Point(14, 395);
            this.btnAddReminder.Name = "btnAddReminder";
            this.btnAddReminder.Size = new System.Drawing.Size(170, 52);
            this.btnAddReminder.TabIndex = 12;
            this.btnAddReminder.Text = "Add Reminder";
            this.btnAddReminder.UseVisualStyleBackColor = false;
            // 
            // txtWild
            // 
            this.txtWild.Location = new System.Drawing.Point(833, 49);
            this.txtWild.Name = "txtWild";
            this.txtWild.Size = new System.Drawing.Size(285, 26);
            this.txtWild.TabIndex = 14;
            // 
            // btnWildSearch
            // 
            this.btnWildSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnWildSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWildSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWildSearch.ForeColor = System.Drawing.Color.White;
            this.btnWildSearch.Location = new System.Drawing.Point(1124, 39);
            this.btnWildSearch.Name = "btnWildSearch";
            this.btnWildSearch.Size = new System.Drawing.Size(90, 41);
            this.btnWildSearch.TabIndex = 15;
            this.btnWildSearch.Text = "Search";
            this.btnWildSearch.UseVisualStyleBackColor = false;
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMemo.Location = new System.Drawing.Point(24, 469);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(68, 22);
            this.lblMemo.TabIndex = 16;
            this.lblMemo.Text = "Memo:";
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(98, 469);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(223, 26);
            this.txtMemo.TabIndex = 17;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(327, 454);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(170, 52);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnMainPrintRepo
            // 
            this.btnMainPrintRepo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMainPrintRepo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMainPrintRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainPrintRepo.ForeColor = System.Drawing.Color.White;
            this.btnMainPrintRepo.Location = new System.Drawing.Point(531, 455);
            this.btnMainPrintRepo.Name = "btnMainPrintRepo";
            this.btnMainPrintRepo.Size = new System.Drawing.Size(170, 52);
            this.btnMainPrintRepo.TabIndex = 19;
            this.btnMainPrintRepo.Text = "Print Report";
            this.btnMainPrintRepo.UseVisualStyleBackColor = false;
            // 
            // FileAidMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 1038);
            this.Controls.Add(this.btnMainPrintRepo);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.lblMemo);
            this.Controls.Add(this.btnWildSearch);
            this.Controls.Add(this.txtWild);
            this.Controls.Add(this.btnAddReminder);
            this.Controls.Add(this.btnAddLink);
            this.Controls.Add(this.btnTrack);
            this.Controls.Add(this.btnStopTrack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.EnddateTimePicker);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.StartdateTimePicker);
            this.Controls.Add(this.InactivecheckBox);
            this.Controls.Add(this.FiltercheckBox);
            this.Controls.Add(this.MainListView);
            this.Controls.Add(this.lblMainInfo);
            this.Name = "FileAidMain";
            this.Text = "FileAidMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainInfo;
        private System.Windows.Forms.ListView MainListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.CheckBox FiltercheckBox;
        private System.Windows.Forms.CheckBox InactivecheckBox;
        private System.Windows.Forms.DateTimePicker StartdateTimePicker;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker EnddateTimePicker;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnStopTrack;
        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.Button btnAddLink;
        private System.Windows.Forms.Button btnAddReminder;
        private System.Windows.Forms.TextBox txtWild;
        private System.Windows.Forms.Button btnWildSearch;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnMainPrintRepo;
    }
}

