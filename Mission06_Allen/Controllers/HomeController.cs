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

        // probably gonna have to mess w this a bit
        public IActionResult MovieList()
        {
            ViewBag.Categories = _context.Categories.ToList();

            var movies = _context.Movies
                .OrderBy(x => x.Title).ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult NewMovie()
        {
            ViewBag.Categories = _context.Categories.ToList();

            return View(new Movie());
        }

        [HttpPost]
        public IActionResult NewMovie(Movie response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response);
                _context.SaveChanges();

                return View("ThankYou");
            }

            else
            {
                ViewBag.Categories = _context.Categories.ToList();


                return View(response);
            }
            
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var record = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories.ToList();

            return View("NewMovie", record);
        }

        [HttpPost]
        public IActionResult Edit(Movie newInfo)
        {
            _context.Update(newInfo);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var byebye = _context.Movies
                .Single(x => x.MovieId == id);

            return View(byebye);
        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
