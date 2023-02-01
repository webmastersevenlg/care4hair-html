using BaseProject_7_0.Models.BaseModels;
using System.Collections.Generic;

namespace BaseProject_7_0.Models.ViewModels
{
    public class SuperCategoryPartialViewModel : BasePartialViewModel
    {
        public ICollection<CategoryPartialViewModel> Categories { get; set; }
                
        public string GetRelatedVideosLabel(string languageAbreviatedName)
        {
            return
            !string.IsNullOrEmpty(languageAbreviatedName) &&
            languageAbreviatedName.ToLower() == "es" ? "Videos sobre " + GetName : GetName + " Videos";
        }

        public string GetRelatedFAQsLabel(string languageAbreviatedName)
        {
            return
            !string.IsNullOrEmpty(languageAbreviatedName) &&
            languageAbreviatedName.ToLower() == "es" ? "Preguntas y respuestas sobre " + GetName : GetName + " Frequently Asked Questions";
        }

        public string GetRelatedBlogLabel(string languageAbreviatedName)
        {
            return
            !string.IsNullOrEmpty(languageAbreviatedName) &&
            languageAbreviatedName.ToLower() == "es" ? "Entradas de Blog " + GetName : GetName + " Blog Posts";
        }
    }
}