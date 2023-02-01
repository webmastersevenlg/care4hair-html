using BaseProject_7_0.App_Resources;
using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class VideoIndexPartialViewModel : BasePartialViewModel
    {
        public string GetElementTypeName
        {
            get
            {
                return IsEnglish ? "Video" : "Video";
            }
        }

        public string GetElementTypeNamePlural
        {
            get
            {
                return IsEnglish ? "Videos" : "Videos";
            }
        }

        public string GetIndexName
        {
            get
            {
                return IsEnglish ? "Videos" : "Videos";
            }
        }

        public string GetAllElementsLabel
        {
            get
            {
                return IsEnglish ? "All Videos" : "Todos Los Videos";
            }
        }

        public override string GetPageUrl(string abbreviatedLanguage)
        {
            return IsEnglishAbbreviation(abbreviatedLanguage) ? "/videos" : "/" + Settings.GetSpanishUrl + "/videos";
        }
    }
}

