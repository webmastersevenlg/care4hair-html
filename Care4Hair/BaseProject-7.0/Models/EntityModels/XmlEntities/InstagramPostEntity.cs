using BaseProject_7_0.Models.BaseModels;

namespace BaseProject_7_0.Models.EntityModels.XmlEntities
{
    public class InstagramPostEntity : BaseXmlEntityModel
    {
        public string Date { get; set; }
        public ProfessionalEntity Professional { get; set; }
        public ServiceEntity Service { get; set; }
        public int Priority { get; set; }
        public static string XmlFilePath = "~/app_data/instagrampostentities.xml";
    }
}