using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Web;

namespace BaseProject_7_0.Models.BaseModels
{
    public class Language
    {
        public string Name { get; set; }
        public string AbbreviatedName { get; set; }
        public string Code { get; set; }
        public string FlagIconPath { get; set; }

        public static Language Spanish = new Language()
        {
            AbbreviatedName = "Es",
            Name = "Español",
            Code = "es-US",
            FlagIconPath = "/themes/care4hair/images/assets/spanish.png",
        };

        public static Language English = new Language()
        {
            AbbreviatedName = "En",
            Name = "English",
            Code = "en-US",
            FlagIconPath = "/themes/care4hair/images/assets/english.png",
        };

        public static ICollection<Language> AvailableLanguages = new List<Language>() { Spanish, English };

        public ICollection<Language>  AvailableTranslations 
        { 
            get
            {
                return AvailableLanguages.Where(e=>e.Name != Name).ToArray();
            }
        }


        public static ICollection<Language> All = new Language[]
       {
            English, Spanish
       }; 
    }
}