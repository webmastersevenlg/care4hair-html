using BaseProject_7_0.App_Resources;
using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.EntityModels.XmlEntities;
using System;
using System.Collections.Generic;


namespace BaseProject_7_0.Models.ViewModels
{
    public class VideoPartialViewModel : IndexablePartialViewModel
    {
        //this field is for easy navidation to the entityModel that this map from.
        public VideoEntity NeverUsedField;

        public string Language { get; set; }
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
        public string FileName { get; set; }
        public CategoryPartialViewModel Category { get; set; }
        public ServicePartialViewModel Service { get; set; }
        public ICollection<ProfessionalPartialViewModel> Professionals { get; set; }
        public ICollection<TagPartialViewModel> Tags { get; set; }        
        public ImagePartialViewModel Image { get; set; }

        public string GetShortTitle
        {
            get
            {
                return
                    Title.Length > 33 ? Title.Substring(0, 29)+"..." : Title;
            }
        }

        public string GetUrl
        {
            get
            {
                return
                !string.IsNullOrEmpty(Language) &&
                Language.ToLower() == "es" ? "/es/video/"+Url : "/attorney-video/" + Url;
            }
        }

        public string GetThumbnail
        {
            get
            {
                return ImagesFolderPath + Src + "/maxresdefault.jpg";
            }
        }

        public override string GetImage()
        {
                return ImagesFolderPath + Src + "/hqdefault.jpg";            
        }

        public string GetVideoFileName
        {
            get
            {
                var sitePath = "https://avanaplasticsurgery.com";
                var videoPath = bool.Parse(Settings.UseCdn) ? Settings.CdnPath : sitePath;
                return videoPath + "/cdn/videos/" + Url + ".mp4";
            }
        }

        public string GetVideoYoutubeEmbedUrl
        {
            get
            {
                return "https://www.youtube.com/embed/" + Src ;
            }
        }

        public override string GetPageUrl(string abbreviatedLanguage)
        {
            return IsEnglishAbbreviation(abbreviatedLanguage) ? "/video/" + Url : "/" + Settings.GetSpanishUrl + "/video/" + Url;
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

        public VideoPartialViewModel()
        {
            IndexablePageDetail = new VideoIndexablePageDetailViewModel();
            ImagesFolderPath = "https://i.ytimg.com/vi/";
        }
    }
}