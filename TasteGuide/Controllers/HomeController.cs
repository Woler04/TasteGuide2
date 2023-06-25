using Microsoft.AspNetCore.Identity;
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
        private readonly RoleManager<IdentityRole> _roleManager;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, RoleManager<IdentityRole> roleManager)
        {
            _logger = logger;
            _context = context;
            _roleManager = roleManager;
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