using Microsoft.AspNetCore.Mvc;
using sineweb.webui.Data;


namespace sineweb.webui.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {


            var filmViewModel = new FilmViewModel()
            {
                Filmler = FilmRepository.Filmler
            };

            return View(filmViewModel);


        }

        // localhost:5000/home/about
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}