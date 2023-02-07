using BaseProject_7_0.Models;
using BaseProject_7_0.Models.ViewModels;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Shyjus.BrowserDetection;
using System.Diagnostics;

namespace BaseProject_7_0.Controllers
{
    public class HomePageController : BaseController
    {

        private readonly ILogger<HomePageController> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IBrowserDetector _browserDetector;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomePageController(ILogger<HomePageController> logger, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor, IBrowserDetector browserDetector)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            _browserDetector = browserDetector;
            _webHostEnvironment = webHostEnvironment;
        }

        public ActionResult Index(string abbreviatedLanguage)
        {
            HomePageViewModel vm = new HomePageViewModel(_webHostEnvironment, _httpContextAccessor, _browserDetector);
            return Skin(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error([Bind(Prefix = "id")] int statusCode = 0)
        {
            var error = HttpContext.Features.Get<IExceptionHandlerFeature>();
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}