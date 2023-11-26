using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RestSharp;

namespace CalendarApp
{
    internal class EventsDAO
    { 

        private string connString = "server=127.0.0.1; port=3306; user=root; database=calendarapp; password=; convert zero datetime=True;";
    
        public List<Event> GetEventsFromDay(DateTime date)
        {

            List<Event> events = new List<Event>();

            MySqlConnection connection = new MySqlConnection(connString);

            string queryDate = date.ToString("yyyy.MM.dd");
    
            try{

            connection.Open();
               
            MySqlCommand command = new MySqlCommand("SELECT * FROM events WHERE date = '"+ queryDate +"';", connection);

            using (MySqlDataReader reader = command.ExecuteReader()){
                
                while (reader.Read())
                {
                    Event fetchedEvent = new Event
                    {
                        id = reader.GetInt32(0),
                        title = reader.GetString(1),
                        description = reader.GetString(2),
                        date = reader.GetDateTime(3),
                        users_id = reader.GetInt32(4)
                    };

                    events.Add(fetchedEvent);
                }
                    
            }
               
            connection.Close();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            
            return events;
        }

        public void AddEvent(string title, string description, DateTime date)
        {
            MySqlConnection connection = new MySqlConnection(connString);

            string queryDate = date.ToString("yyyy.MM.dd");


            try
            {

                connection.Open();

                MySqlCommand command = new MySqlCommand($"INSERT INTO `events`(`id`, `title`, `description`, `date`, `users_id`) VALUES ('','{title}','{description}','{queryDate}','1')", connection);

                command.ExecuteNonQuery();

                MessageBox.Show("Saved");

                command.Dispose();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void RemoveEvent(int id)
        {
            MySqlConnection connection = new MySqlConnection(connString);

    
            try
            {

                connection.Open();

                MySqlCommand command = new MySqlCommand($"DELETE FROM events WHERE id={id}", connection);

                command.ExecuteNonQuery();

                MessageBox.Show("Removed");

                command.Dispose();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public  void UpdateEvent(Event eventObject)
        {
            MySqlConnection connection = new MySqlConnection(connString);

            string queryDate = eventObject.date.ToString("yyyy.MM.dd");

            try
            {

                connection.Open();

                MySqlCommand command = new MySqlCommand($"UPDATE `events` SET `title`='{eventObject.title}',`description`='{eventObject.description}',`date`='{queryDate}',`users_id`='1' WHERE id ='{eventObject.id}'", connection);
              
                command.ExecuteNonQuery();

                MessageBox.Show("Updated");

                command.Dispose();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
