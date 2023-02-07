using BaseProject.Models.EntityModels.XmlEntities;
using BaseProject.Models.EntityModels.DbEntities;
using BaseProject.Models.ViewModels;
using BaseProject.XmlTools;
using System.Web.Mvc;
using System.Web.UI;
using DevTrends.MvcDonutCaching;
using System;
using System.Collections.Generic;
using System.Linq;



namespace BaseProject.Controllers
{
    public class ProfessionalPageController : BaseController
    {
        [DonutOutputCache(Duration = 3600 * 24 * 7, Location = OutputCacheLocation.Server, NoStore = true, VaryByParam = "abbreviatedLanguage;professionalUrl", VaryByCustom = "IsMobile")]
        public ActionResult Index(string abbreviatedLanguage, string professionalUrl)
        {
            //leo del Services.xml y obtengo el ServiceEntity 

            ProfessionalEntity professionalEntity = XmlReader.GetElementByFileNameAttributeNameAndAttributeValue<ProfessionalEntity>(ProfessionalEntity.XmlFilePath, "url", professionalUrl);


                        

            //if (professionalEntity == null || professionalEntity.Categories == null || professionalEntity.Categories.Count == 0)
            //     throw new HttpException(404, "File Not Found");     
            //creo el vm vacio
            ProfessionalIndexablePageViewModel vm = new ProfessionalIndexablePageViewModel(Request);
            //mapeo el entitymodel a el viewmodel
            vm.MapFromXmlEntity<ProfessionalEntity>(professionalEntity);

            //lleno los valores del lenguage y tipo de dispositivo del request
            //retorno el metodo skin que devuelve un view en dependencia del dispositivo del que se hizo el request

            TempData["ActiveMenuElement"] = "professionals";
            return Skin(vm);
        }
    }
}