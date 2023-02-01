using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.BaseModels
{
    public class Language
    {
        public string Name { get; set; }
        public string AbbreviatedName { get; set; }
        public string Code { get; set; }
        public string FlagIconPath { get; set; }

        public static Language English = new Language()
        {
            AbbreviatedName = "En",
            Name = "English",
            Code = "en-US",
            FlagIconPath = "/content/images/jpg/english1.png"
        };

        public static Language Spanish = new Language()
        {
            AbbreviatedName = "Es",
            Name = "Español",
            Code = "es-US",
            FlagIconPath = "/content/images/jpg/espanol1.png"
        };

        public static ICollection<Language> All = new Language[]
       {
            English, Spanish
       };


 
    }
}