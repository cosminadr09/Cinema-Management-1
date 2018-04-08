using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestiuneFilmBilete1.dao;
using gestiuneFilmBilete1.model;

namespace gestiuneFilmBilete1.bl
{
    class TicketService
    {
        private TicketDAO tdao;
        private FilmDAO fdao;

        public TicketService()
        {

        }

        public void AddTicketBl(int noTickets, String title, int row, int seat, DateTime date)
        {
            tdao = new TicketDAO();
            fdao = new FilmDAO();
            Film existentfilm = new Film(fdao.GetFilm(title).title, fdao.GetFilm(title).production, fdao.GetFilm(title).distribution, fdao.GetFilm(title).premiereDate, fdao.GetFilm(title).scheduledHour, fdao.GetFilm(title).deadline, fdao.GetFilm(title).noOfTickets);
            
            fdao.UpdateFilm(existentfilm.title, existentfilm.production, existentfilm.distribution,existentfilm.premiereDate,existentfilm.scheduledHour,existentfilm.deadline,existentfilm.noOfTickets+noTickets);
            tdao.InsertTicket(noTickets, title, row, seat, date);

        }

        public List<Ticket> ViewListBl()
        {
            tdao = new TicketDAO();
            List<Ticket> tickets = new List<Ticket>();
            tickets = tdao.FindAll();
            return tickets;
        }

        public void ExportListBl() //nu trebuie implementata
        {

        }


    }
}
