using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileAid.Models;
using System.Data.SqlClient;

namespace FileAid.DAL {
    public static class EventManagerDAL {
        public static List<Event> GetEvents() {
            string select = "Select EventID, EventTypeID, dEvent As OccurredOn, " +
                "sEventDescription As Description, sInitial As Initial, sNew As New, " +
                "FileID, LinkID, ReportID, ReminderID, BatchID, UserID, LoginID, PermID, ConfigID " +
                "From Events Where dEventDeleted Is Null Order By dEvent Desc;";
            return Db.ReadQuery<Event>(select);
        }

        public static Event GetEvent(int eventID) {
            if (eventID <= 0) return null;
            List<SqlParameter> args = new List<SqlParameter>();
            args.Add(new SqlParameter("@EventID", eventID));
            string select = "Select EventID, EventTypeID, dEvent As OccurredOn, " +
                "sEventDescription As Description, sInitial As Initial, sNew As New, " +
                "FileID, LinkID, ReportID, ReminderID, BatchID, UserID, LoginID, PermID, ConfigID " +
                "From Events Where dEventDeleted Is Null And EventID = @EventID;";
            List<Event> results = Db.ReadQuery<Event>(select, args.ToArray());
            if (results != null) {
                return results[0];
            } else {
                return null;
            }
        }
    }
}
