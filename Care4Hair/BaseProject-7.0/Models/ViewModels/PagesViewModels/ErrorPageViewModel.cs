using BaseProject_7_0.Models.BaseModels;
using Shyjus.BrowserDetection;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class ErrorPageViewModel : BasePageWithStaticHtmlFilesViewModel
    {
        public ErrorPageViewModel(IHttpContextAccessor _httpContextAccessor, IBrowserDetector _browserDetector) : base(_httpContextAccessor, _browserDetector)
        {
            SkinName = "ErrorPageSkinPage";       
        }   
    }
}