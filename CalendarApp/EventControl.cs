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
        Action Repaint;
        Action<string,string,DateTime> Set_Current_Item_View;
        public EventControl(Event eventObject , Action Repaint_component, Action<string,string,DateTime> set_current_item_view)
        {
            InitializeComponent();
            Event = eventObject;
            Repaint = Repaint_component;
            Set_Current_Item_View = set_current_item_view; 
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
            Repaint();

        }

        private void EventControl_Click(object sender, EventArgs e)
        {
            Set_Current_Item_View(Event.title, Event.description, Event.date);
        }

        private void editEventBtn(object sender, EventArgs e)
        {
           EventForm eventForm = new EventForm(Event, Repaint);
           eventForm.ShowDialog();
        
        }
    }
}
