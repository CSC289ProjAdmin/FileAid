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

            BindingList < LoginEventReportItem> myLogins = new BindingList<LoginEventReportItem>();
            foreach (Event ev in filteredEvents) {
                LoginEventReportItem rptItem = new LoginEventReportItem();
                rptItem.Date = ev.OccurredOn.ToString();
                rptItem.LoginDescription = ev.Description;
                myLogins.Add(rptItem);
            }

            this.reportViewer1.RefreshReport();
        }
    }
    public class LoginEventReportItem : Report {
        public string Date { get; set; }
        public string LoginDescription { get; set; }
    }
}
