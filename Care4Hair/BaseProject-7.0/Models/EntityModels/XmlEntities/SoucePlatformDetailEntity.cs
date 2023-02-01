using BaseProject_7_0.Models.BaseModels;

namespace BaseProject_7_0.Models.EntityModels.XmlEntities
{
    public class SoucePlatformDetailEntity : BaseXmlEntityModel
    {
        public string Name { get; set; }
        public string SourcePlatform { get; set; }
        public string SourceCategory { get; set; }
        public string ProfessionalUrl { get; set; }
        public static string XmlFilePath = "~/app_data/souceplatformdetailentities.xml";
        public override string UrlSpanish { get { return Url; } }
    }
}