using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileAid.Models;

namespace FileAid.GUI {
    public partial class FormFileAidRptLogins : Form {
        public FormFileAidRptLogins() {
            InitializeComponent();
        }

        private void FormFileAidRptLogins_Load(object sender, EventArgs e) {
            List<Event> allEvents = EventManager.GetEvents();
            if (allEvents == null) return;


            List<EventTypes> loginEvents = new List<EventTypes>();
            loginEvents.Add(EventTypes.LoginFailure);
            loginEvents.Add(EventTypes.LoginSuccess);

            var filteredEvents = from ev in allEvents
                                 where loginEvents.Contains(ev.EventTypeID)
                                 select ev;

            if (filteredEvents == null) return;

            BindingList < LoginsReport > myLogins = new BindingList<LoginsReport>();
            foreach (Event ev in filteredEvents) {
                LoginsReport rptItem = new LoginsReport();
                rptItem.Date = ev.OccurredOn.ToString();
                rptItem.EventDescription = ev.Description;
                myLogins.Add(rptItem);
            }

            this.reportViewer1.RefreshReport();
        }
    }

    public class LoginsReport : Report {
        public string Date { get; set; }
        public string EventDescription { get; set; }
    }
}
