using BaseProject_7_0.Models.ViewModels;
using Shyjus.BrowserDetection;

namespace BaseProject_7_0.Models.BaseModels
{
    public abstract class IndexPageViewModel : BasePageWithStaticHtmlFilesViewModel
    {
        public IndexPageDetailViewModel IndexDetail { get; set; }
        public string SearchUrl { get; set; }
        public string SearchQuery { get; set; }
        public string SearchRemovalLink { get; set; }

        public string IndexName { get; }
        public ICollection<IndexablePartialViewModel> AllElements { get; set; }
        public string ElementName { get; set; }
        public RouteValueDictionary CurrentFilters { get; set; }

        public string GetServiceName
        {
            get
            {
                return FilterGroups.FirstOrDefault(f => f.FilterParamName  == "dbServiceUrl")?
                       .FilterOptions.FirstOrDefault(fo=>fo.Selected==true)?.Label;
            }
        }

        public string GetServiceUrl
        {
            get
            {
                return FilterGroups.FirstOrDefault(f => f.FilterParamName == "dbServiceUrl")?
                       .FilterOptions.FirstOrDefault(fo => fo.Selected == true)?.UrlSection;
            }
        }

        public string GetProfessionalName
        {
            get
            {
                return FilterGroups.FirstOrDefault(f => f.FilterParamName == "dbProfessionalUrl")?
                       .FilterOptions.FirstOrDefault(fo => fo.Selected == true)?.Label;
            }
        }




        public override string GetH1
        {
            get
            {
                return GetServiceName == null && GetProfessionalName == null ? GetIndexH1 :
                       GetServiceName != null && GetProfessionalName == null ? GetIndexH1ByServiceName :
                       GetServiceName == null && GetProfessionalName != null ? GetIndexH1ByProfessionalName : GetIndexH1ByServiceAndProfessionalName;
            }
        }

        public string GetIndexH1
        {
            get
            {
                return IndexDetail.GetIndexPageName();
            }
        }

        public string GetIndexH1ByServiceName
        {
            get
            {
                return GetServiceName +" "+ IndexDetail.GetIndexPageName();
            }
        }

        public string GetIndexH1ByProfessionalName
        {
            get
            {
                return IndexDetail.GetIndexPageName() + " by " + GetProfessionalName;
            }
        }

        public string GetIndexH1ByServiceAndProfessionalName
        {
            get
            {
                return GetServiceName + " " + IndexDetail.GetIndexPageName() + " by " + GetProfessionalName;
            }
        }
           
        public virtual ICollection<FilterGroupPartialViewModel> FilterGroups { get; set; }
        public RouteValueDictionary CurrentFiltersInPage(int page)
        {
            RouteValueDictionary rvd = CurrentFilters;
            rvd["page"] = page.ToString();
            return rvd;
        }

        public virtual ICollection<IndexablePartialViewModel>
            FilteredElements
        { get; set; }
        public int PageNumber { get; set; }
        public int Size = 20;

        public virtual ICollection<IndexablePartialViewModel>
            CurrentPageElements
        {
            get
            {
                return FilteredElements.Skip(Size * (PageNumber - 1)).Take(Size).ToList();
            }
        }

        public int TotalItemsCount
        {
            get
            {
                if (FilteredElements != null)
                    return FilteredElements.Count();
                else
                    return 0;
            }
            set
            {
                return;
            }
        }

        public int StartingIndex()
        {
            return this.Size * (this.PageNumber - 1);
        }
        public bool HasPrevious()
        {
            return this.PageNumber > 0;
        }
        public bool HasNext()
        {
            return this.StartingIndex() + this.Size <= this.FilteredElements.Count();
        }

        public int PreviousCount(int desiredCount = 4)
        {
            return this.PageNumber > desiredCount ? desiredCount : this.PageNumber - 1;
        }

        public int NextCount(int desiredCount = 4)
        {
            int lastNumber = this.LastPageNumber();
            return this.PageNumber + desiredCount <= lastNumber ? desiredCount : lastNumber - this.PageNumber;
        }

        public int? PrevNumber()
        {
            return this.HasPrevious() ? this.PageNumber - 1 : (int?)null;
        }

        public int? NextNumber()
        {
            return this.HasNext() ? this.PageNumber + 1 : (int?)null;
        }

        public int LastPageNumber()
        {
            return (int)Math.Ceiling((decimal)this.FilteredElements.Count / Size);
        }

        public int FirstNumber()
        {
            return 0;
        }

        public override string GetPageUrl(string abbreviatedLanguage)
        {
            return IndexDetail.GetIndexPageUrl(abbreviatedLanguage);
        }

        public string GetUrlSection
        {
            get
            {
                return IsEnglishThread ? IndexDetail.UrlSection : IndexDetail.UrlSectionSpanish;
            }
        }

        public override string GetPageArticleFolderPath
        {
            get
            {
                return "../baseindex/content/" + IndexDetail.UrlSection;
            }
        }

        public IndexPageViewModel(IHttpContextAccessor _httpContextAccessor, IBrowserDetector _browserDetector) : base (_httpContextAccessor, _browserDetector)
        {

        }

        public override AltLangRef GetAltLangRef
        {
            get
            {
                Language language = IsEnglish ? Language.Spanish : Language.English;
                string link = IsEnglish ? GetPageUrl(Language.Spanish.AbbreviatedName) : GetPageUrl(Language.Spanish.AbbreviatedName);
                return new AltLangRef(link, language);
            }
        }

    }

}