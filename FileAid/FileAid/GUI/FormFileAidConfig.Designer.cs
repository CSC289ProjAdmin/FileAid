namespace FileAid.GUI
{
    partial class FormFileAidConfig
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblPeriodicUpdate = new System.Windows.Forms.Label();
            this.ConfigtoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtProgramPath = new System.Windows.Forms.TextBox();
            this.btnProSaveChanges = new System.Windows.Forms.Button();
            this.btnProCancel = new System.Windows.Forms.Button();
            this.ProInactivecheckBox = new System.Windows.Forms.CheckBox();
            this.lblUpdatePath = new System.Windows.Forms.Label();
            this.PeriodicnumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodicnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.AutoSize = true;
            this.lblMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMainInfo.Location = new System.Drawing.Point(150, 12);
            this.lblMainInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(278, 26);
            this.lblMainInfo.TabIndex = 1;
            this.lblMainInfo.Text = "FileAid Program Settings";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(430, 65);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(119, 34);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblPeriodicUpdate
            // 
            this.lblPeriodicUpdate.AutoSize = true;
            this.lblPeriodicUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodicUpdate.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPeriodicUpdate.Location = new System.Drawing.Point(30, 144);
            this.lblPeriodicUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeriodicUpdate.Name = "lblPeriodicUpdate";
            this.lblPeriodicUpdate.Size = new System.Drawing.Size(163, 15);
            this.lblPeriodicUpdate.TabIndex = 11;
            this.lblPeriodicUpdate.Text = "Update Timer (minutes):";
            // 
            // ConfigtoolTip
            // 
            this.ConfigtoolTip.IsBalloon = true;
            // 
            // txtProgramPath
            // 
            this.txtProgramPath.Location = new System.Drawing.Point(169, 75);
            this.txtProgramPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtProgramPath.Name = "txtProgramPath";
            this.txtProgramPath.Size = new System.Drawing.Size(257, 20);
            this.txtProgramPath.TabIndex = 12;
            // 
            // btnProSaveChanges
            // 
            this.btnProSaveChanges.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnProSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnProSaveChanges.Location = new System.Drawing.Point(149, 222);
            this.btnProSaveChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btnProSaveChanges.Name = "btnProSaveChanges";
            this.btnProSaveChanges.Size = new System.Drawing.Size(119, 34);
            this.btnProSaveChanges.TabIndex = 14;
            this.btnProSaveChanges.Text = "Save Changes";
            this.btnProSaveChanges.UseVisualStyleBackColor = false;
            this.btnProSaveChanges.Click += new System.EventHandler(this.btnProSaveChanges_Click);
            // 
            // btnProCancel
            // 
            this.btnProCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnProCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProCancel.ForeColor = System.Drawing.Color.White;
            this.btnProCancel.Location = new System.Drawing.Point(310, 222);
            this.btnProCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnProCancel.Name = "btnProCancel";
            this.btnProCancel.Size = new System.Drawing.Size(119, 34);
            this.btnProCancel.TabIndex = 15;
            this.btnProCancel.Text = "Cancel";
            this.btnProCancel.UseVisualStyleBackColor = false;
            this.btnProCancel.Click += new System.EventHandler(this.btnProCancel_Click);
            // 
            // ProInactivecheckBox
            // 
            this.ProInactivecheckBox.AutoSize = true;
            this.ProInactivecheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProInactivecheckBox.ForeColor = System.Drawing.Color.DarkRed;
            this.ProInactivecheckBox.Location = new System.Drawing.Point(338, 143);
            this.ProInactivecheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.ProInactivecheckBox.Name = "ProInactivecheckBox";
            this.ProInactivecheckBox.Size = new System.Drawing.Size(211, 19);
            this.ProInactivecheckBox.TabIndex = 16;
            this.ProInactivecheckBox.Text = "Show inactive files by default";
            this.ProInactivecheckBox.UseVisualStyleBackColor = true;
            // 
            // lblUpdatePath
            // 
            this.lblUpdatePath.AutoSize = true;
            this.lblUpdatePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatePath.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUpdatePath.Location = new System.Drawing.Point(30, 75);
            this.lblUpdatePath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdatePath.Name = "lblUpdatePath";
            this.lblUpdatePath.Size = new System.Drawing.Size(137, 15);
            this.lblUpdatePath.TabIndex = 17;
            this.lblUpdatePath.Text = "Search folder / path:";
            // 
            // PeriodicnumericUpDown
            // 
            this.PeriodicnumericUpDown.Location = new System.Drawing.Point(198, 144);
            this.PeriodicnumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.PeriodicnumericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.PeriodicnumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PeriodicnumericUpDown.Name = "PeriodicnumericUpDown";
            this.PeriodicnumericUpDown.Size = new System.Drawing.Size(46, 20);
            this.PeriodicnumericUpDown.TabIndex = 18;
            this.PeriodicnumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormFileAidConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 324);
            this.Controls.Add(this.PeriodicnumericUpDown);
            this.Controls.Add(this.lblUpdatePath);
            this.Controls.Add(this.ProInactivecheckBox);
            this.Controls.Add(this.btnProCancel);
            this.Controls.Add(this.btnProSaveChanges);
            this.Controls.Add(this.txtProgramPath);
            this.Controls.Add(this.lblPeriodicUpdate);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblMainInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFileAidConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FileAid Program Settings";
            this.Load += new System.EventHandler(this.FileAidConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PeriodicnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainInfo;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblPeriodicUpdate;
        private System.Windows.Forms.ToolTip ConfigtoolTip;
        private System.Windows.Forms.TextBox txtProgramPath;
        private System.Windows.Forms.Button btnProSaveChanges;
        private System.Windows.Forms.Button btnProCancel;
        private System.Windows.Forms.CheckBox ProInactivecheckBox;
        private System.Windows.Forms.Label lblUpdatePath;
        private System.Windows.Forms.NumericUpDown PeriodicnumericUpDown;
    }
}

