using BaseProject_7_0.Models.EntityModels.XmlEntities;
using BaseProject_7_0.Models.EntityModels.DbEntities;
using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.XmlTools;
using System;
using System.Reflection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Data.SqlClient;

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

            //UncategorizedPage
            app.MapControllerRoute(
                name: "UncategorizedPage",
                pattern: "{uncategorizedPageUrl}",
                defaults: new RouteValueDictionary { { "controller", "UncategorizedPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                constraints: new RouteValueDictionary { { "uncategorizedPageUrl", UncategorizedPageUrlContraints } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "UncategorizedPage" } }
                );

            //CategoryPage
            app.MapControllerRoute(
                name: "CategoryPage",
                pattern: "{categoryUrl}",
                defaults: new RouteValueDictionary { { "controller", "CategoryPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                constraints: new RouteValueDictionary { { "categoryUrl", CategoryUrlContraints } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "CategoryPage" } }
                );

            //ServicePage
            app.MapControllerRoute(
                name: "ServicePage",
                pattern: "{serviceUrl}",
                defaults: new RouteValueDictionary { { "controller", "ServicePage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                constraints: new RouteValueDictionary { { "serviceUrl", ServiceUrlContraints } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "ServicePage" } }
                );

            //ProfessionalIndexPage
            app.MapControllerRoute(
                name: "ProfessionalIndexPage",
                pattern: Site.Instance.Professionals.UrlSection,
                defaults: new RouteValueDictionary { { "controller", "ProfessionalIndexPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "ProfessionalIndexPage" } }
                );

            //ProfessionalPage
            app.MapControllerRoute(
                 name: "ProfessionalPage",
                 pattern: "{professionalUrl}",
                 defaults: new RouteValueDictionary { { "controller", "ProfessionalPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                 constraints: new RouteValueDictionary { { "professionalUrl", ProfessionalUrlContraints } },
                 dataTokens: new RouteValueDictionary { { "__RouteName", "ProfessionalPage" } }
                 );

            //TestimonialIndexPage
            app.MapControllerRoute(
                name: "TestimonialIndexPage",
                pattern: Site.Instance.Testimonials.UrlSection,
                defaults: new RouteValueDictionary { { "controller", "TestimonialIndexPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "TestimonialIndexPage" } }
                );

            //FinancingOptionIndexPage
            app.MapControllerRoute(
                name: "FinancingOptionIndexPage",
                pattern: Site.Instance.FinancingOptions.UrlSection,
                defaults: new RouteValueDictionary { { "controller", "FinancingOptionIndexPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "FinancingOptionIndexPage" } }
                );

            //FinancingOptionPage
            app.MapControllerRoute(
                 name: "FinancingOptionPage",
                 pattern: Site.Instance.FinancingOptionPage.UrlSection + "/{financingOptionUrl}",
                 defaults: new RouteValueDictionary { { "controller", "FinancingOptionPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                 constraints: new RouteValueDictionary { { "professionalUrl", ProfessionalUrlContraints } },
                 dataTokens: new RouteValueDictionary { { "__RouteName", "FinancingOptionPage" } }
                 );

            //SpecialOfferPage
            app.MapControllerRoute(
                name: "SpecialOfferPage",
                pattern: Site.Instance.SppecialOfferPage.UrlSection + "/{specialOfferUrl}/{view}",
                defaults: new RouteValueDictionary { { "controller", "SpecialOfferPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "SpecialOfferPage" } }
                );

            //BlogIndexPage
            app.MapControllerRoute(
                name: "BlogIndexPage",
                pattern: Site.Instance.Blog.UrlSection,
                defaults: new RouteValueDictionary { { "controller", "BlogIndexPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "BlogIndexPage" } }
                );

            //BlogPostPage
            app.MapControllerRoute(
                name: "BlogIndexPage",
                pattern: Site.Instance.BlogPostPage.UrlSection + "/{blogUrl}",
                defaults: new RouteValueDictionary { { "controller", "BlogPostPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "BlogPostPage" } }
                );

            //Default
            app.MapControllerRoute(
                name: "Default",
                pattern: "{controller=Home}/{action=Index}/{id?}",
                defaults: new RouteValueDictionary { { "abbreviatedLanguage", EnglishAbbreviation } },
                dataTokens: new RouteValueDictionary{{ "__RouteName", "Default" }}
                );
        }
    }

}