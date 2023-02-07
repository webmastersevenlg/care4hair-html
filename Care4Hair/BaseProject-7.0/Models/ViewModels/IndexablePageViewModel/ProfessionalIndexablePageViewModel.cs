using BaseProject_7_0.App_Resources;
using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.EntityModels.XmlEntities;
using Shyjus.BrowserDetection;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class ProfessionalIndexablePageViewModel : BasePageWithStaticHtmlFilesViewModel
    {
        //this field is for easy navidation to the entityModel that this map from.
        public ProfessionalEntity NeverUsedField;

        public string Keywords { get; set; }
        public string KeywordsSpanish { get; set; }
        public string JobTitle { get; set; }
        public string JobTitleSpanish { get; set; }
        public string Description { get; set; }
        public string DescriptionSpanish { get; set; }
        public string Featured { get; set; }
        public string HonorificPrefix { get; set; }
        public string HonorificSuffix { get; set; }
        public string HonorificPrefixSpanish { get; set; }
        public string HonorificSuffixSpanish { get; set; }
        public string WorkLocation { get; set; }
        public ICollection<CategoryPartialViewModel> Categories { get; set; }
        public ICollection<VideoPartialViewModel> Videos { get; set; }



        public string GetEntityName
        {
            get
            {
                return IsEnglish ? "Doctor" : "Doctores";
            }
        }

        public override string GetH1
        {
            get
            {
                return HonorificPrefix +" " + Name + " " + GetJobTitle;
            }
        }
        public string GetJobTitle
        {
            get
            {
                return IsEnglishThread ? JobTitle : JobTitleSpanish;
            }
        }

        public string GetProfession
        {
            get
            {
                return Vocabulary.ResourceManager.GetString(Settings.GetProfessionalsProfession);
            }
        }

        public override AltLangRef GetAltLangRef
        {
            get
            {
                return new AltLangRef(GetPageUrl(), CurrentLanguage);
            }
        }

        public HttpRequest Request { get; }

        public ProfessionalIndexablePageViewModel(IWebHostEnvironment _webHostingEnviroment, IHttpContextAccessor _httpContextAccessor, IBrowserDetector _browserDetector) : base(_webHostingEnviroment, _httpContextAccessor, _browserDetector)
        {            
            SkinName = "ProfessionalPageSkin";
            ImagesFolderPath = "/content/images/professionals";
        }

        
    }
}
