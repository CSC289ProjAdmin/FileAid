using System;
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
    public partial class FormFileAidEvents : Form
    {
        public FormFileAidEvents()
        {
            InitializeComponent();
        }

        private void FormFileAidEvents_Load(object sender, EventArgs e)
        {
            EventstoolTip.SetToolTip(btnReset, "Reset the events");
            EventstoolTip.SetToolTip(btnEventsReport, "Print the events report");
            EventstoolTip.SetToolTip(txtMemo, "Enter the memo");
            EventstoolTip.SetToolTip(btnEventsFilters, "Filters the files");
        }
    }
}
