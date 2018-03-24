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
    public partial class FormFileAidDbMgmt : Form
    {
        public FormFileAidDbMgmt()
        {
            InitializeComponent();
        }

        private void FormFileAidDbMgmt_Load(object sender, EventArgs e)
        {
            DBMantoolTip.SetToolTip(btnBackup, "Backup the Data");
            DBMantoolTip.SetToolTip(btnRestore, "Restore the Data");
            DBMantoolTip.SetToolTip(btnSelectFile, "Select the files");
            DBMantoolTip.SetToolTip(btnReset, "Reset the Database");
            DBMantoolTip.SetToolTip(btnDbPrintRepo, "Print the report");
        }
    }
}
