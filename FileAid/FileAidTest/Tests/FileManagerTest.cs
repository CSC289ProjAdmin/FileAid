using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FileAid.Models;

namespace FileAidTest.Tests {
    [TestClass]
    public class FileManagerTest {
        [TestMethod]
        public void GetFilesTest() {
            // Add 2 test files
            FileManager.AddFile("Test File 1", "test", "test", 1000, DateTime.Now, DateTime.Now);
            FileManager.AddFile("Test File 2", "test", "test", 1000, DateTime.Now, DateTime.Now);

            // Get all files
            List<TrackedFile> trackedFiles = FileManager.GetFiles();

            // Verify there are least two files
            Assert.IsTrue(trackedFiles.Count > 2);
     
        }

        [TestMethod]
        public void GetFileTest()
        {
            // Add a test file so at least one trakced file exists
            FileManager.AddFile("Test File", "test", "test", 1000, DateTime.Now, DateTime.Now);

            // Get all files
            List<TrackedFile> trackedFiles = FileManager.GetFiles();

            // Verify there is at least one file
            Assert.IsNotNull(trackedFiles);

            // Store some data for one of the files
            int fileId = trackedFiles[0].FileID;
            string fileName = trackedFiles[0].Filename;
            string fileMemo = trackedFiles[0].FileMemo;

            // Get a file by the file id
            TrackedFile file = FileManager.GetFile(fileId);

            // Verify the expected file was returned
            Assert.IsNotNull(file);
            Assert.AreEqual(fileName, file.Filename);
            Assert.AreEqual(fileMemo, file.FileMemo);

        }

        [TestMethod]
        public void AddFilesTest() {

            int fileCount = 0;

            // Add default file and get file count
            FileManager.AddFile("Test add file", "test", "test", 1000, DateTime.Now, DateTime.Now);
            List<TrackedFile> fileList = FileManager.GetFiles();
            fileCount = fileList.Count;

            // Add file without memo
            FileManager.AddFile("Test add file without memo", "test", "test", 1000, DateTime.Now, DateTime.Now);

            // Verify the file was added
            fileList = FileManager.GetFiles();
            Assert.AreEqual(fileCount + 1, fileList.Count);

            //Add file with memo
            FileManager.AddFile("Test add file with memo", "test", "test", 1000, DateTime.Now, DateTime.Now, "Description for added file");
            fileList = FileManager.GetFiles();
            Assert.AreEqual(fileCount + 2, fileList.Count);
        }
    }
}
