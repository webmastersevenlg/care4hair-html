using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.ViewModels;

namespace BaseProject_7_0.Models.EntityModels.XmlEntities
{
    public class UncategorizedPageEntity : BaseXmlEntityModel
    {

        //this fields are for easy navidation to the entityModel that map from this class.
        public UncategorizedPageViewModel NeverUsedField;
        public UncategorizedPagePartialViewModel NeverUsedField1;

        public string Name { get; set; }
        public string NameSpanish { get; set; }
        public static string GetUrlParam(string abbreviatedLanguage)
        {
            return
            !string.IsNullOrEmpty(abbreviatedLanguage) &&
            abbreviatedLanguage.ToLower() == "es" ? "urlspanish" : "url";

        }
        public static string XmlFilePath = "/app_data/uncategorizedpageentities.xml";
    }
}