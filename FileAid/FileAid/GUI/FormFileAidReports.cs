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
    public partial class FormFileAidReports : Form
    {
        public FormFileAidReports()
        {
            InitializeComponent();
        }

        private void FormFileAidReports_Load(object sender, EventArgs e)
        {
            ReporttoolTip.SetToolTip(btnRunReport, "Run report");
        }
    }
}
