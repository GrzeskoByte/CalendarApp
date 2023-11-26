using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace CalendarApp
{
     public class Event
    {
        public int id { get; set; }
        public String title {  get; set; }
        public String description {  get; set; }
        public DateTime date { get; set; }
        public int users_id { get; set; }

        public Event()  
        { }
           

        



    }
}
