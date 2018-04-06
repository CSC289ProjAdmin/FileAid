using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FileAid.Models;
using FileAid.DAL;

namespace FileAidTest.Tests {
    [TestClass]
    public class FileLinkTest {
        [TestMethod]
        public void GetFilesTest()
        {
            // Get file link for link memo id = 1
            int linkMemoId = 1;
            FileLink fl = LinkManager.GetLink(linkMemoId);

            // Get the files for file link
            List<TrackedFile> files = fl.GetFiles();

            // Verify at least one file is returned
            Assert.IsNotNull(files);
        }

        [TestMethod]
        public void JoinTest()
        {
            // Get file link for link memo id = 1
            int linkMemoId = 1;
            FileLink fl = LinkManager.GetLink(linkMemoId);

            // Get the files for file link
            List<TrackedFile> linkedFiles = fl.GetFiles();

            // Verify at least one file is returned
            Assert.IsNotNull(linkedFiles);

            // Get all files
            List<TrackedFile> allFiles = FileManagerDAL.GetFiles();

            // Find a file not in the MemoId = 1 list
            TrackedFile joinFile = null;

            // Get a list of the file IDs of the linked files
            List<int> linkedFileIDs = new List<int>();            
            foreach(var file in linkedFiles)
            {
                linkedFileIDs.Add(file.FileID);
            }            

            // 
            foreach(var file in allFiles)
            {
                if(!linkedFileIDs.Contains(file.FileID))
                {
                    joinFile = file;
                    break;
                }
            }
            
            // Join file if we have found one
            if(joinFile != null)
            {
                // Join file
                fl.Join(joinFile.FileID);

                // Reteieve file list
                linkedFiles = fl.GetFiles();

                // Fill linedFileIDs with new file ID list
                linkedFileIDs.Clear();
                foreach (var file in linkedFiles)
                {
                    linkedFileIDs.Add(file.FileID);
                }

                // Verify joined file exists in the list
                Assert.IsTrue(linkedFileIDs.Contains(joinFile.FileID));

                // Remove joined file
                fl.RemoveFiles(new List<int> { joinFile.FileID});
            }
        }

        [TestMethod]
        public void UpdateMemoTest()
        {
            // Test Parameters
            string updatedMemo = "Updated memo for UpdateMemoTest";
            int linkMemoId = 1;

            FileLink fl = LinkManager.GetLink(linkMemoId);

            // Get memo value
            string initialMemo = fl.LinkMemo;

            // Remove memo
            fl.RemoveMemo();
            Assert.AreEqual("", fl.LinkMemo);

            // Update Memo to test value
            fl.UpdateMemo(updatedMemo);
            Assert.AreEqual(updatedMemo, fl.LinkMemo);

            // Restore initial memo value
            fl.UpdateMemo(initialMemo);
            Assert.AreEqual(initialMemo, fl.LinkMemo);

        }

        [TestMethod]
        public void RemoveMemoTest()
        {
            // Test Parameters
            int linkMemoId = 1;

            FileLink fl = LinkManager.GetLink(linkMemoId);

            // Get memo value
            string initialMemo = fl.LinkMemo;

            // Remove memo
            fl.RemoveMemo();
            Assert.AreEqual("", fl.LinkMemo);

            // Restore initial memo value
            fl.UpdateMemo(initialMemo);
            Assert.AreEqual(initialMemo, fl.LinkMemo);

        }

        [TestMethod]
        public void RemoveFilesTest()
        {
            // Get file link for link memo id = 1
            int linkMemoId = 1;
            FileLink fl = LinkManager.GetLink(linkMemoId);

            // Get the files for file link
            List<TrackedFile> linkedFiles = fl.GetFiles();

            // Verify at least one file is returned
            Assert.IsNotNull(linkedFiles);

            // Get all files
            List<TrackedFile> allFiles = FileManagerDAL.GetFiles();

            // Find a file not in the MemoId = 1 list
            TrackedFile joinFile = null;

            // Get a list of the file IDs of the linked files
            List<int> linkedFileIDs = new List<int>();
            foreach (var file in linkedFiles)
            {
                linkedFileIDs.Add(file.FileID);
            }

            // 
            foreach (var file in allFiles)
            {
                if (!linkedFileIDs.Contains(file.FileID))
                {
                    joinFile = file;
                    break;
                }
            }

            // Join file if we have found one
            if (joinFile != null)
            {
                // Join file
                fl.Join(joinFile.FileID);

                // Reteieve file list
                linkedFiles = fl.GetFiles();

                // Fill linkedFileIDs with new file ID list
                linkedFileIDs.Clear();
                foreach (var file in linkedFiles)
                {
                    linkedFileIDs.Add(file.FileID);
                }

                // Verify joined file exists in the list
                Assert.IsTrue(linkedFileIDs.Contains(joinFile.FileID));

                // Remove joined file
                fl.RemoveFiles(new List<int> { joinFile.FileID });

                // Fill linkedFileIDs with new file ID list
                linkedFiles = fl.GetFiles();
                linkedFileIDs.Clear();
                foreach (var file in linkedFiles)
                {
                    linkedFileIDs.Add(file.FileID);
                }

                // Verify the file was removed
                Assert.IsFalse(linkedFileIDs.Contains(joinFile.FileID));

            }
        }
    }
}
