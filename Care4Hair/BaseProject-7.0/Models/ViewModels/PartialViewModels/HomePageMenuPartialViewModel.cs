using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class HomePageMenuPartialViewModel
    {
        public string Language { get; set; }
        public ICollection<ServiceGroupPartialViewModel> ServiceGroups { get; set; }
        public ICollection<ProfessionalPartialViewModel> Professionals { get; set; }
        public ICollection<CategoryPartialViewModel> Categories { get; set; }
        public ICollection<VideoPartialViewModel> Videos { get; set; }
        public ServicePartialViewModel Service { get; set; }

        public string GetServiceGroupsClass
        {
            get
            {
                return "col-md-" + 12 / ServiceGroups.Count() + " col-sm-" + 12 / ServiceGroups.Count() + " col-xs-12";
            }
        }
        public string GetProfessionalGroupsClass
        {
            get
            {
                return "col-md-" + 12 / Professionals.Count() + " col-sm-" + 12 / Professionals.Count() + " col-xs-12";
            }
        }

        public string GetContactUrl
        {
            get
            {
                return
                    Language != null && Language.ToLower() == "es" ? "/es/contacto" : "/contact";
            }
        }

        public string GetAboutUrl
        {
            get
            {
                return
                    Language != null && Language.ToLower() == "es" ? "/es/quienes-somos" : "/about";
            }
        }

        public string GetVideoFaqsUrl
        {
            get
            {
                return
                    Language != null && Language.ToLower() == "es" ? "/es/videos?tag=faq" : "/videos?tag=faq";
            }
        }
    }
}