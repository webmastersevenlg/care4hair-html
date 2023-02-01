using BaseProject_7_0.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class FAQPartialViewModel : IndexablePartialViewModel
    {
        public string Q { get; set; }
        public string A { get; set; }
        public string ServiceId { get; set; }
        public ServicePartialViewModel Service { get; set; }
        public string CategoryId { get; set; }
        public CategoryPartialViewModel Category { get; set; }
        public string Language { get; set; }
        public ImagePartialViewModel Image { get; set; }
    }
}