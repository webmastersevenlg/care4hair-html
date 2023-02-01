using System;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using System.Reflection;
using BaseProject_7_0.XmlTools;

namespace BaseProject_7_0.Models.BaseModels
{
    public class BaseXmlEntityModel : BaseModel
    {
        public virtual string Id { get; set; }
        public string Url { get; set; }
        public virtual string UrlSpanish { get; set; }
        public string DbUrl { get; set; }
        public string DbUrlSpanish { get; set; }
        public string Active { get; set; }
    }
}