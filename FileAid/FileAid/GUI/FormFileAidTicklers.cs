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
    public partial class FormFileAidTicklers : Form
    {
        public FormFileAidTicklers()
        {
            InitializeComponent();
        }

        private void FormFileAidTicklers_Load(object sender, EventArgs e)
        {
            TicklerstoolTip.SetToolTip(btnPushToOutlook, "Push to outlook");
            TicklerstoolTip.SetToolTip(btnResolved, "Mark as resolved");
        }
    }
}
