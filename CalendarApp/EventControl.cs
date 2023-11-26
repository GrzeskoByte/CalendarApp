using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp
{
    public partial class EventControl : UserControl
    {
        Event Event { get; set; }
       
        public EventControl(Event eventObject)
        {
            InitializeComponent();
            Event = eventObject;
        }

        private void EventControl_Load(object sender, EventArgs e)
        {
            eventTitle.Text = Event.title;
            eventDesc.Text = Event.description;
        }

        private void removeEventBtn_Click(object sender, EventArgs e)
        {
            EventsDAO eventsDAO = new EventsDAO();
            eventsDAO.RemoveEvent(Event.id);
     
        }

        private void EventControl_Click(object sender, EventArgs e)
        {

        }

        private void editEventBtn(object sender, EventArgs e)
        {
           EventForm eventForm = new EventForm(Event);
           eventForm.ShowDialog();
        
        }
    }
}
