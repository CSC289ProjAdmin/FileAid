using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileAid.Models {
    public static class Logger {
        public static bool Log(Event e) {
            return LogToDb(e);
        }

        public static bool LogToDb(Event e) {
            bool wasWritten = DAL.LoggerDAL.LogToDb(e);
            return wasWritten;
        }

        public static bool LogToFile(Event e, string logfile) {
            bool wasWritten = false;
            using (StreamWriter w = File.AppendText(logfile)) {
                w.WriteLine($"{DateTime.Now.ToString()}: {e.Description}");
                wasWritten = true;
            }
            return wasWritten;
        }
    }
}
