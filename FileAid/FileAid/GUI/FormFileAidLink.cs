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

namespace FileAid.GUI
{
    public partial class FormFileAidLink : Form
    {
        private string caption = "FileAid File Linking";
        private List<int> selectedIDs;
        private List<TrackedFile> filesToLink;
        public FormFileAidLink(List<int> fileIDs)
        {
            InitializeComponent();
            selectedIDs = fileIDs;
            filesToLink = new List<TrackedFile>();
        }

        private void FillListView() {
            if (selectedIDs == null) return; // No files to group

            try {
                AddLinklistView.Items.Clear();
                filesToLink.Clear();
                foreach (int id in selectedIDs) {
                    TrackedFile tf = FileManager.GetFile(id);
                    if (tf == null) continue;
                    filesToLink.Add(tf);
                }
                if (filesToLink.Count == 0) return; // No files found

                foreach (var file in filesToLink) {
                    string[] fileDetails = new string[6];
                    fileDetails[0] = file.Filename;
                    fileDetails[1] = file.FileExtension;
                    fileDetails[2] = file.FilePath;
                    fileDetails[3] = file.FileSize.ToString();
                    fileDetails[4] = file.ModifiedOn.ToString();
                    fileDetails[5] = (file.TrackingDisabledOn > new DateTime()) ? "X" : "";
                    ListViewItem row = new ListViewItem(fileDetails);
                    row.Tag = file.FileID;
                    AddLinklistView.Items.Add(row);
                }
            }
            catch (SqlException) {
                Messenger.ShowDbMsg();
            }
        }

        private void FormFileAidLink_Load(object sender, EventArgs e)
        {
            AddLinktoolTip.SetToolTip(txtLinkMemo, "Enter the memo");
            AddLinktoolTip.SetToolTip(btnAddLink, "Add link");
            AddLinktoolTip.SetToolTip(btnCancelLink, "Cancel file link");

            FillListView();
        }

        private void btnCancelLink_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnAddLink_Click(object sender, EventArgs e) {
            if (filesToLink.Count < 2) return; // Need 2+ files to link

            List<int> memberIDs = new List<int>();
            foreach (var file in filesToLink) {
                memberIDs.Add(file.FileID);
            }

            if (memberIDs.Count < 2) return; // Just in case

            string linkMemo = txtLinkMemo.Text.Trim();
            FileLink newLink = null;
            if (string.IsNullOrEmpty(linkMemo)) {
                newLink = LinkManager.AddLink(memberIDs);
            } else {
                newLink = LinkManager.AddLink(memberIDs, linkMemo);
            }
            if (newLink == null) return; // Didn't create

            // Log link creation
            LogLinkCreation(newLink.LinkMemoID, memberIDs.Count, linkMemo);
            LogLinkJoined(newLink, newLink.GetFiles());
            Messenger.Show($"New link created between the {memberIDs.Count} files.", caption);
            DialogResult = DialogResult.OK;
            Close();
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
                    (string.IsNullOrEmpty(link.LinkMemo) ? "unnamed file group"  : $"file group: {link.LinkMemo}");
                bool wasJoined = Logger.Log(ev);
                if (wasJoined) nJoined++;
            }
            return nJoined;
        }
    }
}
