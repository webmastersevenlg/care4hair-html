using BaseProject_7_0.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.EntityModels.XmlEntities
{
    public class SpecialOfferEntity : BaseXmlEntityModel
    {

        public string ServiceName { get; set; }
        public string Requirements { get; set; }
        public string Includes { get; set; }
        public string DateTo { get; set; }
        public string RegularPrice { get; set; }
        public string Price { get; set; }

        public static string XmlFilePath = "~/app_data/specialofferentities.xml";
    }
}