using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FileAid.GUI
{
    public partial class FormFileAidConfig : Form
    {
        
        public FormFileAidConfig()
        {
            InitializeComponent();
        }

        private void FileAidConfig_Load(object sender, EventArgs e)
        {
            ConfigtoolTip.SetToolTip(PeriodicnumericUpDown, "Select Periodic Update Time");
            ConfigtoolTip.SetToolTip(ProInactivecheckBox, "Show inactive files");
            ConfigtoolTip.SetToolTip(txtProgramPath, "Enter folder paths");
            ConfigtoolTip.SetToolTip(btnBrowse, "Browse files");
            ConfigtoolTip.SetToolTip(btnProSaveChanges, "Save Changes");
            ConfigtoolTip.SetToolTip(btnProCancel, "Cancel changes");

            try
            {
                Models.Configs getConfig = Models.ConfigManager.GetConfigs();

                if(getConfig == null)
                {
                    MessageBox.Show("Unable to load Program setting");
                }

                ProInactivecheckBox.Checked = getConfig.ShowInactive;
                PeriodicnumericUpDown.Value = getConfig.UpdateTimerInMinutes;
            }
            catch (SqlException)
            {
                MessageBox.Show("Database connection failed");
            }
        }

        private void btnProSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Configs getConfig = Models.ConfigManager.GetConfigs();

                if (getConfig == null)
                {
                    MessageBox.Show("Unable to load Program setting");
                }

                getConfig.ShowInactive = ProInactivecheckBox.Checked;
                getConfig.UpdateTimerInMinutes = (int)PeriodicnumericUpDown.Value;

                Models.Configs wasUpdate = Models.ConfigManager.UpdateConfigs(getConfig);
                if (wasUpdate != null)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to save changes");
                    DialogResult = DialogResult.None;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Database connection failed");
            }

        }

        private void btnProCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = folder.SelectedPath;
                txtProgramPath.Text = path;
            }

        }
  
    }
}
