using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class ImagePartialViewModel
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string AlternateName { get; set; }
        public string Title { get; set; }
    }
}