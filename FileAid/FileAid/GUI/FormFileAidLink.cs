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
    public partial class FormFileAidLink : Form
    {
        public FormFileAidLink()
        {
            InitializeComponent();
        }

        private void FormFileAidLink_Load(object sender, EventArgs e)
        {
            AddLinktoolTip.SetToolTip(txtLinkMemo, "Enter the memo");
            AddLinktoolTip.SetToolTip(btnAddLink, "Add link");
            AddLinktoolTip.SetToolTip(btnCancelLink, "Cancel file link");

            
        }
    }
}
