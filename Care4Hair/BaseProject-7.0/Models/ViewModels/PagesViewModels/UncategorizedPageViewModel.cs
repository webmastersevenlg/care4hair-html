using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.EntityModels.DbEntities;
using BaseProject_7_0.Models.EntityModels.XmlEntities;
using BaseProject_7_0.App_Resources;
using BaseProject_7_0.XmlTools;
using Shyjus.BrowserDetection;

namespace BaseProject_7_0.Models.ViewModels
{
    public class UncategorizedPageViewModel : BasePageWithStaticHtmlFilesViewModel
    {
        //this field is for easy navidation to the entityModel that this map from.
        public UncategorizedPageEntity NeverUsedField;

        public ICollection<ProfessionalPartialViewModel> Professionals { get; set; }

        public UncategorizedPageViewModel(IWebHostEnvironment _webHostingEnviroment, IHttpContextAccessor _httpContextAccessor, IBrowserDetector _browserDetector) : base(_webHostingEnviroment, _httpContextAccessor, _browserDetector)
        {           

            SkinName = "UncategorizedPageSkin";
            ImagesFolderPath = "/themes/" + Settings.GetTheme + "/images/uncategorized-pages";
            Professionals = new List<ProfessionalPartialViewModel>();

            var xmlprofessionals = XmlReader.GetElementsByFileNameAttributeNameAndAttributeValue<ProfessionalEntity>(
               ProfessionalEntity.XmlFilePath,
               "active",
               "true"
               ).ToList();

            using (var db = new BscrmCare4hairContext())
            {
                var dbProfessionals = db.WebRelatedDoctors.ToArray();
                foreach (var xmlprofessional in xmlprofessionals)
                {
                    ProfessionalPartialViewModel professionalVm = new ProfessionalPartialViewModel();
                    professionalVm.MapFromXmlEntity<ProfessionalEntity>(xmlprofessional);
                    var path = httpContextAccessor.HttpContext?.Request.Path.ToString();
                    if (path.Contains("calculate-your-bmi"))
                    {
                        var professional = dbProfessionals.FirstOrDefault(p => p.UrlSection == xmlprofessional.DbUrl);                        
                    }
                    Professionals.Add(professionalVm);
                }
            }
        }


        public override string GetH1
        {
            get
            {
                return GetName;
            }
        }
    }
}