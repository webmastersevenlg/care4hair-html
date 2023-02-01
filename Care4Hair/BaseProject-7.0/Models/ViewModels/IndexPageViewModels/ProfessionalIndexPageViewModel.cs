using BaseProject_7_0.Models.BaseModels;
using Shyjus.BrowserDetection;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class ProfessionalIndexPageViewModel : IndexPageViewModel
    {
        public ProfessionalIndexPageViewModel(IHttpContextAccessor _httpContextAccessor, IBrowserDetector _browserDetector) : base(_httpContextAccessor, _browserDetector)
        {
            IndexDetail = new ProfessionalIndexPageDetailViewModel();
        }
     }
}