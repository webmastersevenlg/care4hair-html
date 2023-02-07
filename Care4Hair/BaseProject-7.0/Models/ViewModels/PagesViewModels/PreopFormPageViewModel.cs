using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseProject_7_0.Models.EntityModels.DbEntities;
using BaseProject_7_0.Models.EntityModels.XmlEntities;
using BaseProject_7_0.XmlTools;
using Shyjus.BrowserDetection;

namespace BaseProject_7_0.Models.ViewModels
{
    public class PreopFormPageViewModel : BasePageWithStaticHtmlFilesViewModel
    {
        public PreopFormDataTransferViewModel FormData;

        public PreopFormPageViewModel(IWebHostEnvironment _webHostingEnviroment, IHttpContextAccessor _httpContextAccessor, IBrowserDetector _browserDetector) : base(_webHostingEnviroment, _httpContextAccessor, _browserDetector)
        { 
        }
    }    
}