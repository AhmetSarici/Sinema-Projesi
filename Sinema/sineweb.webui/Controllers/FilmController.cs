
using Microsoft.AspNetCore.Mvc;
using sineweb.webui.Data;
using sineweb.webui.Models;


namespace sineweb.webui.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            var film = new Film { Name = "Matrix", Description = "Aksiyon" };

            // ViewData["Salon"] = "Telefonlar";
            // ViewData["Film"] = film;

            ViewBag.Salon = "Salon 1";
            // ViewBag.Film = film;

            // ViewBag.Film
            return View(film);
        }
        public IActionResult List()
        {
            var filmViewModel = new FilmViewModel()
            {
                Filmler = FilmRepository.Filmler
            };

            return View(filmViewModel);
        }

        public IActionResult Details(int id)
        {
            var x = FilmRepository.GetFilmById(id);
            return View(x);
        }
    }
}