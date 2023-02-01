using BaseProject_7_0.App_Resources;
using BaseProject_7_0.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class ServiceGalleryThumbnailPartialViewModel : BasePartialViewModel
    {
        public ProfessionalPartialViewModel Professional { get; set; }
        public ServicePartialViewModel Service { get; set; }
        public string SingleResultImage { get; set; }
        public string CollageResultImage { get; set; }
        public string LinkToGalleryText(string languageabbreviatedLanguage)
        {
            return languageabbreviatedLanguage.ToLower() == "en"
                ?  Service.GetName + " " + Vocabulary.Pictures
                :  Vocabulary.Pictures + " " + Vocabulary.Of + " " + Service.GetName;
        }       
    }
}