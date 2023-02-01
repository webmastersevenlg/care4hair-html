using BaseProject_7_0.App_Resources;
using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.EntityModels.XmlEntities;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class ProfessionalIndexablePageDetailViewModel : IndexablePageDetailViewModel
    {
        public override string GetIndexablePageUrl(string abbreviatedLanguage)
        {
            return IsEnglishAbbreviation(abbreviatedLanguage) ? "/" + Url : "/" + Settings.GetSpanishUrl + "/" + Url;
        }
    }
}
