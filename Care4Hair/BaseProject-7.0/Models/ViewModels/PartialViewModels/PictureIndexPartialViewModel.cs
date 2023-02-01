using BaseProject_7_0.App_Resources;
using BaseProject_7_0.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class PictureIndexPartialViewModel : BasePartialViewModel
    {
        public string GetPageUrlFiterByCategory(string precticeArea)
        {
            return IsEnglish ? "/videos/" + precticeArea : "/" + Settings.GetSpanishUrl + "/videos/" + precticeArea;
        }

        public string GetPageUrlFiterByProfessional(string lawyer)
        {
            return IsEnglish ? "/videos/?lawyerid=" + lawyer : "/" + Settings.GetSpanishUrl + "/videos/?lawyerid=" + lawyer;
        }

        public string GetElementTypeName
        {
            get
            {
                return IsEnglish ? "Picture" : "Foto";
            }
        }

        public string GetElementTypeNamePlural
        {
            get
            {
                return IsEnglish ? "Pictures" : "Fotos";
            }
        }

        public string GetIndexName
        {
            get
            {
                return IsEnglish ? "Gallery" : "Galería";
            }
        }

        public string GetAllElementsLabel
        {
            get
            {
                return IsEnglish ? "All Pictures" : "Todas Las Fotos";
            }
        }

        public override string GetPageUrl(string abbreviatedLanguage)
        {           
            return IsEnglishAbbreviation(abbreviatedLanguage) ? "/before-and-after" : "/" + Settings.GetSpanishUrl + "/fotos-de-antes-y-despues";           
        }

        public string GetPageUrlByProfessional(string professionalId)
        {
            return IsEnglish ? "/before-and-after/" + professionalId : "/" + Settings.GetSpanishUrl + "/fotos-de-antes-y-despues/" + professionalId;
        }       
    }
}
