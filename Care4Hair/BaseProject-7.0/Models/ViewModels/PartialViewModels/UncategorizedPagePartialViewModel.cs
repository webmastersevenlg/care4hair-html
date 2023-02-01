using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseProject_7_0.App_Resources;
using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.EntityModels.XmlEntities;

namespace BaseProject_7_0.Models.ViewModels
{
    public class UncategorizedPagePartialViewModel : BasePartialViewModel
    {
        //this field is for easy navidation to the entityModel that this map from.
        public UncategorizedPageEntity NeverUsedField;

        public string GetUrl(string languageabbreviatedLanguage)
        {
            return languageabbreviatedLanguage.ToLower() == "es" ? "/" + Settings.GetSpanishUrl : "/";
        }
    }
}