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
    public partial class FormFileAidReminder : Form
    {
        public FormFileAidReminder()
        {
            InitializeComponent();
        }

        private void FormFileAidReminder_Load(object sender, EventArgs e)
        {
            RemindertoolTip.SetToolTip(ReminderdateTimePicker, "Select reminder due");
            RemindertoolTip.SetToolTip(txtDescription, "Enter description");
            RemindertoolTip.SetToolTip(txtReminderName, "Enter reminder name");
            RemindertoolTip.SetToolTip(btnAddReminder, "Add reminder");
            RemindertoolTip.SetToolTip(btnReminderCancel, "Cancel reminder");

        }
    }
}
