using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestiuneFilmBilete1.model
{
    class Ticket
    {
        public String filmTitle { get; private set; }
        public int row { get; private set; }
        public int seat { get; private set; }
        public DateTime date { get; private set; }

        public Ticket(String filmTitle, int row, int seat, DateTime date)
        {
            this.filmTitle = filmTitle;
            this.row = row;
            this.seat = seat;
            this.date = date;
        }

        public override string ToString()
        {
            return "title="+filmTitle+" row="+row+" seat="+seat+" date="+date;
        }
    }
}
