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
using gestiuneFilmBilete1.dao;
using gestiuneFilmBilete1.model;

namespace gestiuneFilmBilete1
{
    public partial class ViewFilmsForm : Form
    {
        public ViewFilmsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilmService fs = new FilmService();
            List<Film> list = new List<Film>();
            list = fs.ViewListFilmBl();

            DataTable films = new DataTable();
            films.Columns.Add(new DataColumn("Title"));
            films.Columns.Add(new DataColumn("Production"));
            films.Columns.Add(new DataColumn("Distribution"));
            films.Columns.Add(new DataColumn("Premiere Date"));
            films.Columns.Add(new DataColumn("Hour"));
            films.Columns.Add(new DataColumn("Deadline "));
            films.Columns.Add(new DataColumn("Number of tickets"));


            for (var i = 0; i < list.Count; i++)
            {
                object[] resultSet = { list[i].title, list[i].production, list[i].distribution, list[i].premiereDate, list[i].scheduledHour, list[i].deadline, list[i].noOfTickets };
                films.Rows.Add(resultSet);
            }
            dataGridView1.DataSource = films;
        }
    }
}
