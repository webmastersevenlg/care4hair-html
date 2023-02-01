using BaseProject_7_0.Models.BaseModels;

namespace BaseProject_7_0.Models.EntityModels.XmlEntities
{
    public class TagEntity : BaseXmlEntityModel
    {
        public string Language { get; set; }
        public static string XmlFilePath = "/app_data/tagentities.xml";
    }
}