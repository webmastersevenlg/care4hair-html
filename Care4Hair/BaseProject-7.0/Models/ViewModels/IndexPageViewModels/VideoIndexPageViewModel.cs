using BaseProject_7_0.App_Resources;
using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.ViewModels;
using Shyjus.BrowserDetection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class VideoIndexPageViewModel : IndexPageViewModel
    {
        public VideoIndexPageViewModel(IWebHostEnvironment _webHostingEnviroment, IHttpContextAccessor _httpContextAccessor, IBrowserDetector _browserDetector) : base(_webHostingEnviroment, _httpContextAccessor, _browserDetector)
        {
            IndexDetail = new VideoIndexPageDetailViewModel();
        }
    }
}

