﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CalendarApp.Properties;

namespace CalendarApp
{
    public partial class DayControl : UserControl
    {
        FlowLayoutPanel eventsList;
        int month, year, day;
        public DayControl(FlowLayoutPanel eventsListRef, int currentMonth, int currentYear)
        {
            InitializeComponent();
            eventsList = eventsListRef;
            month= currentMonth; year= currentYear;
        }

        private void lbDays_Load(object sender, EventArgs e)
        {
            
        }

  

        public void days(int numday)
        {
            daysLabel.Text = numday.ToString();
            day = numday;
        }

        private void DayControl_Click(object sender, EventArgs e)
        {
            eventsList.Controls.Clear();

            EventsDAO eventsDAO = new EventsDAO();
            
            List<Event> events  = eventsDAO.GetEventsFromDay(new DateTime(year,month,day));
   
            foreach(Event eventObject in events)
            {
                eventsList.Controls.Add(new EventControl(eventObject));
            }

        }
    }
}
