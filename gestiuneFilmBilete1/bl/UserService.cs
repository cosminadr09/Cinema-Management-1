using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestiuneFilmBilete1.dao;
using gestiuneFilmBilete1.model;
using System.Security.Cryptography;//MD5
using System.Windows.Forms; //MessageBox



namespace gestiuneFilmBilete1.bl
{
    class UserService
    {
        private UserDAO udao;

        public UserService()
        {
        }

        public void CreateAccountBl(String name, String username, String pass)
        {
            udao = UserDAO.GetInstance(); //newUserDAO

            udao.InsertUser(name,username,GetMd5Hash(pass));//inseram cu parola criptata
        }

        public void LoginBl(String username, String pass)
        {
        
            Console.WriteLine("Parola=" + GetMd5Hash(pass));
            udao = UserDAO.GetInstance(); //newUserDAO
            User u = udao.GetUser(username, GetMd5Hash(pass));//in db parola e deja criptata
            if (u != null)
            {
                MessageBox.Show("Logare cu succes");

            }
            else
            {
                MessageBox.Show("Logare esuata");
            }
        }

     /*   public void ChangePasswordBl(String pass)
        {
            udao = UserDAO.GetInstance(); //newUserDAO
            udao.UpdateUser(GetMd5Hash(pass));
        }*/

        public static string GetMd5Hash(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
