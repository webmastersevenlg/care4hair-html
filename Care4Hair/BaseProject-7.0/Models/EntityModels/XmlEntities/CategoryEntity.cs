using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.EntityModels.XmlEntities
{
    public class CategoryEntity : BaseXmlEntityModel
    {
        //this fields are for easy navidation to the entityModel that map from this class.
        public CategoryPageViewModel NeverUsedField;
        public CategoryPartialViewModel NeverUsedField1;

        public bool IsSelected { get; set; }
        public string Language { get; set; }
        public string Name { get; set; }
        public string NameSpanish { get; set; }
        public string BriefIntro { get; set; }
        public string BriefIntroSpanish { get; set; }
        public int BlogPostingsCount { get; set; }
        public int VideosCount { get; set; }
        public string Featured { get; set; }
        public string SuperCategoryId { get; set; }
        public ICollection<ServiceEntity> Services { get; set; }
        public static string XmlFilePath = "~/app_data/categoryentities.xml";
        public string Icon { get; set; }    

        public string GetUrlParam()
        {
            return IsEnglishThread ? "url" : "urlspanish";
        }

        public string GetUrl(string abbreviatedLanguage)
        {
            return IsEnglishThread ? UrlSpanish : Url;
        }

        //static members
        public static string GetUrlParam(string abbreviatedLanguage)
        {
            return IsEnglishAbbreviation(abbreviatedLanguage) ? "url" : "urlspanish";
        }
    }
}