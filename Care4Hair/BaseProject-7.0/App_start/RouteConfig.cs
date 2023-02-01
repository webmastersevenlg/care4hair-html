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

            //ProfessionalindexPage
            app.MapControllerRoute(
                name: "ProfessionalindexPage",
                pattern: Site.Instance.Professionals.UrlSection,
                defaults: new RouteValueDictionary { { "controller", "ProfessionalindexPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "ProfessionalindexPage" } }
                );

            //ProfessionalPage
            app.MapControllerRoute(
                 name: "ProfessionalPage",
                 pattern: "{professionalUrl}",
                 defaults: new RouteValueDictionary { { "controller", "ProfessionalPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                 constraints: new RouteValueDictionary { { "professionalUrl", ProfessionalUrlContraints } },
                 dataTokens: new RouteValueDictionary { { "__RouteName", "ProfessionalPage" } }
                 );

            //TestimonialindexPage
            app.MapControllerRoute(
                name: "TestimonialindexPage",
                pattern: Site.Instance.Testimonials.UrlSection,
                defaults: new RouteValueDictionary { { "controller", "TestimonialindexPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "TestimonialindexPage" } }
                );

            //FinancingOptionindexPage
            app.MapControllerRoute(
                name: "FinancingOptionindexPage",
                pattern: Site.Instance.FinancingOptions.UrlSection,
                defaults: new RouteValueDictionary { { "controller", "FinancingOptionindexPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "FinancingOptionindexPage" } }
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
                pattern: Site.Instance.SppecialOfferPage.UrlSection + "/{specialOfferUrl}/{view?}",
                defaults: new RouteValueDictionary { { "controller", "SpecialOfferPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "SpecialOfferPage" } }
                );

            //BlogindexPage
            app.MapControllerRoute(
                name: "BlogindexPage",
                pattern: Site.Instance.Blog.UrlSection,
                defaults: new RouteValueDictionary { { "controller", "BlogindexPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "BlogindexPage" } }
                );

            //BlogPostPage
            app.MapControllerRoute(
                name: "BlogPostPage",
                pattern: Site.Instance.BlogPostPage.UrlSection + "/{blogUrl}",
                defaults: new RouteValueDictionary { { "controller", "BlogPostPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "BlogPostPage" } }
                );

            //PictureindexByService
            app.MapControllerRoute(
                name: "BlogindexPage",
                pattern: "{dbServiceUrl}/" + Site.Instance.Pictures.UrlSection + "/{dbProfessionalUrl?}",
                constraints: new RouteValueDictionary { { "dbServiceUrl", dbServiceUrlContraints }, { "dbProfessionalUrl", dbProfessionalUrlContraints } },
                defaults: new RouteValueDictionary { { "controller", "PictureindexPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "PictureindexByService" } }
                );

            //PictureindexBase
            app.MapControllerRoute(
                name: "PictureindexBase",
                pattern: Site.Instance.Pictures.UrlSection + "/{dbProfessionalUrl?}",
                constraints: new RouteValueDictionary { { "dbServiceUrl", dbServiceUrlContraints } },
                defaults: new RouteValueDictionary { { "controller", "PictureindexPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "PictureindexBase" } }
                );

            //WebReviewindexByService
            app.MapControllerRoute(
                name: "WebReviewindexByService",
                pattern: "{dbServiceUrl}/" + Site.Instance.WebReviews.UrlSection + "/{dbProfessionalUrl?}",
                constraints: new RouteValueDictionary { { "dbServiceUrl", dbServiceUrlContraints }, { "dbProfessionalUrl", dbProfessionalUrlContraints } },
                defaults: new RouteValueDictionary { { "controller", "WebReviewindexPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "WebReviewindexByService" } }
                );


            //WebReviewindexBase
            app.MapControllerRoute(
                name: "WebReviewindexBase",
                pattern: Site.Instance.Pictures.UrlSection + "/{dbProfessionalUrl?}",
                constraints: new RouteValueDictionary { { "dbProfessionalUrl", dbProfessionalUrlContraints } },
                defaults: new RouteValueDictionary { { "controller", "WebReviewindexPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "WebReviewindexBase" } }
                );

            //VideoindexPageByService
            app.MapControllerRoute(
                name: "VideoindexPageByService",
                pattern: "{dbServiceUrl}/" + Site.Instance.Videos.UrlSection + "/{dbProfessionalUrl?}",
                constraints: new RouteValueDictionary { { "dbServiceUrl", dbServiceUrlContraints }, { "dbProfessionalUrl", dbProfessionalUrlContraints } },
                defaults: new RouteValueDictionary { { "controller", "VideoindexPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "VideoindexPageByService" } }
                );

            //VideoindexPage
            app.MapControllerRoute(
                name: "VideoindexPage",
                pattern: Site.Instance.Pictures.UrlSection + "/{dbProfessionalUrl?}",
                constraints: new RouteValueDictionary { { "dbProfessionalUrl", dbProfessionalUrlContraints } },
                defaults: new RouteValueDictionary { { "controller", "VideoindexPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "VideoindexPage" } }
                );

            //VideoPage
            app.MapControllerRoute(
                name: "VideoPage",
                pattern: Site.Instance.VideoPage.UrlSection + "/{videoUrl}",
                defaults: new RouteValueDictionary { { "controller", "VideoPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "VideoPage" } }
                );

            //SpecialindexPageByService
            app.MapControllerRoute(
                name: "SpecialindexPageByService",
                pattern: "{dbServiceUrl}/" + Site.Instance.Specials.UrlSection + "/{dbProfessionalUrl?}",
                constraints: new RouteValueDictionary { { "dbServiceUrl", dbServiceUrlContraints }, { "dbProfessionalUrl", dbProfessionalUrlContraints } },
                defaults: new RouteValueDictionary { { "controller", "SpecialindexPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "SpecialindexPageByService" } }
                );

            //SpecialindexPageBase
            app.MapControllerRoute(
                name: "SpecialindexPageBase",
                pattern: Site.Instance.Specials.UrlSection + "/{dbProfessionalUrl?}",
                constraints: new RouteValueDictionary { { "dbProfessionalUrl", dbProfessionalUrlContraints } },
                defaults: new RouteValueDictionary { { "controller", "SpecialindexPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "SpecialindexPageBase" } }
                );

            //SpecialPage
            app.MapControllerRoute(
                name: "SpecialPage",
                pattern: Site.Instance.SpecialPage.UrlSection + "/{specialUrl}/{id?}",
                defaults: new RouteValueDictionary { { "controller", "SpecialPage" }, { "action", "index" }, { "abbreviatedLanguage", EnglishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "SpecialPage" } }
                );


            //Robots
            app.MapControllerRoute(
                name: "Robots",
                pattern: "robots.txt",
                defaults: new RouteValueDictionary { { "controller", "Robots" }, { "action", "index" }},
                dataTokens: new RouteValueDictionary { { "__RouteName", "Robots" } }
                );

            //Robots
            app.MapControllerRoute(
                name: "Robots",
                pattern: "robots.txt",
                defaults: new RouteValueDictionary { { "controller", "Robots" }, { "action", "index" } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "Robots" } }
                );

            //SiteMap
            app.MapControllerRoute(
                name: "Default",
                pattern: "sitemap.xml",
                defaults: new RouteValueDictionary { { "controller", "SiteMap" }, { "action", "SiteMap" } },
                dataTokens: new RouteValueDictionary{{ "__RouteName", "SiteMap" } }
                );

            //SiteMapImages
            app.MapControllerRoute(
                name: "SiteMapImages",
                pattern: "sitemap_images.xml",
                defaults: new RouteValueDictionary { { "controller", "SiteMap" }, { "action", "SiteMapImages" } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "SiteMapImages" } }
                );

            //SitemapVideos
            app.MapControllerRoute(
                name: "SitemapVideos",
                pattern: "sitemap_video.xml",
                defaults: new RouteValueDictionary { { "controller", "SiteMap" }, { "action", "SitemapVideos" } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "SitemapVideos" } }
                );

            //Call
            app.MapControllerRoute(
                name: "Call",
                pattern: "call/{number}",
                defaults: new RouteValueDictionary { { "controller", "call" }, { "action", "index" } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "Call" } }
                );

            //Call
            app.MapControllerRoute(
                name: "Call",
                pattern: "call/{number}",
                defaults: new RouteValueDictionary { { "controller", "call" }, { "action", "index" } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "Call" } }
                );

            //FreeConsultation
            app.MapControllerRoute(
                name: "FreeConsultation",
                pattern: "freeconsultation/{sourcePlatformDetail}/{professionalUrl}",
                defaults: new RouteValueDictionary { { "controller", "freeconsultation" }, { "action", "index" } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "FreeConsultation" } }
                );

            //Default
            app.MapControllerRoute(
                name: "Default",
                pattern: "{controller=Home}/{action=index}/{id?}",
                defaults: new RouteValueDictionary { { "abbreviatedLanguage", EnglishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "Default" } }
                );
        }
    }

}