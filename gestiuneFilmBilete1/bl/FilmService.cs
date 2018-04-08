using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestiuneFilmBilete1.dao;
using gestiuneFilmBilete1.model;

namespace gestiuneFilmBilete1.bl
{
    class FilmService
    {
        private FilmDAO fdao;

        public FilmService()
        {

        }

        public void CreateFilmBl(String title, String production, String distribution, DateTime premiereDate, int hour, DateTime deadline, int tickets)
        {
            fdao = new FilmDAO();
            //Console.WriteLine("din service" +deadline.ToString());
            fdao.InsertFilm( title,  production,  distribution,  premiereDate,  hour,  deadline,  tickets);
        }

        public List<Film> ViewListFilmBl()
        {
            fdao = new FilmDAO();
            List<Film> films = new List<Film>();
            films =fdao.FindAll();
            return films;

        }

        public void UpdateFilmBl(String title, String production, String distribution, DateTime premiereDate, int hour, DateTime deadline, int tickets)
        {
            fdao = new FilmDAO();
            fdao.UpdateFilm(title, production,  distribution,  premiereDate,  hour,  deadline,  tickets);

        }

        public void DeleteFilmBl(String title)
        {
            fdao = new FilmDAO();
            fdao.DeleteFilm(title);

        }
    }
}
