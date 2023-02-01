using BaseProject_7_0.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.EntityModels.XmlEntities
{
    public class SpecialEntity : BaseXmlEntityModel
    {
        public Nullable<System.DateTime> RunFrom { get; set; }
        public Nullable<System.DateTime> RunUntil { get; set; }
        public string NameEN { get; set; }
        public string URLEN { get; set; }
        public Nullable<int> ContactFormEN { get; set; }
        public string SmallImageEN { get; set; }
        public string LargeImageEN { get; set; }
        public string DetailEN { get; set; }
        public string NameES { get; set; }
        public string URLES { get; set; }
        public Nullable<int> ContactFormES { get; set; }
        public string SmallImageES { get; set; }
        public string LargeImageES { get; set; }
        public string DetailES { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> dtCreated { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> dtUpdated { get; set; }
        public int WebContactFormID { get; set; }
        public string WebSContactFormName { get; set; }
        public string WebRelatedProcedures { get; set; }

        public static string XmlFilePath = "~/app_data/specialentities.xml";
    }
}