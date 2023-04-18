using BaseProject_7_0.App_Resources;
using BaseProject_7_0.Models.EntityModels.XmlEntities;
using BaseProject_7_0.Models.ViewModels;
using BaseProject_7_0.Tools;
using BaseProject_7_0.XmlTools;
using Shyjus.BrowserDetection;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace BaseProject_7_0.Models.BaseModels
{
    public abstract class BasePageViewModel : BaseViewModel
    {                
        public virtual string GetH1 { get; set; }
        public string SkinName { get; set; }
        public string H1Tagline { get; set; }
        public string PageDescription { get; set; }
        public string MainKeyword { get; set; }
        public string Article { get; set; }
        public string Banner { get; set; }
        public string ReturnUrl { get; set; }
        public string HeaderType { get; set; }
        public string PageTitle { get; set; }
        public string Slide { get; set; }
        public string Refresh { get; set; }
        public string MainContactFormName { get; set; }
    


        public Site SitePages { get; set; }
        

        //multilingual fields
        public string AmpUrl { get; set; }
        public string AmpUrlSpanish { get; set; }


        

        //properties  
        public virtual AltLangRef GetAltLangRef
        {
            get
            {
                if (IsEnglish)
                {
                    return new AltLangRef(("/"+Settings.GetSpanishUrl+"/" + UrlSpanish).TrimEnd('/'), Language.Spanish);
                }

                return new AltLangRef("/" + Url, Language.English);
            }
        }

        private void SetLanguageAndDeviceAndSource()
        {
            //set referrer
            var request = httpContextAccessor?.HttpContext?.Request;
            var userAgent = request?.Headers.UserAgent.ToString();
            var referer = request?.GetTypedHeaders()?.Referer;
            var referrerAbsoluteUri = referer?.AbsoluteUri;
            var query = QueryHelpers.ParseQuery(referer?.Query); 
            

            Referrer = !string.IsNullOrEmpty(referrerAbsoluteUri) ? referrerAbsoluteUri : "Direct Traffic";

            VisitSource = GetVisitSource.GetByRequest(referer, query, userAgent);

            //set IsMobile
            IsMobile = browserDetector.Browser.DeviceType == "Mobile" ? true : false;

            //set current language
            CurrentLanguage = Language.All.FirstOrDefault(l => l.AbbreviatedName.ToLower() == GetabbreviatedLanguage);

        }

        public BasePageViewModel(IHttpContextAccessor _httpContextAccessor, IBrowserDetector _browserDetector) : base (_httpContextAccessor, _browserDetector)
        {
         
            SetLanguageAndDeviceAndSource();
        }

       
    }
}
