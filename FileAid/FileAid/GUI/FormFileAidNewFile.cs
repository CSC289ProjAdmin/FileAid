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
            NewFiletoolTip.SetToolTip(btnAddNewFile, "Add new file");
            NewFiletoolTip.SetToolTip(txtNewFileMemo, "Enter memo");
            NewFiletoolTip.SetToolTip(btnNewFileMemoUpdate, "Update memo");
            NewFiletoolTip.SetToolTip(btnAddLink, "Add file link");
            NewFiletoolTip.SetToolTip(txtNewFileSearch, "Enter file to search");
            NewFiletoolTip.SetToolTip(btnNewFileSearch, "Search the file");
            NewFiletoolTip.SetToolTip(btnNewFilePrintRepo, "Print the report");
        }
    }
}
