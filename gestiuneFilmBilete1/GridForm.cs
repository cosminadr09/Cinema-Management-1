using gestiuneFilmBilete1.bl;
using gestiuneFilmBilete1.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestiuneFilmBilete1
{
    public partial class GridForm : Form
    {
        public GridForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TicketService ts = new TicketService();
            List<Ticket> list = new List<Ticket>();
            list = ts.ViewListBl();

            DataTable tickets = new DataTable();
            tickets.Columns.Add(new DataColumn("Film"));
            tickets.Columns.Add(new DataColumn("Seat"));
            tickets.Columns.Add(new DataColumn("Row"));
            tickets.Columns.Add(new DataColumn("Date"));


            for (var i = 0; i < list.Count; i++)
            {
                object[] resultSet = { list[i].filmTitle, list[i].row, list[i].seat, list[i].date };
                tickets.Rows.Add(resultSet);
            }
            dataGridView1.DataSource = tickets;
            
        }
    }
}
