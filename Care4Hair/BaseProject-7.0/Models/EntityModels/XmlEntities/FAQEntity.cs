using BaseProject_7_0.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.EntityModels.XmlEntities
{
    public class FAQEntity : BaseXmlEntityModel
    {
        public string Q { get; set; }
        public string A { get; set; }
        public string ServiceId { get; set; }
        public ServiceEntity Service { get; set; }
        public string CategoryId { get; set; }
        public CategoryEntity Category { get; set; }
        public string Language { get; set; }
        public static string XmlFilePath = "~/app_data/faqentities.xml";
    }
}