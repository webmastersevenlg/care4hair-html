using BaseProject_7_0.Models.EntityModels.XmlEntities;
using BaseProject_7_0.Models.EntityModels.DbEntities;
using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.XmlTools;
using System;
using System.Reflection;
using Microsoft.AspNetCore.Hosting;

namespace BaseProject_7_0.App_start
{
    public class RouteConfig
    {
        private static string EnglishAbbreviation = Language.English.AbbreviatedName;
        private static string UncategorizedPageUrlContraints { get; set; }
        private static string ProfessionalUrlContraints { get; set; }
        private static string CategoryUrlContraints { get; set; }
        private static string ServiceUrlContraints { get; set; }
        private static string dbProfessionalUrlContraints { get; set; }
        private static string dbServiceUrlContraints { get; set; }

        private static IWebHostEnvironment _webHostEnvironment;

        public static void GetConstraints()        {

            //Getting Route Contraints From Html
            UncategorizedPageUrlContraints = string.Format("({0})", string.Join(")|(",
                XmlReader.GetEachAttributeValueByFileNameAndAttributeName(UncategorizedPageEntity.XmlFilePath, "url")));
            ProfessionalUrlContraints = string.Format("({0})", string.Join(")|(",
                XmlReader.GetEachAttributeValueByFileNameAndAttributeName(ProfessionalEntity.XmlFilePath, "url")));
            CategoryUrlContraints = string.Format("({0})", string.Join(")|(",
                XmlReader.GetEachAttributeValueByFileNameAndAttributeName(CategoryEntity.XmlFilePath, "url")));
            ServiceUrlContraints = string.Format("({0})", string.Join(")|(",
                XmlReader.GetEachAttributeValueByFileNameAndAttributeName(ServiceEntity.XmlFilePath, "url")));
        }

        public static void RegisterRoutes(WebApplication app)
        {
            GetConstraints();
            app.MapControllerRoute(
                name: "UncategorizedPage",
                pattern: "{uncategorizedPageUrl}",
                defaults: new RouteValueDictionary { { "controller", "UncategorizedPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                constraints: new RouteValueDictionary { { "uncategorizedPageUrl", UncategorizedPageUrlContraints } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "UncategorizedPage" } }
                );

            app.MapControllerRoute(
                name: "CategoryPage",
                pattern: "{categoryUrl}",
                defaults: new RouteValueDictionary { { "controller", "CategoryPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                constraints: new RouteValueDictionary { { "categoryUrl", CategoryUrlContraints } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "CategoryPage" } }
                );

            app.MapControllerRoute(
                name: "ServicePage",
                pattern: "{serviceUrl}",
                defaults: new RouteValueDictionary { { "controller", "ServicePage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                constraints: new RouteValueDictionary { { "serviceUrl", ServiceUrlContraints } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "ServicePage" } }
                );

            app.MapControllerRoute(
                name: "ServicePage",
                pattern: "{serviceUrl}",
                defaults: new RouteValueDictionary { { "controller", "ServicePage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                constraints: new RouteValueDictionary { { "serviceUrl", ServiceUrlContraints } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "ServicePage" } }
                );

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}",
                defaults: new RouteValueDictionary { { "abbreviatedLanguage", EnglishAbbreviation } },
                dataTokens: new RouteValueDictionary{{ "__RouteName", "Default" }}
                );
        }
    }

}