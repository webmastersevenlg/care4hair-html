using BaseProject_7_0.App_Resources;
using BaseProject_7_0.Models.BaseModels;
using System;
using System.Collections.Generic;

namespace BaseProject_7_0.Models.ViewModels
{
    public class BlogPostPartialViewModel : IndexablePartialViewModel
    {
        public string Intro { get; set; }
        public string Description { get; set; }
        public string About { get; set; }
        public string Genre { get; set; }
        public string TargeredKeyword { get; set; }
        public string DateCreated { get; set; }
        public string DatePublished { get; set; }
        public string DateModificate { get; set; }        
        public ImagePartialViewModel Image { get; set; }
        public AuthorPartialViewModel Author { get; set; }
        public ICollection<TagPartialViewModel> Tags { get; set; }
        public CategoryPartialViewModel Category { get; set; }
        public ServicePartialViewModel Service { get; set; }
        public VideoPartialViewModel Video { get; set; }

        public string GetIntro
        {
            get
            {
                return Intro.ToCharArray().Length > 360 ? Intro.Substring(0, 360) : Intro;
            }
        }

        public override string GetPageUrl(string abbreviatedLanguage)
        {
            return IsEnglishAbbreviation(abbreviatedLanguage) ? "/blog-post/" + Url : "/"+Settings.GetSpanishUrl + "/publicacion/" + Url;
        }

        public string GetDateCreated
        {
            get
            {
                return DateTime.Parse(DateCreated).Date.ToString("MMM dd, yyyy");
            }
        }

        public BlogPostPartialViewModel()
        {
            IndexablePageDetail = new BlogPostIndexablePageDetailViewModel();
            ImagesFolderPath = "/content/images/blogposts";
        }
    }
}