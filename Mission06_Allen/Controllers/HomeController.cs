using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Allen.Models;


namespace Mission06_Allen.Controllers
{
    public class HomeController : Controller
    {
        private MovieFormContext _context;

        public HomeController(MovieFormContext temporary)
        {
            _context = temporary;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Thanks()
        {
            return View();
        }


        // probably gonna have to mess w this a bit
        public IActionResult MovieList()
        {
            var movies = _context.Movies.ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult NewMovie()
        {
            ViewBag.Categories = _context.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult NewMovie(Movie response)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();

            return View("Thanks", response);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var record = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories.ToList();

            return View("NewMovie", record);
        }
    }
}
