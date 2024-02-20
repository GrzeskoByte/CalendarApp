using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RestSharp;

using Newtonsoft.Json;
using System.IO;

namespace CalendarApp
{
    internal class EventsDAO
    {
        private string jsonFilePath = "events.json";
 
        public List<Event> GetEventsFromDay(DateTime date)
        {
    
            List<Event> events = LoadFromJsonFile(jsonFilePath);
            List<Event> filteredEvents = events.FindAll(e => e.date.Date == date.Date);

            return filteredEvents;
       
        }

        public void ExportToCSV()
        {
            List<Event> events = LoadFromJsonFile(jsonFilePath);
            string filePath = "exported_data.csv";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Title,Description,Date,Users_id");

                foreach (Event eventData in events)
                {
                    writer.WriteLine($"{eventData.title},{eventData.description},{eventData.date},{eventData.users_id}");
                }

                MessageBox.Show("Dane zostały pomyślnie wyeksportowane do pliku CSV.", "Eksport zakończony", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = "exported_data.csv";
                saveFileDialog.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(filePath, saveFileDialog.FileName, true);
             
                }
            }


        }

        public void AddEvent(string title, string description, DateTime date)
        {

            List<Event> events = LoadFromJsonFile(jsonFilePath);

            events.Add(new Event
            {
                id  = GetNextEventId(events),
                title = title,
                description = description,
                date = date,
                users_id = 1,
            });

            SaveToJsonFile(events, jsonFilePath);

        }

        private int GetNextEventId (List<Event> events)
        {
            if (events.Count > 0)
            {
                return events.Max(e => e.id) + 1;
            }
            else
            {
                return 1;
            }
        }

        static void SaveToJsonFile(List<Event> data, string filePath)
        {   
            string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }

        static List<Event> LoadFromJsonFile (string filePath)
        {
        
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<Event>>(jsonData);
            }else
            {
                List<Event> emptyEvent= new List<Event>();
                SaveToJsonFile(emptyEvent, filePath);
                return emptyEvent;
            }
        }

        public void RemoveEvent(int id)
        {
            List<Event> events = LoadFromJsonFile(jsonFilePath);

            events.RemoveAll(e => e.id == id);

            SaveToJsonFile(events, jsonFilePath);

            MessageBox.Show("Removed");
        }

        public  void UpdateEvent(Event eventObject)
        {
            List<Event> events = LoadFromJsonFile(jsonFilePath);

   
            int index = events.FindIndex(e => e.id == eventObject.id);

            if (index != -1)
            {
                events[index] = eventObject;
                SaveToJsonFile(events,jsonFilePath);
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Event not found");
            }
        }
}}
