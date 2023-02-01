using BaseProject_7_0.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class BlogPostIndexablePageDetailViewModel : IndexablePageDetailViewModel
    {            
        public BlogPostIndexablePageDetailViewModel()
        {
            UrlSection = "blog-post";
            UrlSectionSpanish = "publicacion";
        }
    }
}
