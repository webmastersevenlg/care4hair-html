using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.ViewModels;
using System.Collections.Generic;

namespace BaseProject_7_0.Models.EntityModels.XmlEntities
{
    public class AuthorEntity : BaseXmlEntityModel
    {
        public string Image82 { get; set; }
        public string Image300 { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string JobTitleSpanish { get; set; }
        public string Description { get; set; }
        public string DescriptionSpanish { get; set; }
        public string Featured { get; set; }
        public string HonorificPrefix { get; set; }
        public string HonorificSuffix { get; set; }
        public string HonorificSuffixSpanish { get; set; }
        public string HonorificPrefixSpanish { get; set; }
        public ICollection<BlogPostEntity> BlogPostings { get; set; }
        public static string XmlFilePath = "/app_data/AuthorEntities.xml";
    }
}