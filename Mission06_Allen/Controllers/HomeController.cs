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

        [HttpGet]
        public IActionResult NewMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewMovie(Movie response)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();

            return View("Thanks");
        }
    }
}
