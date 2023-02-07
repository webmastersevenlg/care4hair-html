using BaseProject_7_0.Models.BaseModels;
using Shyjus.BrowserDetection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class FinancingOptionIndexablePageViewModel : IndexablePageViewModel
    {
        public string ProviderUrl { get; set; }

        public FinancingOptionIndexablePageViewModel(IWebHostEnvironment _webHostingEnviroment, IHttpContextAccessor _httpContextAccessor, IBrowserDetector _browserDetector) : base(_webHostingEnviroment, _httpContextAccessor, _browserDetector)
        {            
            IndexablePageDetail = new FinancingOptionIndexablePageDetailViewModel();
            SkinName = "FinancingOptionPageSkin";
            ImagesFolderPath = "/content/images/financing_options";
        }
    }
}