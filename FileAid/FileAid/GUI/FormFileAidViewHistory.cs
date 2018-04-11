using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileAid.Models;

namespace FileAid.GUI
{
    public partial class FormFileAidViewHistory : Form
    {
        private TrackedFile selectedFile;
        public FormFileAidViewHistory(TrackedFile tf)
        {
            InitializeComponent();
            selectedFile = tf;
        }
    }
}
