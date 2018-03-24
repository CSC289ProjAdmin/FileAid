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

        private void FormFileAidLogin_Load(object sender, EventArgs e)
        {
            LogintoolTip.SetToolTip(txtUserName, "Enter username");
            LogintoolTip.SetToolTip(txtPassword, "Enter password");
            LogintoolTip.SetToolTip(btnLogin, "Login to FileAid");
        }
    }
}
