using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestiuneFilmBilete1.bl;

namespace gestiuneFilmBilete1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //login
        {
            if (this.usernameTextBox.Text.Contains("Adm"))
            {
                //verific daca e in db
                UserService us = new UserService();
                us.LoginBl(usernameTextBox.Text, passwordTextBox.Text);
                AdminForm resForm = new AdminForm();
                resForm.Show();
            }
            else if (this.usernameTextBox.Text.Contains("Usr"))
            {
                EmployeeForm resForm = new EmployeeForm();
                resForm.Show();
            }
        }
    }
}
