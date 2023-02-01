
using BaseProject_7_0.App_Resources;

namespace BaseProject_7_0.Models.BaseModels
{
    public class IndexablePageDetailViewModel : BaseViewModel
    {
        public string UrlSection { get; set; }
        public string UrlSectionSpanish { get; set; }

        public virtual string GetIndexablePageUrl(string abbreviatedLanguage)
        {
            return IsEnglishAbbreviation(abbreviatedLanguage) ? "/"+ UrlSection + "/" + Url : "/" + Settings.GetSpanishUrl + "/"+UrlSectionSpanish+"/" + UrlSpanish;
        }

        public string GetIndexablePageUrl()
        {
            return GetIndexablePageUrl(CurrentLanguage.AbbreviatedName);
        }

        public virtual string GetIndexablePageUrl(string abbreviatedLanguage, bool isLandingPage)
        {
            if (isLandingPage)
                return IsEnglishAbbreviation(abbreviatedLanguage) ? "/lp/" + UrlSection + "/" + Url : "/" + Settings.GetSpanishUrl + "/lp/" + UrlSectionSpanish + "/" + UrlSpanish;
            else
                return IsEnglishAbbreviation(abbreviatedLanguage) ? "/" + UrlSection + "/" + Url : "/" + Settings.GetSpanishUrl + "/" + UrlSectionSpanish + "/" + UrlSpanish;
        }

        public string GetIndexablePageUrl(bool isLandingPage)
        {
            return GetIndexablePageUrl(CurrentLanguage.AbbreviatedName, isLandingPage);
        }
    }
}