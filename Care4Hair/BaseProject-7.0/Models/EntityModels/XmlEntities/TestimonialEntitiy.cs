using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.EntityModels.XmlEntities
{
    public class TestimonialEntity : BaseXmlEntityModel
    {
        //this fields are for easy navidation to the entityModel that map from this class.
        public TestimonialPartialViewModel NeverUsedField1;

        public string AbbreviatedLanguage { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Source { get; set; }
        public string Date { get; set; }
        public static string XmlFilePath = "/app_data/TestimonialEntities.xml";
    }
}