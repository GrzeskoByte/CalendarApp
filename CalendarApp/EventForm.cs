﻿using System;
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
        Action Repaint;
        string action;

        public EventForm()
        {
            InitializeComponent();
            action = "add_blank";
        }
        public EventForm(Action Repaint_Component)
        {
            InitializeComponent();
            Repaint = Repaint_Component;
            action = "add";
        }

        public EventForm(Event eventObject ,Action Repaint_Component)
        {
            InitializeComponent();
            Repaint = Repaint_Component;
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
            DayOfWeek dayOfTheWeek = date.DayOfWeek;



            EventsDAO eventsDAO = new EventsDAO();

            eventsDAO.AddEvent(title,description, date);

            if (checkBox1.Checked)
            {
                for(int i = 0; i < 4; i++)
                {
                    DateTime newDate = date.AddDays(7*(i+1));
                    eventsDAO.AddEvent(title, description,newDate);
                }
            }

            if(action == "add")
            {
                Repaint();
            }

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
            Repaint();

            this.Close();
        }

      
    }
}
