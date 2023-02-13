
using BaseProject_7_0.Models.EntityModels.XmlEntities;
using BaseProject_7_0.Models.ViewModels;
using BaseProject_7_0.XmlTools;
using Microsoft.AspNetCore.Mvc;
using Shyjus.BrowserDetection;
namespace BaseProject_7_0.Controllers
{
    public class UncategorizedPageController:BaseController
    {

        public UncategorizedPageController(ILogger<HomePageController> logger, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor, IBrowserDetector browserDetector) : base(logger, webHostEnvironment, httpContextAccessor, browserDetector)
        {

        }


        // [DonutOutputCache(Duration = 3600 * 24, Location = OutputCacheLocation.Server, NoStore = true, VaryByParam = "abbreviatedLanguage;uncategorizedPageUrl", VaryByCustom = "IsMobile")]
        public ActionResult Index(string abbreviatedLanguage, string uncategorizedPageUrl)
        {
            //leo del services.xml y obtengo el entitymodel
            UncategorizedPageEntity uncategorizedPageEntity = XmlReader.GetElementByFileNameAttributeNameAndAttributeValue<UncategorizedPageEntity>(UncategorizedPageEntity.XmlFilePath, UncategorizedPageEntity.GetUrlParam(abbreviatedLanguage), uncategorizedPageUrl);
            if (uncategorizedPageEntity == null)
                throw new HttpRequestException("File Not Found", null, System.Net.HttpStatusCode.NotFound);
            //creo el vm 
            UncategorizedPageViewModel vm = new UncategorizedPageViewModel(_webHostEnvironment, _httpContextAccessor, _browserDetector);
            //mapeo el entitymodel a el viewmodel
            vm.MapFromXmlEntity<UncategorizedPageEntity>(uncategorizedPageEntity);

            TempData["ActiveMenuElement"] = vm.Url;

            return Skin(vm);
        }

        //[DonutOutputCache(Duration = 3600 * 24, Location = OutputCacheLocation.Server, NoStore = true, VaryByParam = "abbreviatedLanguage;Url", VaryByCustom = "IsMobile")]
        //public ActionResult Locations(string abbreviatedLanguage)
        //{
        //    ////leo del services.xml y obtengo el entitymodel
        //    //UncategorizedPageEntity uncategorizedPageEntity = XmlReader.GetElementByFileNameAttributeNameAndAttributeValue<UncategorizedPageEntity>(UncategorizedPageEntity.XmlFilePath, UncategorizedPageEntity.GetUrlParam(abbreviatedLanguage), uncategorizedPageUrl);
        //    //if (uncategorizedPageEntity == null)
        //    //    throw new HttpException(404, "File Not Found");
        //    //creo el vm 
        //    UncategorizedPageViewModel vm = new UncategorizedPageViewModel(Request);
        //    //mapeo el entitymodel a el viewmodel
        //    //vm.MapFromXmlEntity<UncategorizedPageEntity>(uncategorizedPageEntity);
        //    TempData["ActiveMenuElement"] = vm.Url;
        //    vm.Url="miami-fl-location";
        //    vm.Url= "las-vegas-nv-location";

        //    return Skin(vm);
        //}


    }
}
