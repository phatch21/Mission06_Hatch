// Payton Hatch
// Group 4-6
// Controller for movie page
using Microsoft.AspNetCore.Mvc;
using Mission06_Hatch.Models;

namespace Mission06_Hatch.Controllers
{
    public class MoviesController : Controller
    {
        // object to store database context
        private readonly ApplicationDbContext _context;

        // method to store new value to database context
        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // action returns view for the add a movie to database form
        public IActionResult Create()
        {
            return View();
        }

        // specifies post method when a movie is submitted
        [HttpPost]
        public IActionResult Create(Movie movie) // action that posts new movie record to database
        {   
            // check to account for invalid model state
            if (!ModelState.IsValid)
            {
                return View(movie);
            }

            // adds movie to database context
            _context.Movies.Add(movie);
            _context.SaveChanges(); // Saves movie to SQLite

            // message sent upon completion
            TempData["SuccessMessage"] = "Movie added successfully!";

            // redirect to add movie form
            return RedirectToAction("Create");
        }
    }
}
