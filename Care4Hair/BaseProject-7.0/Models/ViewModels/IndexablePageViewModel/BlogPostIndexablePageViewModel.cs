using BaseProject_7_0.Models.BaseModels;
using Shyjus.BrowserDetection;
using System;
using System.Collections.Generic;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class BlogPostIndexablePageViewModel : IndexablePageViewModel
    {        
        public string Title { get; set; }
        public string Intro { get; set; }
        public string Description { get; set; }
        public string About { get; set; }
        public string Genre { get; set; }
        public string TargeredKeyword { get; set; }
        public string DateCreated { get; set; }
        public string DatePublished { get; set; }
        public string DateModificate { get; set; }
        public string Featured { get; set; }
        public int Priority { get; set; }
        public ImagePartialViewModel Image { get; set; }
        public AuthorPartialViewModel Author { get; set; }
        public ICollection<TagPartialViewModel> Tags { get; set; }
        public CategoryPartialViewModel Category { get; set; }
        public ServicePartialViewModel Service { get; set; }
        public BlogPostPartialViewModel BlogPost { get; set; }
        public ICollection<BlogPostPartialViewModel> SameServiceBlogPosts { get; set; }
        public ICollection<BlogPostPartialViewModel> SameCategoryBlogPosts { get; set; }
        
        public string GetDateModifiedInShortFormat
        {
            get
            {
                return DateTime.Parse(DateModificate).ToString("dd MMM, yyyy");
            }
        }               
 

        public override AltLangRef GetAltLangRef
        {
            get
            {
                return new AltLangRef(GetPageUrl(), CurrentLanguage);
            }
        }

        public string GetH1
        {
            get
            {
                return Title;
            }
        }

        public BlogPostIndexablePageViewModel(IHttpContextAccessor _httpContextAccessor, IBrowserDetector _browserDetector) : base (_httpContextAccessor, _browserDetector)
        {
            IndexablePageDetail = new BlogPostIndexablePageDetailViewModel();
            SkinName = "BlogPostPageSkin";
            ImagesFolderPath = "/content/images/blogposts";
        }
    }
}
