using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//SQLconnection
using System.Windows.Forms; //MessageBox
using gestiuneFilmBilete1.model;
using System.Globalization;
using System.Data;

namespace gestiuneFilmBilete1.dao
{
    class FilmDAO
    {
        private String connectionString = @"Data Source=DESKTOP-COSMI\SQLEXPRESS;Initial Catalog=tema1;Trusted_Connection=Yes;";
        SqlConnection conn = null;

        public FilmDAO()
        {
            try
            {
                conn = new SqlConnection(connectionString);
            }
            catch (SqlException e)
            {
                //de facut ceva error handling, afisat mesaj, etc..
                switch (e.Number)
                {
                    case 2601:
                        // Do something.
                        MessageBox.Show("Not connected!");
                        Console.WriteLine(e.Message);

                        break;
                    default:
                        throw;
                }

                conn = null;

            }
        }
        public Film GetFilm(String title)
        {
            // String production, String distribution, DateTime premiereDate, int hour, DateTime deadline, int tickets
            Film f = null;
            String sql = "SELECT * FROM films WHERE title='" +title +"'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                String datePattern = "yyyy-MM-dd ";  //2018-12-30 year month day
                DateTime premiereDate, deadLine;
                DateTime.TryParseExact(reader["premiereDate"].ToString(), datePattern, null, DateTimeStyles.None, out premiereDate);
                DateTime.TryParseExact(reader["deadline"].ToString(), datePattern, null, DateTimeStyles.None, out deadLine);

                String scheduledHour = reader["scheduledHour"].ToString();
                int hour = int.Parse(scheduledHour);

                String noOfTicketsSTr = reader["tickets"].ToString();
                int noOfTickets = int.Parse(noOfTicketsSTr);

                f = new Film(reader["title"].ToString(),reader["production"].ToString(), reader["distribution"].ToString(), premiereDate, hour, deadLine, noOfTickets);
                conn.Close();

                Console.WriteLine(f.ToString());
                MessageBox.Show("Filmul este afisat in consola!");
                return f;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Filmul nu exista in baza de date!");
                Console.WriteLine(e.Message);
                return null;
            }

        }

        public void InsertFilm(String title, String production, String distribution, DateTime premiereDate, int hour, DateTime deadline, int tickets)
        {
            String sql = "INSERT INTO films (title, production, distribution, premiereDate, scheduledHour, deadline, tickets) VALUES (@val1, @val2, @val3, @val4, @val5, @val6, @val7)";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@val1", title);
                cmd.Parameters.AddWithValue("@val2", production);
                cmd.Parameters.AddWithValue("@val3", distribution);

                string sqlTimeAsString = premiereDate.ToString("yyyy-MM-ddTHH:mm:ss.fff");
                cmd.Parameters.AddWithValue("@val4", sqlTimeAsString);
                cmd.Parameters.AddWithValue("@val5", hour);

                string sqlTimeAsString1 = deadline.ToString("yyyy-MM-ddTHH:mm:ss.fff");
                cmd.Parameters.AddWithValue("@val6", sqlTimeAsString1);

                cmd.Parameters.AddWithValue("@val7", tickets);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Adaugare cu succes!");

            }
            catch (SqlException e)
            {
                MessageBox.Show("Adaugare fara succes!");

                Console.WriteLine(e.Message);
            }
        }

        public void DeleteFilm(String title)
        {
            String sql = "DELETE FROM films WHERE title=@val";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@val", title);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Stergere cu succes!");


            }
            catch (SqlException e)
            {
                MessageBox.Show("Stergere esuata!");
                Console.WriteLine(e.Message);
            }

        }

        public void UpdateFilm(String title, String production, String distribution, DateTime premiereDate, int hour, DateTime deadline, int tickets)
        {
            String sql = "UPDATE films SET production = @val2, distribution = @val3, premiereDate=@val4, scheduledHour=@val5, deadline=@val6, tickets=@val7 WHERE title=@title";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                //cmd.Parameters.Add("@Id", SqlDbType.String).Value = title;
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@val2", production);
                cmd.Parameters.AddWithValue("@val3", distribution);

                string sqlTimeAsString = premiereDate.ToString("yyyy-MM-ddTHH:mm:ss.fff");
                cmd.Parameters.AddWithValue("@val4", sqlTimeAsString);

                cmd.Parameters.AddWithValue("@val5", hour);

                string sqlTimeAsString1 = deadline.ToString("yyyy-MM-ddTHH:mm:ss.fff");
                cmd.Parameters.AddWithValue("@val6", sqlTimeAsString1);
                
                cmd.Parameters.AddWithValue("@val7", tickets);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Update cu succes!");

            }
            catch (SqlException e)
            {
                MessageBox.Show("Filmul nu exista in baza de date!");

                Console.WriteLine(e.Message);
            }
        }

        public List<Film> FindAll()
        {
            List<Film> films = new List<Film>();
            String sql = "SELECT * FROM films";
            Film f = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read() == true)
                {
                    String datePattern = "yyyy-MM-dd ";  //2018-12-30 year month day
                    DateTime premiereDate, deadLine;
                    DateTime.TryParseExact(reader["premiereDate"].ToString(), datePattern, null, DateTimeStyles.None, out premiereDate);
                    DateTime.TryParseExact(reader["deadline"].ToString(), datePattern, null, DateTimeStyles.None, out deadLine);

                    String scheduledHour = reader["scheduledHour"].ToString();
                    int hour = int.Parse(scheduledHour);

                    String tickets = reader["tickets"].ToString();
                    int noOfTickets = int.Parse(tickets);

                    f = new Film(reader["title"].ToString(), reader["production"].ToString(), reader["distribution"].ToString(), premiereDate, hour, deadLine, noOfTickets);
                    films.Add(f);
                }

                foreach (Film fi in films)
                {
                    Console.WriteLine("Film=" + fi.ToString());
                }
                conn.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

            return films;
        }
    }
}
