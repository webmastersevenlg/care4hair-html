using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.EntityModels.XmlEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class VideoIndexablePageDetailViewModel : IndexablePageDetailViewModel
    {
        public VideoIndexablePageDetailViewModel()
        {
            UrlSection = "video";
            UrlSectionSpanish = "video";
        }
    }
}
