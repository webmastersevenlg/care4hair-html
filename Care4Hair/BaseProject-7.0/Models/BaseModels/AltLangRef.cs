using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.BaseModels
{
    public class AltLangRef
    {
        public string Href { get; set; }

        public Language Language { get; set; }

        public AltLangRef(string href, Language language)
        {
            Href = href;
            Language = language;
        }
    }    
}