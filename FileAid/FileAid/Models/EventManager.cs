using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAid.Models {
    public static class EventManager {
        public static List<Event> GetEvents() {
            List<Event> allEvents = DAL.EventManagerDAL.GetEvents();
            return allEvents;
        }

        public static Event GetEvent(int eventID) {
            Event specific = DAL.EventManagerDAL.GetEvent(eventID);
            return specific;
        }

        public static bool DeleteEventHistory() {
            bool wasDeleted = DAL.EventManagerDAL.DeleteEventHistory();
            return wasDeleted;
        }
    }
}
