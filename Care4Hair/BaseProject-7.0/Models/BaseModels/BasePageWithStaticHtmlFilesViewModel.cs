using BaseProject_7_0.Models.BaseModels;
using Microsoft.Extensions.Hosting.Internal;
using Shyjus.BrowserDetection;

namespace BaseProject_7_0.Models.ViewModels
{
    public class BasePageWithStaticHtmlFilesViewModel : BasePageViewModel
    {
        public static IWebHostEnvironment WebHostEnvironment;

        public virtual string GetPageArticleFolderPath
        {
            get
            {
                return "content/" + Url;
            }
        }

        public virtual string GetViewFolderPath
        {
            get
            {
                return "~/views/" + this.GetType().Name.Replace("ViewModel", "");
            }
        }

        public string GetCommonPartialsFolderPath
        {
            get
            {
                return "commonpartials";
            }
        }

        public string GetMetasFilePath
        {
            get
            {
                return  GetPageArticleFolderPath + "/" + GetabbreviatedLanguage + "/articlemetas";
            }
        }

        public virtual string GetArticleFilePath
        {
            get
            {
                return  GetPageArticleFolderPath + "/" + GetabbreviatedLanguage + "/article";
            }
        }

        public string GetLastModifiedDate
        {
     
        get
            {
                return DateTime.SpecifyKind(new DateTime(Math.Max(                    
                    File.GetLastWriteTime(Path.Combine(WebHostEnvironment.WebRootPath, GetViewFolderPath + "/" + GetArticleFilePath + ".cshtml")).Ticks,
                    File.GetLastWriteTime(Path.Combine(WebHostEnvironment.WebRootPath, GetViewFolderPath + "/" + GetMetasFilePath + ".cshtml")).Ticks)), DateTimeKind.Local).ToString("yyyy-MM-ddThh:mm:sszzz");
            }
        }

        public string GetTimeZone
        {
            get
            {
                return DateTime.SpecifyKind(File.GetLastWriteTime(Path.Combine(WebHostEnvironment.WebRootPath, GetViewFolderPath + "/" + GetMetasFilePath + ".cshtml")), DateTimeKind.Local).ToString("zzz");
            }
        }

        public BasePageWithStaticHtmlFilesViewModel(IHttpContextAccessor _httpContextAccessor, IBrowserDetector _browserDetector) : base (_httpContextAccessor, _browserDetector)
        {
        }
    }
}