using BaseProject_7_0.App_Resources;
using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.EntityModels.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public partial class WebSpecialPartialViewModel : IndexablePartialViewModel
    {
        public Nullable<System.DateTime> RunFrom { get; set; }
        public Nullable<System.DateTime> RunUntil { get; set; }
        public string SmallImageEN { get; set; }
        public string LargeImageEN { get; set; }
        public string SmallImageENCensored { get; set; }
        public string LargeImageENCensored { get; set; }
        public string DetailEN { get; set; }
        public string NameES { get; set; }
        public string NameEN { get; set; }
        public string SmallImageES { get; set; }
        public string LargeImageES { get; set; }
        public string SmallImageESCensored { get; set; }
        public string LargeImageESCensored { get; set; }
        public string DetailES { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> dtCreated { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> dtUpdated { get; set; }
        public ICollection<ProfessionalPartialViewModel> Professionals { get; set; }
        public ICollection<ServicePartialViewModel> Services { get; set; }
        public decimal? Price { get; set; }
        public string Includes { get; set; }
        public string IncludesEs { get; set; }

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

        public string GetSpecialName
        {
            get
            {
                return IsEnglish ? NameEN : NameES;
            }
        }

        public string GetIncludesClass
        {
            get
            {
                return GetIncludes != null ? (GetIncludes.Length < 30 ? "small-includes" : "large-includes") : null;
            }
        }

        public string GetImage(string name)
        {
            return "https://" + Settings.GetDomain + "/CDN/specials/" + name;
        }


        public string GetSmallImage
        {
            get
            {
                if (IsLandingPage)
                    return IsEnglishThread || string.IsNullOrEmpty(SmallImageESCensored) ? GetImage(SmallImageENCensored) : GetImage(SmallImageESCensored);
                else
                    return IsEnglishThread || string.IsNullOrEmpty(SmallImageES) ? GetImage(SmallImageEN) : GetImage(SmallImageES);
            }
        }

        public string GetLargeImage
        {
            get
            {
                if (IsLandingPage)
                    return IsEnglishThread || string.IsNullOrEmpty(LargeImageESCensored) ? GetImage(LargeImageENCensored) : GetImage(LargeImageESCensored);
                else
                    return IsEnglishThread || string.IsNullOrEmpty(LargeImageES) ? GetImage(LargeImageEN) : GetImage(LargeImageES);

            }
        }

        public WebSpecialPartialViewModel()
        {
            IndexablePageDetail = new SpecialIndexablePageDetailViewModel();
        }
    }
}
