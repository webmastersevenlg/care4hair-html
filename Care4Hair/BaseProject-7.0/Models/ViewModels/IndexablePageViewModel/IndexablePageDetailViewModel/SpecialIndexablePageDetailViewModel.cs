using BaseProject_7_0.App_Resources;
using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.EntityModels.XmlEntities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class SpecialIndexablePageDetailViewModel : IndexablePageDetailViewModel
    {
        public SpecialIndexablePageDetailViewModel()
        {
            UrlSection = "special";
            UrlSectionSpanish = "especial";
        }

        public override string GetIndexablePageUrl(string abbreviatedLanguage)
        {
            return IsEnglishAbbreviation(abbreviatedLanguage) ? "/" + UrlSection + "/" + Url  + "/" + Id: "/" + Settings.GetSpanishUrl + "/" + UrlSectionSpanish + "/" + UrlSpanish + "/" + Id;
        }

        public override string GetIndexablePageUrl(string abbreviatedLanguage, bool isLandingPage)
        {
            if (isLandingPage)
                return IsEnglishAbbreviation(abbreviatedLanguage) ? "/lp/" + UrlSection + "/" + Url + "/" + Id : "/" + Settings.GetSpanishUrl + "/lp/" + UrlSectionSpanish + "/" + UrlSpanish + "/" + Id;
            else
                return IsEnglishAbbreviation(abbreviatedLanguage) ? "/" + UrlSection + "/" + Url + "/" + Id : "/" + Settings.GetSpanishUrl + "/" + UrlSectionSpanish + "/" + UrlSpanish + "/" + Id;
        }
    }
}