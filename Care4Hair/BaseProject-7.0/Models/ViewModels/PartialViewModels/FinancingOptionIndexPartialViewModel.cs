using BaseProject_7_0.App_Resources;
using BaseProject_7_0.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class FinancingOptionIndexPartialViewModel : BasePartialViewModel
    {
        public string GetIndexName
        {
            get 
            {
                return IsEnglish ? "Financing Options" : "Opcion De Financiamiento";
            }
        }

        public string GetElementTypeName
        {
            get
            {
                return IsEnglish ? "Financing Option" : "Opcion De Financiamiento";
            }
        }
        public string GetElementTypeNamePlural
        {
            get
            {
                return IsEnglish ? "Financing Options" : "Opciones De Financiamiento";
            }
        }
        public string GetAllElementsLabel
        {
            get
            {
                return IsEnglish ? "All Financing Options" : "Todas Las Opciones De Financiamiento";
            }
        }

        public override string GetPageUrl(string abbreviatedLanguage)
        {
            return IsEnglishAbbreviation(abbreviatedLanguage) ? "/financing-options" : "/" + Settings.GetSpanishUrl + "/opciones-de-financiamiento";           
        }
    }
}