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
    public partial class EventForm : Form
    {
        Event eventToUpdate { get; set; }
        string action;
        
        public EventForm()
        {
            InitializeComponent();
        }
        public EventForm(Event eventObject)
        {
            InitializeComponent();
            eventToUpdate = eventObject;
            action = "update";
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            this.Text = "Add event";
            
            if(action == "update")
            {
                addEventTitleTextBox.Text = eventToUpdate.title;
                addEventDescriptionTextBox.Text = eventToUpdate.description;
                addEventDateTimePicker.Value = eventToUpdate.date;

                addEventBtn.Enabled = false;
                updateEventBtn.Enabled = true;
            }
            
        }

        private void addEventBtn_Click(object sender, EventArgs e)
        {
            string title = addEventTitleTextBox.Text;
            string description = addEventDescriptionTextBox.Text;
            DateTime date = addEventDateTimePicker.Value;

            EventsDAO eventsDAO = new EventsDAO();
            eventsDAO.AddEvent(title,description, date);

            this.Close();
        }

        private void cancelEventAddBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateEventBtn_Click(object sender, EventArgs e)
        {
            string title = addEventTitleTextBox.Text;
            string description = addEventDescriptionTextBox.Text;
            DateTime date = addEventDateTimePicker.Value;

            EventsDAO eventsDAO = new EventsDAO();

            eventToUpdate.title = title;
            eventToUpdate.description = description;
            eventToUpdate.date = date;

            eventsDAO.UpdateEvent(eventToUpdate);
            this.Close();
        }
    }
}
