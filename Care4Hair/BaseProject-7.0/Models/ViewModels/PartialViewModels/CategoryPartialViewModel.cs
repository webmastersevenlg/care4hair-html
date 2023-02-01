using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.EntityModels.XmlEntities;
using System.Collections.Generic;
namespace BaseProject_7_0.Models.ViewModels
{
    public class CategoryPartialViewModel : BasePartialViewModel
    {
        //this fields is for easy navigation to the entityModel that this map from.
        public CategoryEntity NeverUsedField;

        public string Icon { get; set; }
        public bool IsSelected { get; set; }
        public int BlogPostingsCount { get; set; }
        public int VideosCount { get; set; }
        public int FAQsCount { get; set; }
        
        public ICollection<ServicePartialViewModel> Services { get; set; }

        public string GetIcon
        {
            get
            {
                return "/Content/images/services/" + Icon;
            }
        }

        public string GetRelatedVideosLabel
        {
            get
            {
                return IsEnglish ? GetName + " Videos" : "Videos sobre " + GetName;
            }
        }

        public string GetRelatedFAQsLabel
        {
            get
            {
                return IsEnglish ? GetName + " Frequently Asked Questions" : "Preguntas y respuestas sobre " + GetName;
            }
        }

        public string GetRelatedBlogLabel
        {
            get
            {
                return IsEnglish ? "Entradas de Blog " + GetName : GetName + " Blog Posts";
            }
        }

        //static members
        //============================================================================================
        public static string GetEntityName(string abbreviatedLanguage)
        {
            return IsEnglishAbbreviation(abbreviatedLanguage) ? "Category" : "Categoria";
        }
    }
}