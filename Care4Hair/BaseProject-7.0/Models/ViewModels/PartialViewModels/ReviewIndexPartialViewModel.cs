using BaseProject_7_0.App_Resources;
using BaseProject_7_0.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class ReviewIndexPartialViewModel : BasePartialViewModel
    {
        public string GetElementTypeName
        {
            get
            {
                return "Review";
            }
        }

        public string GetElementTypeNamePlural
        {
            get
            {
                return "Reviews";
            }
        }

        public override string GetPageUrl(string abbreviatedLanguage)
        {
            return IsEnglishAbbreviation(abbreviatedLanguage) ? "/reviews" : "/" + Settings.GetSpanishUrl + "/reviews";            
        }

        public string GetAllElementsLabel
        {
            get
            {
                return IsEnglish ? "Reviews" : "/" + Settings.GetSpanishUrl + "Reviews";
            }
        }

        public string GetIndexName
        {
            get
            {
                return IsEnglish ? "Reviews" : "Reviews";
            }
        }
    }
}