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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEventsReport = new System.Windows.Forms.Button();
            this.btnEventsFilters = new System.Windows.Forms.Button();
            this.lblEventsFilters = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.EventstoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.StartdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMainInfo.Location = new System.Drawing.Point(174, 21);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(574, 37);
            this.lblMainInfo.TabIndex = 1;
            this.lblMainInfo.Text = "Welcome to File Aid Events Window.";
            // 
            // EventslistView
            // 
            this.EventslistView.AllowColumnReorder = true;
            this.EventslistView.CheckBoxes = true;
            this.EventslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.EventslistView.FullRowSelect = true;
            this.EventslistView.GridLines = true;
            this.EventslistView.Location = new System.Drawing.Point(36, 89);
            this.EventslistView.Name = "EventslistView";
            this.EventslistView.Size = new System.Drawing.Size(779, 484);
            this.EventslistView.TabIndex = 2;
            this.EventslistView.UseCompatibleStateImageBehavior = false;
            this.EventslistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "EventId";
            this.columnHeader1.Width = 143;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 161;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Occurred on";
            this.columnHeader3.Width = 165;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(845, 459);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(170, 52);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnEventsReport
            // 
            this.btnEventsReport.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEventsReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEventsReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventsReport.ForeColor = System.Drawing.Color.White;
            this.btnEventsReport.Location = new System.Drawing.Point(845, 317);
            this.btnEventsReport.Name = "btnEventsReport";
            this.btnEventsReport.Size = new System.Drawing.Size(170, 52);
            this.btnEventsReport.TabIndex = 10;
            this.btnEventsReport.Text = "Print Report";
            this.btnEventsReport.UseVisualStyleBackColor = false;
            // 
            // btnEventsFilters
            // 
            this.btnEventsFilters.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEventsFilters.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEventsFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventsFilters.ForeColor = System.Drawing.Color.White;
            this.btnEventsFilters.Location = new System.Drawing.Point(845, 596);
            this.btnEventsFilters.Name = "btnEventsFilters";
            this.btnEventsFilters.Size = new System.Drawing.Size(170, 52);
            this.btnEventsFilters.TabIndex = 11;
            this.btnEventsFilters.Text = "Filters";
            this.btnEventsFilters.UseVisualStyleBackColor = false;
            // 
            // lblEventsFilters
            // 
            this.lblEventsFilters.AutoSize = true;
            this.lblEventsFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventsFilters.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEventsFilters.Location = new System.Drawing.Point(432, 611);
            this.lblEventsFilters.Name = "lblEventsFilters";
            this.lblEventsFilters.Size = new System.Drawing.Size(79, 22);
            this.lblEventsFilters.TabIndex = 12;
            this.lblEventsFilters.Text = "Search:";
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(534, 607);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(293, 26);
            this.txtMemo.TabIndex = 18;
            // 
            // EventstoolTip
            // 
            this.EventstoolTip.IsBalloon = true;
            // 
            // StartdateTimePicker
            // 
            this.StartdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartdateTimePicker.Location = new System.Drawing.Point(97, 611);
            this.StartdateTimePicker.Name = "StartdateTimePicker";
            this.StartdateTimePicker.ShowUpDown = true;
            this.StartdateTimePicker.Size = new System.Drawing.Size(124, 26);
            this.StartdateTimePicker.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(302, 611);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 26);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.DarkRed;
            this.lblStart.Location = new System.Drawing.Point(32, 614);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(59, 22);
            this.lblStart.TabIndex = 21;
            this.lblStart.Text = "Start:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEnd.Location = new System.Drawing.Point(236, 614);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(51, 22);
            this.lblEnd.TabIndex = 22;
            this.lblEnd.Text = "End:";
            // 
            // FormFileAidEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 753);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.StartdateTimePicker);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.lblEventsFilters);
            this.Controls.Add(this.btnEventsFilters);
            this.Controls.Add(this.btnEventsReport);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.EventslistView);
            this.Controls.Add(this.lblMainInfo);
            this.Name = "FormFileAidEvents";
            this.Text = "FileAidEvents";
            this.Load += new System.EventHandler(this.FormFileAidEvents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainInfo;
        private System.Windows.Forms.ListView EventslistView;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEventsReport;
        private System.Windows.Forms.Button btnEventsFilters;
        private System.Windows.Forms.Label lblEventsFilters;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolTip EventstoolTip;
        private System.Windows.Forms.DateTimePicker StartdateTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
    }
}

