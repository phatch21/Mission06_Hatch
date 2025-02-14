// Payton Hatch
// Group 4-6
// Controller for home pages
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Mission06_Hatch.Models;

namespace Mission06_Hatch.Controllers
{
    // Home page controller
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Returns the index page view
        public IActionResult Index()
        {
            return View();
        }

        // Returns the get to know you page view
        public IActionResult GetToKnow()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
