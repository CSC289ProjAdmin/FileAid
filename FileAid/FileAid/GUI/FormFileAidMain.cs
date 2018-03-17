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
    public partial class FormFileAidMain : Form
    {
        public FormFileAidMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            FormFileAidNewFile newfile = new FormFileAidNewFile();
            newfile.ShowDialog();
        }

        private void btnAddLink_Click(object sender, EventArgs e) {
            FormFileAidLink newLink = new FormFileAidLink();
            newLink.ShowDialog();
        }
    }
}
