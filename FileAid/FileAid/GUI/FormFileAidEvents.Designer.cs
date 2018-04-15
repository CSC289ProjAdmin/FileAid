namespace FileAid.GUI
{
    partial class FormFileAidEvents
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
            this.EventslistView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEventsReport = new System.Windows.Forms.Button();
            this.btnEventsSearch = new System.Windows.Forms.Button();
            this.lblEventsSearch = new System.Windows.Forms.Label();
            this.txtWild = new System.Windows.Forms.TextBox();
            this.EventstoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.EventsStartdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EventsEnddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMainInfo.Location = new System.Drawing.Point(288, 14);
            this.lblMainInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(243, 26);
            this.lblMainInfo.TabIndex = 0;
            this.lblMainInfo.Text = "File Aid Event History";
            // 
            // EventslistView
            // 
            this.EventslistView.AllowColumnReorder = true;
            this.EventslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader4});
            this.EventslistView.FullRowSelect = true;
            this.EventslistView.GridLines = true;
            this.EventslistView.Location = new System.Drawing.Point(11, 83);
            this.EventslistView.Margin = new System.Windows.Forms.Padding(2);
            this.EventslistView.Name = "EventslistView";
            this.EventslistView.Size = new System.Drawing.Size(797, 316);
            this.EventslistView.TabIndex = 10;
            this.EventslistView.UseCompatibleStateImageBehavior = false;
            this.EventslistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Event Description";
            this.columnHeader2.Width = 350;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Initial";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "New";
            this.columnHeader4.Width = 150;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(275, 421);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(113, 34);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEventsReport
            // 
            this.btnEventsReport.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEventsReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEventsReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventsReport.ForeColor = System.Drawing.Color.White;
            this.btnEventsReport.Location = new System.Drawing.Point(430, 421);
            this.btnEventsReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventsReport.Name = "btnEventsReport";
            this.btnEventsReport.Size = new System.Drawing.Size(113, 34);
            this.btnEventsReport.TabIndex = 9;
            this.btnEventsReport.Text = "Print Report";
            this.btnEventsReport.UseVisualStyleBackColor = false;
            this.btnEventsReport.Click += new System.EventHandler(this.btnEventsReport_Click);
            // 
            // btnEventsSearch
            // 
            this.btnEventsSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEventsSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEventsSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventsSearch.ForeColor = System.Drawing.Color.White;
            this.btnEventsSearch.Location = new System.Drawing.Point(612, 45);
            this.btnEventsSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventsSearch.Name = "btnEventsSearch";
            this.btnEventsSearch.Size = new System.Drawing.Size(113, 34);
            this.btnEventsSearch.TabIndex = 7;
            this.btnEventsSearch.Text = "Search";
            this.btnEventsSearch.UseVisualStyleBackColor = false;
            this.btnEventsSearch.Click += new System.EventHandler(this.btnEventsSearch_Click);
            // 
            // lblEventsSearch
            // 
            this.lblEventsSearch.AutoSize = true;
            this.lblEventsSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventsSearch.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEventsSearch.Location = new System.Drawing.Point(344, 62);
            this.lblEventsSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventsSearch.Name = "lblEventsSearch";
            this.lblEventsSearch.Size = new System.Drawing.Size(56, 15);
            this.lblEventsSearch.TabIndex = 5;
            this.lblEventsSearch.Text = "Search:";
            // 
            // txtWild
            // 
            this.txtWild.Location = new System.Drawing.Point(412, 60);
            this.txtWild.Margin = new System.Windows.Forms.Padding(2);
            this.txtWild.Name = "txtWild";
            this.txtWild.Size = new System.Drawing.Size(197, 20);
            this.txtWild.TabIndex = 6;
            // 
            // EventstoolTip
            // 
            this.EventstoolTip.IsBalloon = true;
            // 
            // EventsStartdateTimePicker
            // 
            this.EventsStartdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EventsStartdateTimePicker.Location = new System.Drawing.Point(121, 62);
            this.EventsStartdateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.EventsStartdateTimePicker.Name = "EventsStartdateTimePicker";
            this.EventsStartdateTimePicker.ShowUpDown = true;
            this.EventsStartdateTimePicker.Size = new System.Drawing.Size(84, 20);
            this.EventsStartdateTimePicker.TabIndex = 2;
            // 
            // EventsEnddateTimePicker
            // 
            this.EventsEnddateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EventsEnddateTimePicker.Location = new System.Drawing.Point(257, 62);
            this.EventsEnddateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.EventsEnddateTimePicker.Name = "EventsEnddateTimePicker";
            this.EventsEnddateTimePicker.ShowUpDown = true;
            this.EventsEnddateTimePicker.Size = new System.Drawing.Size(84, 20);
            this.EventsEnddateTimePicker.TabIndex = 4;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.DarkRed;
            this.lblStart.Location = new System.Drawing.Point(77, 64);
            this.lblStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(41, 15);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Start:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEnd.Location = new System.Drawing.Point(213, 64);
            this.lblEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(36, 15);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "End:";
            // 
            // FormFileAidEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 489);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.EventsEnddateTimePicker);
            this.Controls.Add(this.EventsStartdateTimePicker);
            this.Controls.Add(this.txtWild);
            this.Controls.Add(this.lblEventsSearch);
            this.Controls.Add(this.btnEventsSearch);
            this.Controls.Add(this.btnEventsReport);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.EventslistView);
            this.Controls.Add(this.lblMainInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFileAidEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FileAid Event History";
            this.Load += new System.EventHandler(this.FormFileAidEvents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainInfo;
        private System.Windows.Forms.ListView EventslistView;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEventsReport;
        private System.Windows.Forms.Button btnEventsSearch;
        private System.Windows.Forms.Label lblEventsSearch;
        private System.Windows.Forms.TextBox txtWild;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolTip EventstoolTip;
        private System.Windows.Forms.DateTimePicker EventsStartdateTimePicker;
        private System.Windows.Forms.DateTimePicker EventsEnddateTimePicker;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

