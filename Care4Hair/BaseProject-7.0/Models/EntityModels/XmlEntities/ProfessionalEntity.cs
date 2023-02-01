using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.ViewModels;
using System.Collections.Generic;

namespace BaseProject_7_0.Models.EntityModels.XmlEntities
{
    public class ProfessionalEntity : BaseXmlEntityModel
    {
        //this fields are for easy navidation to the entityModel that map from this class.
        public ProfessionalIndexablePageViewModel NeverUsedField;
        public ProfessionalPartialViewModel NeverUsedField1;

        public string Keywords { get; set; }
        public string KeywordsSpanish { get; set; }
        public string ImageName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string JobTitleSpanish { get; set; }
        public string Description { get; set; }
        public string DescriptionSpanish { get; set; }
        public string Featured { get; set; }
        public string HonorificPrefix { get; set; }
        public string HonorificSuffix { get; set; }
        public string HonorificPrefixSpanish { get; set; }
        public string HonorificSuffixSpanish { get; set; }
        public string BriefIntroForAboutPage { get; set; }
        public string BriefIntroForAboutPageSpanish { get; set; }
        public string WorkLocation { get; set; }
        public ICollection<CategoryEntity> Categories { get; set; }
        public ICollection<VideoEntity> Videos { get; set; }

        public static string XmlFilePath = "/app_data/professionalentities.xml";
    }
}