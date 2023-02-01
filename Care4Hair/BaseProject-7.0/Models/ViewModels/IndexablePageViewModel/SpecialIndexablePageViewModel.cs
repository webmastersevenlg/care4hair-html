using BaseProject_7_0.App_Resources;
using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.EntityModels.XmlEntities;
using Shyjus.BrowserDetection;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class SpecialIndexablePageViewModel : IndexablePageViewModel
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
        public Nullable<int> WebContactFormID { get; set; }
        public string WebSContactFormName { get; set; }
        public int Priority { get; set; }
        public decimal? Price { get; set; }
        public string Includes { get; set; }
        public string IncludesEs { get; set; }

        public ICollection<WebSpecialPartialViewModel> RelatedSpecials { get; set; }
        public ICollection<ProfessionalPartialViewModel> Professionals { get; set; }
        public ICollection<ServicePartialViewModel> Services { get; set; }


        public string GetPrice
        {
            get
            {
                return Price != null && Price > 0 ? string.Format("${0:n0}", Price.Value) : "";
            }
        }

        public string GetIncludes
        {
            get
            {
                return IsEnglish ? Includes : IncludesEs;
            }
        }

        public string GetIncludesClass
        {
            get
            {
                return GetIncludes != null ? (GetIncludes.Length < 30 ? "small-includes" : "large-includes") : null;
            }
        }

        public string GetMetasFilePath
        {
            get
            {
                return "content/articlemetas";
            }
        }

        public string GetDetail
        {
            get
            {
                return IsEnglish ? DetailEN : DetailES;
            }
        }

        public string GetSmallImage
        {
            get
            {
                //return IsMobile || string.IsNullOrEmpty(SmallImageES) ? SmallImageEN : SmallImageES;
                return IsEnglishThread || string.IsNullOrEmpty(SmallImageES) ? GetImage(SmallImageEN) : GetImage(SmallImageES);
            }
        }

        public string GetLargeImage
        {
            get
            {
                //return IsEnglish || string.IsNullOrEmpty(LargeImageES) ? LargeImageEN : LargeImageES;
                return IsEnglishThread || string.IsNullOrEmpty(LargeImageES) ? GetImage(LargeImageEN) : GetImage(LargeImageES);
            }
        }

        public override string GetImage()
        {
            return IsMobile ? ImagesFolderPath + GetSmallImage : ImagesFolderPath + GetLargeImage;
        }

        public string GetImage(string name)
        {
            return "https://" + Settings.GetSpecialsCdnDomain + "/CDN/specials/" + name;
        }

        public SpecialIndexablePageViewModel(IHttpContextAccessor _httpContextAccessor, IBrowserDetector _browserDetector) : base(_httpContextAccessor, _browserDetector)
        {
            IndexablePageDetail = new SpecialIndexablePageDetailViewModel();
            SkinName = "SpecialPageSkin";
            ImagesFolderPath = "https://" + Settings.GetDomain + "/cdn/specials/";
        }
    }
}