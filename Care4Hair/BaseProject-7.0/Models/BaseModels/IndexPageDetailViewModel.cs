using BaseProject_7_0.App_Resources;

namespace BaseProject_7_0.Models.BaseModels
{
    public class IndexPageDetailViewModel : BaseModel
    {
        public RouteValueDictionary CurrentFilters { get; set; }
        public string Name { get; set; }
        public string NameSpanish { get; set; }
        public string UrlSection { get; set; }
        public string UrlSectionSpanish { get; set; }
        public string ElementTypeName { get; set; }
        public string ElementTypeNameSpanish { get; set; }
        public string ElementTypeNamePlural { get; set; }
        public string ElementTypeNamePluralSpanish { get; set; }
        public string AllElementsLabel { get; set; }
        public string AllElementsLabelSpanish { get; set; }

        public string GetElementTypeName
        {
            get
            {
                return IsEnglishThread ? ElementTypeName : ElementTypeNameSpanish;
            }
        }

        public string GetElementTypeNamePlural
        {
            get
            {
                return IsEnglishThread ? ElementTypeNamePlural : ElementTypeNamePluralSpanish;
            }
        }

        public string GetAllElementsLabel
        {
            get
            {
                return IsEnglishThread ? AllElementsLabel : AllElementsLabelSpanish;
            }
        }

        public string GetUrlSection(string abbreviatedLanguage)
        {            
            return IsEnglishAbbreviation(abbreviatedLanguage) ? UrlSection : UrlSectionSpanish;
        }

        public string GetIndexPageName()
        {
            return GetIndexPageName(GetabbreviatedLanguage);
        }

        public string GetIndexPageName(string abbreviatedLanguage)
        {
            return IsEnglishAbbreviation(abbreviatedLanguage) ? Name : NameSpanish;
        }

        public string GetServiceUrl
        {
            get
            {
                var serviceUrl = CurrentFilters != null ? CurrentFilters.FirstOrDefault(f => f.Key == "dbServiceUrl").Value : null;
                return serviceUrl == null ?
                                    "/" :
                                    "/" + serviceUrl.ToString() + "/";
            }
        }

        public string GetProfessionalUrl
        {
            get
            {
                var professionalUrl = CurrentFilters != null ? CurrentFilters.FirstOrDefault(f => f.Key == "dbProfessionalUrl").Value : null;
                return professionalUrl == null ?
                                         "" : 
                                         "/"+ professionalUrl.ToString()+"";
            }
        }

        public string GetIndexPageUrl()
        { 
            return GetIndexPageUrl(GetabbreviatedLanguage);
        }

        public string GetIndexPageUrl(string abbreviatedLanguage)
        {
            return IsEnglishAbbreviation(abbreviatedLanguage) ? "/" + UrlSection
                                                              : "/" + Settings.GetSpanishUrl + "/" + UrlSectionSpanish;        }
        
        public string GetFullIndexPageUrl()
        {
            return GetFullIndexPageUrl(GetabbreviatedLanguage);
        }

        public string GetFullIndexPageUrl(string abbreviatedLanguage)
        {

            return IsEnglishAbbreviation(abbreviatedLanguage) ? GetServiceUrl + UrlSection + GetProfessionalUrl
                                                            : "/" + Settings.GetSpanishUrl + GetServiceUrl + UrlSectionSpanish + GetProfessionalUrl;
        }
    }
}