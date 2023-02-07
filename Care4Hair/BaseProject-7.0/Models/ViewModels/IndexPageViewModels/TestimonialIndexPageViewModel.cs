using BaseProject_7_0.App_Resources;
using BaseProject_7_0.Models.BaseModels;
using Shyjus.BrowserDetection;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class TestimonialIndexPageViewModel : IndexPageViewModel
    {
        public TestimonialIndexPageViewModel(IWebHostEnvironment _webHostingEnviroment, IHttpContextAccessor _httpContextAccessor, IBrowserDetector _browserDetector) : base(_webHostingEnviroment, _httpContextAccessor, _browserDetector)
        {
            IndexDetail = new TestimonialIndexPageDetailViewModel();
        }
    }
}