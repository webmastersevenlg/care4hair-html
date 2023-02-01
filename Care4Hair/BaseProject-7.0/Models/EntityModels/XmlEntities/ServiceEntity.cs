using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.ViewModels;
using System.Collections.Generic;

namespace BaseProject_7_0.Models.EntityModels.XmlEntities
{
    public class ServiceEntity : BaseXmlEntityModel
    {
        //this fields are for easy navidation to the entityModel that map from this class.
        public ServicePageViewModel NeverUsedField;
        public ServicePartialViewModel NeverUsedField1;

        
        public string Name { get; set; }
        public string NameSpanish { get; set; }
        public string ShortName { get; set; }
        public string ShortNameSpanish { get; set; }
        public string TargeredKeyword { get; set; }
        public string TargeredKeywordSpanish { get; set; }
        public string BriefIntro { get; set; }
        public string BriefIntroSpanish { get; set; }
        public string Description { get; set; }
        public string DescriptionSpanish { get; set; }
        public string HasCategoryPageBriefDescription { get; set; }
        public string Featured { get; set; }
        public ICollection<CategoryEntity> Categories { get; set; }
        public ICollection<BlogPostEntity> BlogPostings { get; set; }
        public ICollection<ProfessionalEntity> Professionals { get; set; }
        public static string XmlFilePath = "~/app_data/serviceentities.xml";
        public string ServiceGroupName { get; set; }
        public string ServiceGroupNameSpanish { get; set; }
        public string MainSlide_youtube_id { get; set; }
        public string MainSlide_caption { get; set; }
        public string MainSlide_youtube_id_spanish { get; set; }
        public string MainSlide_caption_spanish { get; set; }
        public string MainSlide_caption_data_x { get; set; }
        public string MainSlide_caption_data_hoffset { get; set; }
        public string MainSlide_caption_data_y { get; set; }
        public string MainSlide_caption_data_voffset { get; set; }
        public ICollection<FAQEntity> FAQs { get; set; }
        public ICollection<VideoEntity> VideoFAQs { get; set; }
        public string ShowInMenu { get; set; }

        public string CurrentMinimunPrice { get; set; }
        public string RegularPrice { get; set; }

        public string Surgical { get; set; }

        public bool IsSurgical
        {
            get
            {
                return Surgical != null && Surgical.ToLower() == "true";
            }
        }

        public ICollection<VideoEntity> Videos { get; set; }

        public static string GetUrlParam(string abbreviatedLanguage)
        {
            return
            !string.IsNullOrEmpty(abbreviatedLanguage) &&
            abbreviatedLanguage.ToLower() == "es" ? "urlspanish" : "url";
        }
    }
}