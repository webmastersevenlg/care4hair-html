using BaseProject_7_0.App_Resources;
using BaseProject_7_0.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class BlogIndexPartialViewModel : BasePartialViewModel
    {
        public string GetPageUrlFiterByCategory( string precticeArea)
        {
            return IsEnglish ? "/blog/" + precticeArea : "/" + Settings.GetSpanishUrl + "/blog/" + precticeArea;
        }

        public string GetElementTypeName
        {
            get {
                return IsEnglish ? "Blog Post" : "Publicación";
            }
        }

        public string GetElementTypeNamePlural
        {
           get
            {
                return IsEnglish ? "Blog" : "Publicaciones";
            }
        }

        public string GetIndexName
        {
            get
            {
                return IsEnglish ? "Blog" : "Publicaciones";
            }
        }

        public override string GetPageUrl(string abbreviatedLanguage)
        {
            return IsEnglishAbbreviation(abbreviatedLanguage) ? "/blog" : "/" + Settings.GetSpanishUrl + "/publicaciones";
        }


         
        public string GetAllElementsLabel
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}