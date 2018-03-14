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
    public partial class FormFileAidLogin : Form
    {
        public FormFileAidLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (true) {
                DialogResult = DialogResult.OK;
                Close();
            } else {
                DialogResult = DialogResult.None;
            }
        }
    }
}
