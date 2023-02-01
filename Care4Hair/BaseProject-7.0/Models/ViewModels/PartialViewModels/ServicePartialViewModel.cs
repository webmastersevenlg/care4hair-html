using BaseProject_7_0.App_Resources;
using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.EntityModels.XmlEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class ServicePartialViewModel : BasePartialViewModel
    {
        //this fields is for easy navigation to the entityModel that this map from.
        public ServiceEntity NeverUsedField;
        
        public string DbUrl { get; set; }
        public string DbUrlSpanish { get; set; }
        public string ShortName { get; set; }
        public string ShortNameSpanish { get; set; }
        public ICollection<CategoryPartialViewModel> Categories;
        public ICollection<BlogPostPartialViewModel> BlogPostings;
        public ICollection<ProfessionalPartialViewModel> Professionals;
        public string ServiceGroupName { get; set; }
        public string ServiceGroupNameSpanish { get; set; }
        public string CurrentMinimunPrice { get; set; }
        public string RegularPrice { get; set; }
        public string ShowInMenu { get; set; }
        public string HasCategoryPageBriefDescription { get; set; }

        public string GetShortName
        {
            get
            {
                return IsEnglish ? ShortName : ShortNameSpanish;
            }
        }

        public string GetDbUrl
        {
            get
            {
                return IsEnglish ? DbUrl : DbUrlSpanish;
            }
        }

        public string GetFeatureImage(string resolution)
        {
            return ImagesFolderPath +"/"+ "featured-services-" + resolution + "/" + Id + ".jpg";
        }

        public string GetBriefIntroForCategoryPage
        {
            get
            {
                return "~/views/servicepage/content/"+ Url + "/" + GetabbreviatedLanguage + "/briefintroforcategorypage.cshtml";
            }
        }
         

        //static members
        //============================================================================================
        public static string GetEntityName()
        {
            return IsEnglishThread ? "Servicio" : "Servicios";
        }

        public ServicePartialViewModel()
        {
            ImagesFolderPath = "/Content/images/services";
        }
    }
}