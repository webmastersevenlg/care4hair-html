using BaseProject_7_0.App_Resources;
using Microsoft.AspNetCore.Html;
using System.Web.Optimization;

namespace BaseProject_7_0.Helpers
{
    public class BundleHelpers
    {
        static string styleAsync = Settings.GetStyleBundleAsync && Settings.OptimizeBundle ? "async" : "";
        static string scriptAsync = Settings.GetScriptBundleAsync && Settings.OptimizeBundle ? "async" : "";
        static string theme = Settings.GetTheme;

        public static IHtmlContent StyleBundle(string bundleName)
        {
            var result = new HtmlString(string.Format(@"<link href=""{0}""  " + styleAsync + @" rel=""stylesheet"" type=""text/css"" media=""none"" onload=""if (media != 'all') media = 'all'"" as=""style""></link>", "~/content/themes/" + theme + "/css/" + bundleName));
            return result;
        }
        public static IHtmlContent ScriptBundle(string bundleName)
        {
            var result = new HtmlString(string.Format(@"<script id=""scriptbundle"" src=""{0}"" " + scriptAsync + "></script>", "~/content/themes/" + theme + "/js/" + bundleName));
            return result;
        }
    }
}