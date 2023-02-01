using BaseProject_7_0.App_Resources;
using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.EntityModels.XmlEntities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class SpecialIndexPartialViewModel : BasePartialViewModel
    {
        public ICollection<WebSpecialPartialViewModel> Specials { get; set; }

        public string GetElementTypeName
        {
            get
            {
                return IsEnglish ? "Special Offer" : "Offerta Especial";
            }
        }

        public string GetElementTypeNamePlural
        {
            get
            {
                return IsEnglish ? "Specials" : "Especiales";
            }
        }

        public string GetIndexName
        {
            get
            {
                return IsEnglish ? "Specials" : "Especiales";
            }
        }

        public string GetAllElementsLabel
        {
            get
            {
                return IsEnglish ? "All Specials" : "Todos Los Especiales";
            }
        }
        
        public override string GetPageUrl(string abbreviatedLanguage)
        {
            return IsEnglishAbbreviation(abbreviatedLanguage) ? "/specials" : "/" + Settings.GetSpanishUrl + "/especiales";
        }
    }
}