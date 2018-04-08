using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using gestiuneFilmBilete1.bl;

namespace gestiuneFilmBilete1
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateFilmButton_Click(object sender, EventArgs e) 
        {
            String title = this.titleTextBox.Text;
            String production = this.productionTextBox.Text;
            String distribution = this.distributionTextBox.Text;

            String datePattern = "yyyy-MM-dd ";  //2018-12-30 year month day
            DateTime premiereDate, deadLine;
            DateTime.TryParseExact(this.premiereDateTextBox.Text, datePattern, null, DateTimeStyles.None, out premiereDate);
            DateTime.TryParseExact(this.deadlineTextBox.Text, datePattern, null, DateTimeStyles.None, out deadLine);

            //String hourPattern = "H"; //0-23
            String scheduledHour = this.scheduleDateTextBox.Text;
            int hour = int.Parse(scheduledHour);

            String noOfTicketsSTr = this.noOfTicketsTextBox.Text;
            int noOfTickets = int.Parse(noOfTicketsSTr);

            FilmService fs = new FilmService();
            fs.CreateFilmBl(title,production,distribution,premiereDate,hour,deadLine, noOfTickets);

        }

        private void CreateAccountButton_Click(object sender, EventArgs e) 
        {
            String name = this.newNameTextBox.Text;
            String username = this.newUsernameTextBox.Text;
            String pass = this.newPasswordTextBox.Text;

            UserService us = new UserService();
            us.CreateAccountBl(name, username, pass);

        }

        private void ViewListFilmButton_Click(object sender, EventArgs e)
        {
            ViewFilmsForm g = new ViewFilmsForm();
            g.Show();
            FilmService fs = new FilmService();
            fs.ViewListFilmBl();
        }

        private void UpdateFilmButton_Click(object sender, EventArgs e)
        {
            String title = this.titleTextBox.Text;
            String production = this.productionTextBox.Text;
            String distribution = this.distributionTextBox.Text;

            String datePattern = "yyyy-MM-dd ";  //2018-12-30 year month day
            DateTime premiereDate, deadLine;
            DateTime.TryParseExact(this.premiereDateTextBox.Text, datePattern, null, DateTimeStyles.None, out premiereDate);
            DateTime.TryParseExact(this.deadlineTextBox.Text, datePattern, null, DateTimeStyles.None, out deadLine);

            //String hourPattern = "H"; //0-23
            String scheduledHour = this.scheduleDateTextBox.Text;
            int hour = int.Parse(scheduledHour);

            String noOfTicketsSTr = this.noOfTicketsTextBox.Text;
            int noOfTickets = int.Parse(noOfTicketsSTr);

            FilmService fs = new FilmService();
            fs.UpdateFilmBl(title, production, distribution, premiereDate, hour, deadLine, noOfTickets);
        }

        private void DeleteFilmButton_Click(object sender, EventArgs e)
        {
            String title = this.titleTextBox.Text;

            FilmService fs = new FilmService();
            fs.DeleteFilmBl(title);
        }
    }
}
