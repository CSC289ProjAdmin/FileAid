using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FileAid.Models;

namespace FileAidTest.Tests {
    [TestClass]
    public class LinkManagerTest {
        [TestMethod]
        public void GetLinksTest() {

            // Add link
            LinkManager.AddLink(new List<int> { 1 }, "Test Get Links");

            // Get all links
            List<FileLink> linkList = LinkManager.GetLinks();

            // Verify there is at least one link
            Assert.IsNotNull(linkList);

        }

        [TestMethod]
        public void GetLinkTest() {

            // Add link
            LinkManager.AddLink(new List<int> { 1 }, "Test Get Link");

            // Get all links
            List<FileLink> linkList = LinkManager.GetLinks();

            // Verify there is at least one link
            Assert.IsNotNull(linkList);

            // Store some data for one of the files
            int linkId = linkList[0].LinkMemoID;
            string linkMemo = linkList[0].LinkMemo;

            // Get file link by id
            FileLink link = LinkManager.GetLink(linkId);

            // Verify the expected link was returned
            Assert.IsNotNull(link);
        }

        [TestMethod]
        public void AddLinkTest() {

            int linkCount = 0;

            LinkManager.AddLink(new List<int> { 1 }, "Test Add Link");
            List<FileLink> linkList = LinkManager.GetLinks();
            linkCount = linkList.Count;

            // Add Link
            LinkManager.AddLink(new List<int> { 1 }, "Test Add Link");

            // Verify the link was added
            linkList = LinkManager.GetLinks();
            Assert.AreEqual(linkCount + 1, linkList.Count);
        }
    }
}
