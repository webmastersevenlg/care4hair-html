using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using System.Diagnostics;
using test_cache.Models;

namespace test_cache.Controllers
{


    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // [DonutOutputCache(Duration = 3600 * 24 * 7, VaryByParam = "abbreviatedLanguage", VaryByHeader = "User-Agent")]
        [OutputCache(Duration = 3600 * 24 * 7, VaryByRouteValueNames = new string[] { "abbreviatedLanguage" })]
        public IActionResult Index()
        {           
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}