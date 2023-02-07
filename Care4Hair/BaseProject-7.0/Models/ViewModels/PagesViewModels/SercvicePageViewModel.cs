using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.EntityModels.XmlEntities;
using Shyjus.BrowserDetection;

namespace BaseProject_7_0.Models.ViewModels
{
    public class ServicePageViewModel : BasePageWithStaticHtmlFilesViewModel
    {
        //this field is for easy navidation to the entityModel that this map from.
        public ServiceEntity NeverUsedField;

        public string ShortName { get; set; }
        public string ShortNameSpanish { get; set; }
        public string TargeredKeyword { get; set; }
        public string TargeredKeywordSpanish { get; set; }
        public string Description { get; set; }
        public string DescriptionSpanish { get; set; }
        public ICollection<CategoryPartialViewModel> Categories { get; set; }

        public ICollection<BlogPostPartialViewModel> BlogPostings { get; set; }
        public ICollection<ProfessionalPartialViewModel> Professionals { get; set; }
        public ICollection<VideoPartialViewModel> Videos { get; set; }
        public ICollection<VideoPartialViewModel> VideoFAQs { get; set; }

        public string ServiceGroupName { get; set; }
        public string ServiceGroupNameSpanish { get; set; }

        public string CurrentMinimunPrice { get; set; }

        public string GetPrice
        {
            get
            {
                return CurrentMinimunPrice != null && CurrentMinimunPrice != "0" ? "$" + CurrentMinimunPrice : null;
            }
        }

        public string GetDescription
        {
            get
            {
                return IsEnglish ? DescriptionSpanish : Description;
            }
        }

        public override AltLangRef GetAltLangRef
        {
            get
            {
                return new AltLangRef(GetPageUrl(), CurrentLanguage);
            }
        }

        public ServicePageViewModel(IWebHostEnvironment _webHostingEnviroment, IHttpContextAccessor _httpContextAccessor, IBrowserDetector _browserDetector) : base(_webHostingEnviroment, _httpContextAccessor, _browserDetector)
        {
            SkinName = "ServicePageSkin";
            ImagesFolderPath = "/content/images/services";
        }
    }
}