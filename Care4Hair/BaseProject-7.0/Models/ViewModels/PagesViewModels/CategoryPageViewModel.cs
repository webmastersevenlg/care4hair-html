using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.EntityModels.XmlEntities;
using Shyjus.BrowserDetection;
using System.Collections.Generic;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class CategoryPageViewModel : BasePageWithStaticHtmlFilesViewModel
    {
        //this field is for easy navidation to the entityModel that this map from.
        public CategoryEntity NeverUsedField;
        
        public bool IsSelected { get; set; }
        public int BlogPostingsCount { get; set; }
        public int VideosCount { get; set; }
        public string BriefIntro { get; set; }
        public string BriefIntroSpanish { get; set; }
        public ICollection<ServicePartialViewModel> Services { get; set; }
        
        public string GetBriefIntro
        {
            get
            {
                return IsEnglish ? BriefIntro : BriefIntroSpanish;
            }
        }


        public static string GetIdAttributeName(string abbreviatedLanguage)
        {
            return IsEnglishAbbreviation(abbreviatedLanguage) ? "Id" : "UrlSpanish";
        }

        public string GetId(string abbreviatedLanguage)
        {
            return IsEnglishAbbreviation(abbreviatedLanguage) ? UrlSpanish : Id;
        }

        public static string GetEntityName(string abbreviatedLanguage)
        {
            return IsEnglishAbbreviation(abbreviatedLanguage) ? "Area Legal" : "Practice Area";
        }

        public override string GetH1 { get { return IsEnglish ? GetName + " Procedures" : GetName; } }

        public CategoryPageViewModel(IWebHostEnvironment _webHostingEnviroment,IHttpContextAccessor _httpContextAccessor, IBrowserDetector _browserDetector) : base(_webHostingEnviroment, _httpContextAccessor, _browserDetector)
        {
            SkinName = "CategoryPageSkin";
            ImagesFolderPath = "/content/images/categories";
        }
    }

}