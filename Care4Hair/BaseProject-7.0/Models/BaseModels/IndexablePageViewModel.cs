using BaseProject_7_0.Models.ViewModels;
using Shyjus.BrowserDetection;
using System.Web;

namespace BaseProject_7_0.Models.BaseModels
{
    public class IndexablePageViewModel : BasePageWithStaticHtmlFilesViewModel
    {
        public IndexPageDetailViewModel IndexPageDetail { get; set; }
        public IndexablePageDetailViewModel IndexablePageDetail { get; set; }

        public override string GetPageUrl(string abbreviatedLanguage)
        {
            //este if es para cuando se llame desde el modal select language si se llama desde el idioma opuesto valla al root del indice en el otro idioma
            if (CurrentLanguage.AbbreviatedName==abbreviatedLanguage)
                return IndexablePageDetail.GetIndexablePageUrl(abbreviatedLanguage);
            else
                return IndexPageDetail.GetIndexPageUrl(abbreviatedLanguage);            
        }

        public IndexablePageViewModel(IWebHostEnvironment _webHostingEnviroment, IHttpContextAccessor _httpContextAccessor, IBrowserDetector _browserDetector) : base(_webHostingEnviroment, _httpContextAccessor, _browserDetector)
        {
            
        }       
    }
}