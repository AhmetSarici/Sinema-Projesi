using System.Collections.Generic;
using System.Linq;
using sineweb.webui.Models;

namespace sineweb.webui.Data
{
    public static class FilmRepository
    {
        private static List<Film> _filmler = null;

        static FilmRepository()
        {
            _filmler = new List<Film>
            {
                new Film {FilmId=1,Name="Harry Potter",Description="Bilim Kurgu",IsLoad=false, ImageUrl="1.jpg"},
                new Film {FilmId=2,Name="Inception",Description="Dram",IsLoad=true, ImageUrl="2.jpg"},
                new Film {FilmId=3,Name="Matrix",Description="Aksiyon",IsLoad=true, ImageUrl="3.jpg"},
                new Film {FilmId=4,Name="Dr Strange",Description="Bilim Kurgu",IsLoad=true, ImageUrl="4.jpg"}
            };
        }

        public static List<Film> Filmler
        {
            get
            {
                return _filmler;
            }
        }

        public static void AddFilm(Film film)
        {
            _filmler.Add(film);
        }

        public static Film GetFilmById(int id)
        {
            return _filmler.FirstOrDefault(p => p.FilmId == id);
        }
    }
}