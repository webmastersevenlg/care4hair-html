using System;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using System.Reflection;
using BaseProject_7_0.XmlTools;

namespace BaseProject_7_0.Models.BaseModels
{
    public class BasePartialViewModel : BaseViewModel
    {         
        public string Active { get; set; }
        public string Featured { get; set; }

        public string BriefIntro { get; set; }
        public string BriefIntroSpanish { get; set; }


         
        public string GetBriefIntro
        {
            get
            {
                return IsEnglish ? BriefIntro : BriefIntroSpanish;
            }
        }
        
        //static members
        //============================================================================================
        public static string GetIdAttributeName(string abbreviatedLanguage)
        {
            return IsEnglishAbbreviation(abbreviatedLanguage) ? "Id" : "UrlSpanish";
        }

        public static string GetUrlAttributeName(string abbreviatedLanguage)
        {
            return IsEnglishAbbreviation(abbreviatedLanguage) ? "url" : "urlspanish";
        }
    }
}