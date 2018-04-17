using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FileAid.Models;

namespace FileAidTest.Tests {
    [TestClass]
    public class EventManagerTest {
        [TestMethod]
        public void GetEventsTest()
        {
            // Test Parameters
            int eventsCount = 0;

            // Get current events
            List<Event> events = EventManager.GetEvents();
            eventsCount = events == null ? 0 : events.Count;

            // Get current directory. Remove bin\Debug from path. Add Tests\Files to path
            string path = Environment.CurrentDirectory;
            path = path.Replace("bin\\Debug", "") + "Tests\\TestFiles";

            // Scan for files in the test file folder
            BatchManager.Scan(path, false);

            // Get events after scan
            events = EventManager.GetEvents();

            // Verify events were generated
            Assert.IsTrue(eventsCount < events.Count);

        }

        [TestMethod]
        public void GetEventTest()
        {
            // Get current directory. Remove bin\Debug from path. Add Tests\Files to path
            string path = Environment.CurrentDirectory;
            path = path.Replace("bin\\Debug", "") + "Tests\\TestFiles";

            // Scan for files in the test file folder
            BatchManager.Scan(path, false);

            // Get events after scan
            List<Event> events = EventManager.GetEvents();

            // Verify events were generated
            Assert.IsNotNull(events);

            // Get an event by an event Id
            Event ev = EventManager.GetEvent(events[0].EventID);

            // Verify an event was returned with the current event id
            Assert.IsNotNull(ev);
            Assert.AreEqual(events[0].EventID, ev.EventID);

        }

        [TestMethod]
        public void DeleteEventHistoryTest()
        {
            // Get current directory. Remove bin\Debug from path. Add Tests\Files to path
            string path = Environment.CurrentDirectory;
            path = path.Replace("bin\\Debug", "") + "Tests\\Files";

            // Scan for files in the test file folder
            BatchManager.Scan(path, false);

            // Get events after scan
            List<Event> events = EventManager.GetEvents();

            // Verify events were generated
            Assert.IsNotNull(events);

            // Delete event history
            EventManager.DeleteEventHistory();

            // Get events after delete
            events = EventManager.GetEvents();

            // Verify the event history was deleted
            Assert.IsNull(events);
        }
    }
}
