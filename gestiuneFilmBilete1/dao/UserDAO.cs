using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//SQLconnection
using System.Windows.Forms; //MessageBox
using gestiuneFilmBilete1.model;
using System.Collections;

namespace gestiuneFilmBilete1.dao
{
    class UserDAO
    {
        private static UserDAO userDAO = null;
        private String connectionString = @"Data Source=DESKTOP-COSMI\SQLEXPRESS;Initial Catalog=tema1;Trusted_Connection=Yes;";
        SqlConnection conn = null;

        private UserDAO()
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

        public static UserDAO GetInstance() //SINGLETON
        {
            if (userDAO == null)
            {
                userDAO = new UserDAO();
            }
            return userDAO;
        }

 


        public User GetUser(String username, String password)
        {
            User u = null;
            String sql = "SELECT * FROM users WHERE username='" + username + "' AND password='" + password + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                u = new User(reader["name"].ToString(), reader["username"].ToString(), reader["password"].ToString() );
                conn.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

            return u;
        }

        public void InsertUser(String name, String username, String password)
        {
            String sql = "INSERT INTO users (name,username,password) VALUES (@val1, @val2, @val3)";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@val1", name);
                cmd.Parameters.AddWithValue("@val2", username);
                cmd.Parameters.AddWithValue("@val3", password);
                cmd.ExecuteNonQuery();


            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }


        }

       
    }
}
