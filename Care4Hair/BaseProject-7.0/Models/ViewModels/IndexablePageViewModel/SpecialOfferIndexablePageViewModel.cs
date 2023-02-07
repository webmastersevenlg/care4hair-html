using BaseProject_7_0.Models.BaseModels;
using Shyjus.BrowserDetection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class SpecialOfferIndexablePageViewModel : IndexablePageViewModel
    {
        public string Active { get; set; }
        public string ServiceName { get; set; }
        public string Includes { get; set; }
        public string Requirements { get; set; }
        public string DateTo { get; set; }
        public string Price { get; set; }
        public string RegularPrice { get; set; }

        public string Discount 
        {
            get { return (int.Parse(RegularPrice) - int.Parse(Price)).ToString();  }        
        }


        public SpecialOfferIndexablePageViewModel(IWebHostEnvironment _webHostingEnviroment, IHttpContextAccessor _httpContextAccessor, IBrowserDetector _browserDetector) : base(_webHostingEnviroment, _httpContextAccessor, _browserDetector)
        {
            IndexablePageDetail = new SpecialOfferIndexablePageDetailViewModel();
            SkinName = "SpecialOfferPageSkin";
            ImagesFolderPath = "/content/images/financing_options";
        }
    }
}