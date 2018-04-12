using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FileAid.Models;
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
                Configs getConfig = ConfigManager.GetConfigs();

                if(getConfig == null)
                {
                    MessageBox.Show("Unable to load Program setting");
                    return;
                }

                ProInactivecheckBox.Checked = getConfig.ShowInactive;
                PeriodicnumericUpDown.Value = getConfig.UpdateTimerInMinutes;
                txtProgramPath.Text = (string.IsNullOrEmpty(getConfig.MasterPath) ? "" : getConfig.MasterPath);
            }
            catch (SqlException)
            {
                Messenger.ShowDbMsg();
            }
        }

        private void btnProSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                Configs getConfig = ConfigManager.GetConfigs();

                if (getConfig == null)
                {
                    MessageBox.Show("Unable to load program settings. Cannot save changes.");
                    return;
                }

                getConfig.ShowInactive = ProInactivecheckBox.Checked;
                getConfig.UpdateTimerInMinutes = (int)PeriodicnumericUpDown.Value;
                getConfig.MasterPath = txtProgramPath.Text.Trim();

                Configs wasUpdate = ConfigManager.UpdateConfigs(getConfig);
                if (wasUpdate != null)
                {
                    bool wasLogged = LogProgramSetting(wasUpdate.ConfigID);
                    if (!wasLogged)
                    {
                        Messenger.Show("Failed to record setting change event.");
                    }
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
                Messenger.ShowDbMsg();
            }

        }

        private void btnProCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                string path = folder.SelectedPath;
                txtProgramPath.Text = path;
            }

        }

        private bool LogProgramSetting(int configId)
        {
            Event ev = new Event();
            ev.EventTypeID = EventTypes.ProgramSettingsChanged;
            ev.ConfigID = configId;
            ev.OccurredOn = DateTime.Now;
            ev.Description = "Program settings changed";
            bool wasLogged = Logger.Log(ev);
            return wasLogged;
        }

    }
}
