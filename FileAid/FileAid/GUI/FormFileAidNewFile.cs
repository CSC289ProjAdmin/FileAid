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
    public partial class FormFileAidNewFile : Form
    {
        public FormFileAidNewFile()
        {
            InitializeComponent();
        }

        private void FormFileAidNewFile_Load(object sender, EventArgs e)
        {
            NewFiletoolTip.SetToolTip(btnNewSelectFiles, "Add new file");
            NewFiletoolTip.SetToolTip(btnNewFilePrintRepo, "Print the report");
        }
    }
}
