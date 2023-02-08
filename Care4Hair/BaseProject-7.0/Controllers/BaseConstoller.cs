using BaseProject_7_0.Controllers;
using BaseProject_7_0.Models.BaseModels;
using Microsoft.AspNetCore.Mvc;
using Shyjus.BrowserDetection;
using System.Text.RegularExpressions;

public class BaseController : Controller
{
    internal readonly ILogger<HomePageController> _logger;
    internal readonly IHttpContextAccessor _httpContextAccessor;
    internal readonly IBrowserDetector _browserDetector;
    internal readonly IWebHostEnvironment _webHostEnvironment;

    public BaseController(ILogger<HomePageController> logger, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor, IBrowserDetector browserDetector)
    {
        _logger = logger;
        _httpContextAccessor = httpContextAccessor;
        _browserDetector = browserDetector;
        _webHostEnvironment = webHostEnvironment;
    }

    protected ViewResult BaseIndex(object model)
    {
        string view = "~/Views/BaseIndex/BaseIndexSkin.cshtml";
        return View(view, model);
    }

    protected ViewResult Skin(BasePageViewModel model)
    {
        string view = model.SkinName;
        if (view == null)
        {
            // throw new HttpException(404, "Skin Name is null");
        }
        return View(view, model);
    }
}
