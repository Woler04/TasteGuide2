using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TasteGuide.Data;
using TasteGuide.Models;

namespace TasteGuide.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["RestaurantCount"] = _context.Restaurants.Count();
            ViewData["ReviewCount"] = _context.Reviews.Count();
            ViewData["UserCount"] = _context.Users.Count();
            return View();
        }

        public IActionResult Privacy()
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