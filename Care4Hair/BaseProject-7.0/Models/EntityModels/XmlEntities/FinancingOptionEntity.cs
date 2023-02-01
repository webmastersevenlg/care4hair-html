using BaseProject_7_0.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.EntityModels.XmlEntities
{
    public class FinancingOptionEntity : BaseXmlEntityModel
    {
        public string Name { get; set; }
        public string ProviderUrl { get; set; }
        public string LogoFileName { get; set; }
        public string Slogan { get; set; }
        public string SloganSpanish { get; set; }
        public static string XmlFilePath = "~/app_data/financingoptionentities.xml";
        public override string UrlSpanish { get { return Url; } }
    }
}