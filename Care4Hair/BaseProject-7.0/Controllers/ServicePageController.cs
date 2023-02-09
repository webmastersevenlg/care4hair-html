using BaseProject_7_0.Models.EntityModels.XmlEntities;
using BaseProject_7_0.Models.ViewModels;
using BaseProject_7_0.XmlTools;
using Microsoft.AspNetCore.Mvc;
using Shyjus.BrowserDetection;

namespace BaseProject_7_0.Controllers
{
    public class ServicePageController : BaseController
    {

        public ServicePageController(ILogger<HomePageController> logger, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor, IBrowserDetector browserDetector) : base(logger, webHostEnvironment, httpContextAccessor, browserDetector)
        {

        }

        //[DonutOutputCache(Duration = 3600 * 24 * 7, Location = OutputCacheLocation.Server, NoStore = true, VaryByParam = "abbreviatedLanguage;serviceUrl", VaryByCustom = "IsMobile")]
        public ActionResult Index(string serviceUrl)
        {
            var abbreviatedLanguage = Thread.CurrentThread.CurrentCulture.ToString();

            //creo el vm vacio
            ServicePageViewModel vm = new ServicePageViewModel(_webHostEnvironment, _httpContextAccessor, _browserDetector);
            //mapeo el entitymodel a el viewmodel
            //lleno los valores del lenguage y tipo de dispositivo del request
           
            //leo del Services.xml y obtengo el serviceEntity
            ServiceEntity serviceEntity = XmlReader.GetElementByFileNameAttributeNameAndAttributeValue<ServiceEntity>(ServiceEntity.XmlFilePath, ServiceEntity.GetUrlParam(abbreviatedLanguage), serviceUrl);

            if (serviceEntity == null)
            {
                throw new HttpRequestException("File Not Found", null, System.Net.HttpStatusCode.NotFound);
            }

            serviceEntity.FAQs = XmlReader.GetElementsByFileNameAndSubElementAttributeValue<FAQEntity>(FAQEntity.XmlFilePath, "Service", "id", serviceEntity.Url);
            serviceEntity.FAQs = serviceEntity.FAQs.Where(f => f.Language.ToLower() == abbreviatedLanguage).ToList();
            serviceEntity.VideoFAQs = XmlReader.GetElementsByFileNameAndSubElementAttributeValue<VideoEntity>(VideoEntity.XmlFilePath, "Service", "id", serviceEntity.Url).Where(v => v.Tags.Any(t => t.Id == "faq") && v.Language.ToLower() == abbreviatedLanguage.ToLower()).ToList();

            foreach (var category in serviceEntity.Categories)
            {
               category.Services = XmlReader.GetElementsByFileName_SubGroupName_SubGroupElementName_Attribute_and_Value<ServiceEntity>(
                   ServiceEntity.XmlFilePath, 
                   "Categories",
                   "Category",
                   "id",
                   category.Id
                   ).Where(e=>e.Active=="true").ToList();
            }

            vm.MapFromXmlEntity(serviceEntity);
            TempData["ActiveMenuElement"] = "services";
            //retorno el metodo skin que devuelve un view en dependencia del dispositivo del que se hizo el request
            return Skin(vm);
        }
    }
}