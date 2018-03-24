﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileAid.GUI
{
    public partial class FormFileAidConfig : Form
    {
        public FormFileAidConfig()
        {
            InitializeComponent();
        }

        private void FileAidConfig_Load(object sender, EventArgs e)
        {
            ConfigtoolTip.SetToolTip(PeriodicdateTimePicker, "Select Periodic Update Date");
            ConfigtoolTip.SetToolTip(btnPeriodicUpdate, "Periodic Update");
            ConfigtoolTip.SetToolTip(btnModifiedFiles, "Display Modified files");
        }
    }
}
