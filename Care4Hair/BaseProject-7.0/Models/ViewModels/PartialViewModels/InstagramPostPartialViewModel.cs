using BaseProject_7_0.App_Resources;
using BaseProject_7_0.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class InstagramPostPartialViewModel : IndexablePartialViewModel
    {
        public string Date { get; set; }
        public DateTime GetDate
        {
            get
            {
                return DateTime.Parse(Date);
            }
        }

        public string GetLink
        {
            get
            {
                return "https://www.instagram.com/p/" + Id + "/";
            }
        }

        public int ProfessionalId { get; set; }
        public ProfessionalPartialViewModel Professional { get; set; }
        public int ServiceId { get; set; }
        public ServicePartialViewModel Service { get; set; }

        public static string XmlFilePath = "false";

        public static string GetProfessionalIdAttributeName(string languageabbreviatedLanguage)
        {
            return
            !string.IsNullOrEmpty(languageabbreviatedLanguage) &&
            languageabbreviatedLanguage.ToLower() == "es" ? "ProfessionalUrl" : "ProfessionalUrl";
        }

        public static string GetServiceIdAttributeName(string languageabbreviatedLanguage)
        {
            return
            !string.IsNullOrEmpty(languageabbreviatedLanguage) &&
            languageabbreviatedLanguage.ToLower() == "es" ? "ServiceUrl" : "ServiceUrl";
        }

        public InstagramPostPartialViewModel()
        {
            ImagesFolderPath = "/content/images/instagram_posts";
        }
    }
}