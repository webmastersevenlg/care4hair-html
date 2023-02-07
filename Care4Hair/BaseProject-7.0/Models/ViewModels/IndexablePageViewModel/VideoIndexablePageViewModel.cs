using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.EntityModels.XmlEntities;
using Shyjus.BrowserDetection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class VideoIndexablePageViewModel : IndexablePageViewModel
    {
        //this field is for easy navidation to the entityModel that this map from.
        public VideoEntity NeverUsedField;

        public string Title { get; set; }
        public string Src { get; set; }
        public string Thumbnail { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        public string Transcription { get; set; }
        public string About { get; set; }
        public string Genre { get; set; }
        public string TargeredKeyword { get; set; }
        public string DateCreated { get; set; }
        public string DatePublished { get; set; }
        public string DateModificate { get; set; }
        public CategoryPartialViewModel Category { get; set; }
        public ServicePartialViewModel Service { get; set; }
        public ICollection<ProfessionalPartialViewModel> Professionals { get; set; }
        public ICollection<TagPartialViewModel> Tags { get; set; }
        public int Priority { get; set; }
        public ImagePartialViewModel Image { get; set; }
        public VideoPartialViewModel Video { get; set; }
        public ICollection<VideoPartialViewModel> SameServiceVideos { get; set; }
        public ICollection<VideoPartialViewModel> SameCategoryVideos { get; set; }

        public string GetMetasFilePath
        {
            get
            {
                return "content/articlemetas";
            }
        }


        public string GetDatePublished
        {
            get
            {
                DateTime result;
                var isValidDate = DateTime.TryParse(DatePublished, out result);

                return isValidDate ? result.Date.ToString("MMM dd, yyyy") : DatePublished;
            }
        }

        public override AltLangRef GetAltLangRef
        {
            get
            {
                return new AltLangRef(GetPageUrl(), CurrentLanguage);
            }
        }

        public VideoIndexablePageViewModel(IWebHostEnvironment _webHostingEnviroment, IHttpContextAccessor _httpContextAccessor, IBrowserDetector _browserDetector) : base(_webHostingEnviroment, _httpContextAccessor, _browserDetector)
        {
            IndexablePageDetail = new SpecialIndexablePageDetailViewModel();
            SkinName = "VideoPageSkin";
        }
    }
}