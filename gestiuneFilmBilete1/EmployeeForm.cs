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
using System.Globalization;
using gestiuneFilmBilete1.model;

namespace gestiuneFilmBilete1
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void AddTicketsButton_Click(object sender, EventArgs e)
        {
            String noTicketsStr = this.noOfTicketsTextBox.Text;
            int noTickets = int.Parse(noTicketsStr);

            String title = this.filmNameTextBox.Text;

            String rowStr = this.rowTextBox.Text;
            int row = int.Parse(rowStr);

            String seatStr = this.seatTextBox.Text;
            int seat = int.Parse(seatStr);

            String datePattern = "dd-MM-yy";
            DateTime date;
            DateTime.TryParseExact(this.dateTextBox.Text, datePattern, null, DateTimeStyles.None, out date);

            TicketService ts = new TicketService();
            ts.AddTicketBl(noTickets, title, row, seat, date);
        }

        private void ViewListButton_Click(object sender, EventArgs e)
        {
            GridForm g = new GridForm();
            g.Show();
            



        }


        private void ExportListButton_Click(object sender, EventArgs e)
        {
            TicketService ts = new TicketService();
            ts.ExportListBl();
        }
    }
}
