using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FileAid.Models;
using System.IO;

namespace FileAid.GUI
{
    public partial class FormFileAidNewFile : Form
    {
        private string caption = "FileAid - Add New Files";
        private List<string> filesToAdd;
        public FormFileAidNewFile()
        {
            InitializeComponent();
            filesToAdd = new List<string>();
        }

        private void FillListView() {
            AddFilelistView.Items.Clear();
            if (filesToAdd == null || filesToAdd.Count == 0) return;
            foreach (var file in filesToAdd) {
                FileInfo fi = new FileInfo(file);
                if (!fi.Exists) continue;

                string[] fiDetails = new string[7];
                bool alreadyInSystem = FileManager.Exists(file);
                fiDetails[0] = ""; // Fake first column to center real first column
                fiDetails[1] = alreadyInSystem ? "X" : "";
                fiDetails[2] = Path.GetFileNameWithoutExtension(fi.Name);
                fiDetails[3] = fi.Extension.Substring(1);
                fiDetails[4] = fi.DirectoryName;
                fiDetails[5] = fi.Length.ToString();
                fiDetails[6] = fi.LastWriteTime.ToString();
                ListViewItem row = new ListViewItem(fiDetails);
                row.Tag = file;
                AddFilelistView.Items.Add(row);
            }
        }

        private void FormFileAidNewFile_Load(object sender, EventArgs e)
        {
            NewFiletoolTip.SetToolTip(btnNewSelectFiles, "Add new file");
            //NewFiletoolTip.SetToolTip(btnNewFilePrintRepo, "Print the report");

            FillListView();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnAddFiles_Click(object sender, EventArgs e) {
            if (filesToAdd == null || filesToAdd.Count == 0) return;
            int nAdded = 0;
            List<TrackedFile> newFiles = new List<TrackedFile>();
            foreach (var file in filesToAdd) {
                FileInfo fi = new FileInfo(file);
                if (!fi.Exists) continue;

                bool alreadyInSystem = FileManager.Exists(file);
                if (!alreadyInSystem) {
                    TrackedFile newFile = FileManager.AddFile(
                        Path.GetFileNameWithoutExtension(fi.Name),
                        fi.Extension.Substring(1), fi.DirectoryName,
                        (int)fi.Length, fi.CreationTime, fi.LastWriteTime);
                    if (newFile != null) {
                        LogFileAdded(newFile);
                        newFiles.Add(newFile);
                        nAdded++;
                    }
                }
            }
            bool wantsLink = chkLinkFiles.Checked;
            string linkResult = null;
            if (wantsLink && nAdded > 1 && newFiles.Count > 1) {
                string memo = txtMemo.Text.Trim();
                var fileIDs = from file in newFiles
                                select file.FileID;
                FileLink newLink = LinkManager.AddLink(fileIDs.ToList(), memo);
                if (newLink != null) {
                    // Log link creation and each file joined
                    LogLinkCreation(newLink.LinkMemoID, nAdded, memo);
                    LogLinkJoined(newLink, newLink.GetFiles());
                    linkResult = $"\n\nLinked {nAdded} files" +
                        (string.IsNullOrEmpty(memo) ? "." : $" as '{memo}'.");
                }
            }
            string resultPrompt = $"Added {nAdded} file(s)." +
                linkResult;
            Messenger.Show(resultPrompt, caption);
            DialogResult = DialogResult.OK;
            Close();
        }

        private bool LogFileAdded(TrackedFile tf) {
            Event ev = new Event();
            ev.EventTypeID = EventTypes.FileAdded;
            ev.FileID = tf.FileID;
            ev.OccurredOn = DateTime.Now;
            ev.Description = $"File added manually: {tf.Filename}.{tf.FileExtension}";
            bool wasLogged = Logger.Log(ev);
            return wasLogged;
        }

        private bool LogLinkCreation(int linkID, int fileCount, string memo) {
            Event ev = new Event();
            ev.EventTypeID = EventTypes.FileLinkAdded;
            ev.OccurredOn = DateTime.Now;
            ev.LinkID = linkID;
            ev.New = memo;
            ev.Description = $"File link added between {fileCount} files.";
            bool wasLogged = Logger.Log(ev);
            return wasLogged;
        }

        private int LogLinkJoined(FileLink link, List<TrackedFile> memberFiles) {
            if (link == null || memberFiles == null || memberFiles.Count == 0) return 0;
            int nJoined = 0;
            foreach (var file in memberFiles) {
                Event ev = new Event();
                ev.EventTypeID = EventTypes.FileLinkJoinedGroup;
                ev.OccurredOn = DateTime.Now;
                ev.LinkID = link.LinkMemoID;
                ev.FileID = file.FileID;
                ev.Description = $"{file.Filename}.{file.FileExtension} joined " +
                    (string.IsNullOrEmpty(link.LinkMemo) ? "unnamed file group" : $"file group: {link.LinkMemo}");
                bool wasJoined = Logger.Log(ev);
                if (wasJoined) nJoined++;
            }
            return nJoined;
        }

        private void btnNewSelectFiles_Click(object sender, EventArgs e) {
            StringBuilder extensions = new StringBuilder();
            extensions.Append("All files|*.*");
            extensions.Append("|Text files|*.txt");
            extensions.Append("|MS Word|*.doc*;*.dot*;*.wbk*");
            extensions.Append("|MS Excel|*.xls*;*.xlt*;*.xlm*;*.xla*;*.xll*;*.xlw*");
            extensions.Append("|MS Powerpoint|*.ppt*;*.pot*;*.pps*;*.ppam*;*.sldx;*.sldm");

            Configs settings = ConfigManager.GetConfigs();

            OpenFileDialog ofd = new OpenFileDialog();
            bool useMasterPath = (settings != null && System.IO.Directory.Exists(settings.MasterPath));
            ofd.InitialDirectory = (useMasterPath) ? settings.MasterPath : "C:\\";
            ofd.Filter = extensions.ToString();
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            ofd.Multiselect = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            if (ofd.ShowDialog() == DialogResult.OK) {
                // Add name to list of candidates
                string [] selectedFiles = ofd.FileNames;
                foreach (string file in selectedFiles) {
                    bool alreadyInList = (filesToAdd.Contains(file));
                    if (!alreadyInList) {
                        filesToAdd.Add(file);
                    }
                }
                FillListView();
            } else {
                // Nothing selected
            }
        }

        private void btnRemoveFile_Click(object sender, EventArgs e) {
            if (filesToAdd == null || filesToAdd.Count == 0) return; // Don't prompt if list empty

            string prompt = "Select a file to remove from the list.";
            bool isSelected = ForceSingleSelection(prompt);
            if (!isSelected) return;

            var selectedRow = AddFilelistView.SelectedItems[0];
            filesToAdd.Remove(selectedRow.Tag.ToString());
            FillListView();
        }

        private bool ForceSingleSelection(string prompt) {
            bool isSelected = (AddFilelistView.SelectedItems.Count == 1);
            if (isSelected) return true;
            Messenger.Show(prompt, caption);
            return false;
        }
    }
}
