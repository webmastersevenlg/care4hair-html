using BaseProject_7_0.App_Resources;
using BaseProject_7_0.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class ProfessionalIndexPartialViewModel : BasePartialViewModel
    {
        public ICollection<ProfessionalPartialViewModel> Professionals { get; set; }


        public string GetIndexName
        {
            get
            {
                return IsEnglish ? "Medical Staff" : "Personal Médico";
            }
        }


        public string GetElementTypeName
        {
            get
            {
                return Settings.GetProfessionalsProfession;
            }
        }

        public string GetElementTypeNamePlural
        {
            get
            {
                return Settings.GetProfessionalsProfessionPlural;
            }
        }

        public string GetAllElementsLabel
        {
            get
            {
                return IsEnglish ? "Medical Staff" : "Personal Médico";
            }
        }

        public override string GetPageUrl(string abbreviatedLanguage)
        {
                return IsEnglishAbbreviation(abbreviatedLanguage) ? "/medical-staff" : "/" + Settings.GetSpanishUrl + "/personal-medico";            
        }
    }
}