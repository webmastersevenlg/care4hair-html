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
        public Language Translation { get; set; }

        public static Language English = new Language()
        {
            AbbreviatedName = "En",
            Name = "English",
            Code = "en-US",
            FlagIconPath = "/themes/care4hair/images/english.png",
            Translation = Language.Spanish
        };

        public static Language Spanish = new Language()
        {
            AbbreviatedName = "Es",
            Name = "Español",
            Code = "es-US",
            FlagIconPath = "/themes/care4hair/images/spanish.png",
            Translation = Language.English
        };

        public static ICollection<Language> All = new Language[]
       {
            English, Spanish
       }; 
    }
}