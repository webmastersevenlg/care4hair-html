using System;
using BaseProject_7_0.Models.BaseModels;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseProject_7_0.App_Resources;

namespace BaseProject_7_0.Models.ViewModels
{
    public class FAQIndexPartialViewModel : BasePartialViewModel
    {
        public string GetElementTypeName
        {
            get
            {
                return IsEnglish ? "Frequently Asked Question" : "Pregunta y Respuesta";
            }
        }

        public string GetElementTypeNamePlural
        {
            get
            {
                return IsEnglish ? "Frequently Asked Questions" : "Preguntas y Respuestas";
            }
        }

        public string GetAllElementsLabel
        {
            get
            {
                return IsEnglish ? "All Frequently Asked Questions" : "Todas las Preguntas y Respuestas";
            }
        }

        public string GetIndexName
        {
            get
            {
                return IsEnglish ? "FAQs" : "Preguntas Y Respuestas";
            }
        }

        public override string GetPageUrl(string abbreviatedLanguage)
        {
            return IsEnglishAbbreviation(abbreviatedLanguage) ? "/frequently-asked-questions" : Settings.GetSpanishUrl + "/preguntas-y-respuestas";
        }       
    }
}