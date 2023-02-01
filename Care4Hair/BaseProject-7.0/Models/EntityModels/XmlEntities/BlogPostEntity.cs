using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.ViewModels;
using System.Collections.Generic;

namespace BaseProject_7_0.Models.EntityModels.XmlEntities
{
    public class BlogPostEntity : BaseXmlEntityModel
    {
        public override string Id { get { return ImageName; } }
        public string Language { get; set; }
        public string Title { get; set; }
        public string Intro { get; set; }
        public string Description { get; set; }
        public string About { get; set; }
        public string Genre { get; set; }
        public string TargeredKeyword { get; set; }
        public string DateCreated { get; set; }
        public string DatePublished { get; set; }
        public string DateModificate { get; set; }
        public string Featured { get; set; }
        public string ImageName { get; set; }
        public AuthorEntity Author { get; set; }
        public CategoryEntity Category { get; set; }
        public ServiceEntity  Service { get; set; }
        public ICollection<ProfessionalEntity> Professionals { get; set; }
        public ICollection<TagEntity> Tags { get; set; }
        public static string XmlFilePath = "/app_data/BlogPostEntities.xml";
    }
}