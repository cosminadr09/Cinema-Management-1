using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestiuneFilmBilete1.model
{
    class Film
    {
        public String title { get; private set; }
        public String production { get; private set; }
        public String distribution { get; private set; }
        public DateTime premiereDate { get; private set; }
        public int scheduledHour { get; private set; }
        public DateTime deadline { get; private set; }
        public int noOfTickets { get; private set; }

        public Film(String title, String production, String distribution, DateTime premiereDate, int hour, DateTime deadline, int noOfTickets)
        {
            this.title = title;
            this.production = production;
            this.distribution = distribution;
            this.premiereDate = premiereDate;
            this.scheduledHour = hour;
            this.deadline = deadline;
            this.noOfTickets = noOfTickets;
        }

        public override string ToString() {


            return "title="+title+" production="+production+" distribution"+distribution+" prem="+premiereDate + " hour="+scheduledHour+" deadline="+deadline+" tickets="+noOfTickets;
        }

    }
}
