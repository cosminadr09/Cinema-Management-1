using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//SQLconnection
using System.Windows.Forms; //MessageBox
using gestiuneFilmBilete1.model;

namespace gestiuneFilmBilete1.dao
{
    class TicketDAO
    {
        private String connectionString = @"Data Source=DESKTOP-COSMI\SQLEXPRESS;Initial Catalog=tema1;Trusted_Connection=Yes;";
        SqlConnection conn = null;
        public object[] GridRow { get; private set; }

        public TicketDAO()
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

        public void InsertTicket(int noTickets, String title, int row, int seat, DateTime date)
        {
            String sql = "INSERT INTO tickets (film, row, seat, date) VALUES (@val1, @val2, @val3, @val4)";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@val1", title);
                cmd.Parameters.AddWithValue("@val2", row);
                cmd.Parameters.AddWithValue("@val3", seat);

                string sqlTimeAsString1 = date.ToString("yyyy-MM-ddTHH:mm:ss.fff");
                cmd.Parameters.AddWithValue("@val4", sqlTimeAsString1);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Adaugare cu succes!");

            }
            catch (SqlException e)
            {
                MessageBox.Show("Adaugare fara succes!");

                Console.WriteLine(e.Message);
            }
        }

   /*     public string GetTitle(String title)
        {
            String sqltitle = "SELECT * FROM films WHERE title=" + title + "'";
            string theTitle;
            try
            {
                conn.Open();

                SqlCommand cmdtitle = new SqlCommand(sqltitle, conn);
                SqlDataReader reader = cmdtitle.ExecuteReader();
                reader.Read();
                theTitle = reader["title"].ToString();
                conn.Close();
                return theTitle;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Adaugare titlu fara succes!");

                Console.WriteLine(e.Message);
                return null;
            }
            
        }

        public void InsertTicketFilm(int noTickets, String title, int row, int seat, DateTime date)
        {
            String sql = "INSERT INTO tickets (film, row, seat, date) VALUES ( @val1, @val2, @val3, @val4)";


            try { 

                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@val1", title);
                cmd.Parameters.AddWithValue("@val2", row);
                cmd.Parameters.AddWithValue("@val3", seat);

                string sqlTimeAsString1 = date.ToString("yyyy-MM-ddTHH:mm:ss.fff");
                cmd.Parameters.AddWithValue("@val4", sqlTimeAsString1);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Adaugare cu succes!");

            }
            catch (SqlException e)
            {
                MessageBox.Show("Adaugare fara succes!");

                Console.WriteLine(e.Message);
            }
        }*/

        public List<Ticket> FindAll()
        {
            List<Ticket> tickets = new List<Ticket>();
            String sql = "SELECT * FROM tickets";
            Ticket t = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
       
                while (reader.Read() == true)
                {
                    String rowstr = reader["row"].ToString();
                    int row = int.Parse(rowstr);

                    String seatstr = reader["seat"].ToString();
                    int seat = int.Parse(seatstr);

                    String datePattern = "yyyy-MM-dd ";  //2018-12-30 year month day
                    DateTime date;
                    DateTime.TryParseExact(reader["date"].ToString(), datePattern, null, System.Globalization.DateTimeStyles.None, out date);
                    t = new Ticket(reader["film"].ToString(), row, seat, date);
                    
                    tickets.Add(t);
                   
                }

                foreach(Ticket ti in tickets)
                {
                    Console.WriteLine("Ticket=" +ti.ToString());
                }
                conn.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

            return tickets;
        }

    
    }
}
