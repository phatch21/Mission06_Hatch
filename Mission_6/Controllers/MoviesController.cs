// Payton Hatch
// Group 4-6

using Microsoft.AspNetCore.Mvc;
using Mission06_Hatch.Models;
using System.Linq;

namespace Mission06_Hatch.Controllers
{
    // movie controller class
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // View action for movie form
        public IActionResult Create()
        {
            return View();
        }

        // View action for movie table
        public IActionResult MovieTable()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }

        //  Adds movie record to DB (Handled in Create.cshtml)
        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return View(movie);
            }

            _context.Movies.Add(movie);
            _context.SaveChanges();

            TempData["SuccessMessage"] = "Movie added successfully!";
            return RedirectToAction("MovieTable");
        }

        // View for form to update existing movie record (Edit Movie)
        public IActionResult Edit(int id)
        {
            var movie = _context.Movies.Find(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // Updates existing movie record
        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return View(movie);
            }

            _context.Movies.Update(movie);
            _context.SaveChanges();
            
            TempData["SuccessMessage"] = "Movie updated successfully!";
            return RedirectToAction("MovieTable");
        }

        // Delete record action (Remove a Movie)
        public IActionResult Delete(int id)
        {
            var movie = _context.Movies.Find(id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
                TempData["SuccessMessage"] = "Movie deleted successfully!";
            }
            return RedirectToAction("MovieTable");
        }
    }
}
