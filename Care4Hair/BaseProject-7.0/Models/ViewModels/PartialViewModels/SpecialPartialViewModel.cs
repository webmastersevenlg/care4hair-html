using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.EntityModels.XmlEntities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using BaseProject_7_0.App_Resources;

namespace BaseProject_7_0.Models.ViewModels
{
    public class SpecialPartialViewModel : BasePartialViewModel
    {
        public string NameEN { get; set; }
        public string URLEN { get; set; }
        public string SmallImageEN { get; set; }

        public string GetImage375x525
        {
            get
            {
                return "https://" + Settings.GetDomain + "/cdn/specials/" + SmallImageEN;
            }
        }

    }
}