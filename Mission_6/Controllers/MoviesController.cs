﻿using Microsoft.AspNetCore.Mvc;
using Mission06_Hatch.Models;

namespace Mission06_Hatch.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return View(movie);
            }

            _context.Movies.Add(movie);
            _context.SaveChanges(); // Save to SQLite

            TempData["SuccessMessage"] = "Movie added successfully!";
            return RedirectToAction("Create");
        }
    }
}
