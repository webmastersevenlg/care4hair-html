using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.EntityModels.XmlEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class TestimonialPartialViewModel : IndexablePartialViewModel
    {
        //this fields is for easy navigation to the entityModel that this map from.
        public TestimonialEntity NeverUsedField;

        public string AbbreviatedLanguage { get; set; }
        public string Text { get; set; }
        public string Source { get; set; }
        public string Date { get; set; }        
    }
}