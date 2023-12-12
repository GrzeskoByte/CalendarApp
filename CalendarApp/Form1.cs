using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalendarApp.Properties;


namespace CalendarApp
{
    public partial class Form1 : Form
    {
        private int month, year;
        private List<Event> currentEvents { get; set; }

        private EventForm eventForm;

        public Form1()
        {
            InitializeComponent();

            this.Text = Settings.Default["Title"].ToString();
            Settings.Default["deviceToken"] = GenerateDeviceToken(GetMacAddress());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public static string GetMacAddress()
        {
  
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            if (networkInterfaces.Length > 0)
            {
                return networkInterfaces[0].GetPhysicalAddress().ToString();
            }

            return string.Empty;
        }

        public static string GenerateDeviceToken(string macAddress)
        {
            string combinedData = macAddress;


            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(combinedData));


                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            daysContainer.Controls.Clear();

            if(month + 1 > 12)
            {
                year++;
                month = 1;
            }else
            {
                month++;
            }


            Display_Days();

        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            daysContainer.Controls.Clear();

            if (month - 1  < 1)
            {
                year--;
                month = 12;
            }
            else
            {
                month--;
            }


            Display_Days();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            month = now.Month;
            year = now.Year;

            Display_Days();

            
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void eventsList_Click(object sender, EventArgs e)
        {

        }

        private void eventsList_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void daysContainer_Paint(object sender, PaintEventArgs e)
        {

        }
       
      
      
        private void button1_Click(object sender, EventArgs e)
        {
            eventForm = new EventForm();
            eventForm.ShowDialog();
        }

        private void setCurrentItem(string title, string description , DateTime date)
        {
            currentEventTitle.Text = title;
            currentEventDescription.Text = description;
            currentEventDate.Text = date.ToString("yyyy.MM.dd");
        }
       

        private void Display_Days()
        {
            
            DateTime startOfTheMonth = new DateTime(year, month, 1);

            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            monthYearLabel.Text = monthName  + " " + year.ToString();

            int daysInTheCurrentMonth = DateTime.DaysInMonth(year, month);
            int daysOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));

            for(int i =1; i<daysOfTheWeek; i++)
            {
                BlankControl userControl1 = new BlankControl();
                daysContainer.Controls.Add(userControl1);
            }


            for(int i =1; i< daysInTheCurrentMonth; i++)
            {
                DayControl dayControl = new DayControl(eventsList, month, year , setCurrentItem);
                dayControl.days(i);

                daysContainer.Controls.Add(dayControl);
            }

        }
    }
}
