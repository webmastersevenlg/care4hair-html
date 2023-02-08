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


        public HomePageController(ILogger<HomePageController> logger, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor, IBrowserDetector browserDetector) : base(logger, webHostEnvironment, httpContextAccessor, browserDetector)
        {
          
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