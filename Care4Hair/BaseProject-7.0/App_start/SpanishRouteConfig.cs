namespace BaseProject_7_0.App_start
{
    public class SpanishRouteConfig
    {
        private static string SpanishAbbreviation = Language.Spanish.AbbreviatedName;
        private static string UncategorizedPageUrlContraints { get; set; }
        private static string ProfessionalUrlContraints { get; set; }
        private static string CategoryUrlContraints { get; set; }
        private static string ServiceUrlContraints { get; set; }
        private static string dbProfessionalUrlContraints { get; set; }
        private static string dbServiceUrlContraints { get; set; }

        private static IWebHostEnvironment _webHostEnvironment;

        public static void GetConstraints()
        {

            //Getting Route Contraints From Html
            UncategorizedPageUrlContraints = string.Format("({0})", string.Join(")|(",
                XmlReader.GetEachAttributeValueByFileNameAndAttributeName(UncategorizedPageEntity.XmlFilePath, "urlspanish")));
            ProfessionalUrlContraints = string.Format("({0})", string.Join(")|(",
                XmlReader.GetEachAttributeValueByFileNameAndAttributeName(ProfessionalEntity.XmlFilePath, "urlspanish")));
            CategoryUrlContraints = string.Format("({0})", string.Join(")|(",
                XmlReader.GetEachAttributeValueByFileNameAndAttributeName(CategoryEntity.XmlFilePath, "urlspanish")));
            ServiceUrlContraints = string.Format("({0})", string.Join(")|(",
                XmlReader.GetEachAttributeValueByFileNameAndAttributeName(ServiceEntity.XmlFilePath, "urlspanish")));
        }


        public static void RegisterRoutes(WebApplication app)
        {
            GetConstraints();

            //UncategorizedPageEs
            app.MapControllerRoute(
                name: "UncategorizedPagesEs",
                pattern: Settings.GetSpanishUrl + "/{uncategorizedPageUrl}",
                defaults: new RouteValueDictionary { { "controller", "UncategorizedPage" }, { "action", "index" }, { "abbreviatedLanguage", SpanishAbbreviation } },
                constraints: new RouteValueDictionary { { "uncategorizedPageUrl", UncategorizedPageUrlContraints } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "UncategorizedPagesEs" } }
                );

            //CategoryPage
            app.MapControllerRoute(
                name: "CategoryPageEs",
                pattern: Settings.GetSpanishUrl + "/{categoryUrl}",
                defaults: new RouteValueDictionary { { "controller", "CategoryPage" }, { "action", "index" }, { "abbreviatedLanguage", SpanishAbbreviation } },
                constraints: new RouteValueDictionary { { "categoryUrl", CategoryUrlContraints } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "CategoryPageEs" } }
                );

            //ServicePageEs//
            app.MapControllerRoute(
                name: "ServicePageEs",
                pattern: Settings.GetSpanishUrl + "/{serviceUrl}",
                defaults: new RouteValueDictionary { { "controller", "ServicePage" }, { "action", "index" }, { "abbreviatedLanguage", SpanishAbbreviation } },
                constraints: new RouteValueDictionary { { "serviceUrl", ServiceUrlContraints } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "ServicePageEs" } }
                );

            ////ProfessionalIndexPageEs
            app.MapControllerRoute(
                name: "ProfessionalIndexPageEs",
                pattern: Settings.GetSpanishUrl + "/" + Site.Instance.Professionals.GetUrlSection(SpanishAbbreviation),
                defaults: new RouteValueDictionary { { "controller", "ProfessionalIndexPage" }, { "action", "Index" }, { "abbreviatedLanguage", SpanishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "ProfessionalIndexPageEs" } }
                );
            //ProfessionalPageEs//
            app.MapControllerRoute(
                name: "ProfessionalPageEs",
                pattern: Settings.GetSpanishUrl + "/{professionalUrl}",
                defaults: new RouteValueDictionary { { "controller", "ProfessionalPage" }, { "action", "index" }, { "abbreviatedLanguage", SpanishAbbreviation } },
                constraints: new RouteValueDictionary { { "professionalUrl", ProfessionalUrlContraints } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "ProfessionalPageEs" } }
                );


            //TestimonialIndexPageEs
            app.MapControllerRoute(
                name: "TestimonialIndexPageEs",
                pattern: Settings.GetSpanishUrl + "/" + Site.Instance.Testimonials.GetUrlSection(SpanishAbbreviation),
                defaults: new RouteValueDictionary { { "controller", "TestimonialIndexPage" }, { "action", "Index" }, { "abbreviatedLanguage", SpanishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "TestimonialIndexPageEs" } }
                );

            //FinancingOptionIndexPageEs
            app.MapControllerRoute(
                name: "FinancingOptionIndexPageEs",
                pattern: Settings.GetSpanishUrl + "/" + Site.Instance.FinancingOptions.GetUrlSection(SpanishAbbreviation),
                defaults: new RouteValueDictionary { { "controller", "FinancingOptionIndexPage" }, { "action", "Index" }, { "abbreviatedLanguage", SpanishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "FinancingOptionIndexPageEs" } }
                );

            //FinancingOptionPageEs
            app.MapControllerRoute(
                 name: "FinancingOptionPageEs",
                 pattern: Settings.GetSpanishUrl + Site.Instance.FinancingOptionPage.GetUrlSection(SpanishAbbreviation) + "/{financingOptionUrl}",
                 defaults: new RouteValueDictionary { { "controller", "FinancingOptionPage" }, { "action", "Index" }, { "abbreviatedLanguage", SpanishAbbreviation } },
                 constraints: new RouteValueDictionary { { "professionalUrl", ProfessionalUrlContraints } },
                 dataTokens: new RouteValueDictionary { { "__RouteName", "FinancingOptionPageEs" } }
                 );

            //BlogIndexPageEs
            app.MapControllerRoute(
                name: "BlogIndexPageEs",
                pattern: Settings.GetSpanishUrl + "/" + Site.Instance.Blog.GetUrlSection(SpanishAbbreviation),
                defaults: new RouteValueDictionary { { "controller", "BlogIndexPage" }, { "action", "Index" }, { "abbreviatedLanguage", SpanishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "BlogIndexPageEs" } }
                );

            //BlogPostPageEs
            app.MapControllerRoute(
                name: "BlogPostPageEs",
                pattern: Settings.GetSpanishUrl + Site.Instance.BlogPostPage.GetUrlSection(SpanishAbbreviation) + "/{blogUrl}",
                defaults: new RouteValueDictionary { { "controller", "BlogPostPage" }, { "action", "Index" }, { "abbreviatedLanguage", SpanishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "BlogPostPageEs" } }
                );

            //PictureIndexByServiceEs
            app.MapControllerRoute(
                name: "PictureIndexByServiceEs",
                pattern: Settings.GetSpanishUrl + "{dbServiceUrl}/" + Site.Instance.Pictures.GetUrlSection(SpanishAbbreviation) + "/{dbProfessionalUrl?}",
                constraints: new RouteValueDictionary { { "dbServiceUrl", dbServiceUrlContraints }, { "dbProfessionalUrl", dbProfessionalUrlContraints } },
                defaults: new RouteValueDictionary { { "controller", "PictureIndexPage" }, { "action", "Index" }, { "abbreviatedLanguage", SpanishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "PictureIndexByService" } }
                );
            //PictureIndexBaseEs
            app.MapControllerRoute(
                name: "PictureIndexBaseEs",
                pattern: Settings.GetSpanishUrl + "/" + Site.Instance.Pictures.GetUrlSection(SpanishAbbreviation) + "/{dbProfessionalUrl?}",
                constraints: new RouteValueDictionary { { "dbProfessionalUrl", dbServiceUrlContraints } },
                defaults: new RouteValueDictionary { { "controller", "PictureIndexPage" }, { "action", "Index" }, { "abbreviatedLanguage", SpanishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "PictureIndexBaseEsEs" } }
                );


            //WebReviewIndexByServiceEs
            app.MapControllerRoute(
                name: "WebReviewIndexBaseEs",
                pattern: Settings.GetSpanishUrl + "/{dbServiceUrl}/" + Site.Instance.WebReviews.UrlSectionSpanish + "/{dbProfessionalUrl?}",
                constraints: new RouteValueDictionary { { "dbServiceUrl", dbServiceUrlContraints }, { "dbProfessionalUrl", dbProfessionalUrlContraints } },
                defaults: new RouteValueDictionary { { "controller", "WebReviewIndexPage" }, { "action", "Index" }, { "abbreviatedLanguage", SpanishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "WebReviewIndexByServiceEs" } }
                );


            //WebReviewIndexBaseEs
            app.MapControllerRoute(
                name: "WebReviewIndexBaseEs",
                pattern: Settings.GetSpanishUrl + "/" + Site.Instance.WebReviews.UrlSectionSpanish + "/{dbProfessionalUrl?}",
                constraints: new RouteValueDictionary { { "dbProfessionalUrl", dbProfessionalUrlContraints } },
                defaults: new RouteValueDictionary { { "controller", "WebReviewIndexPage" }, { "action", "Index" }, { "abbreviatedLanguage", SpanishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "WebReviewIndexBaseEs" } }
                );

            //VideoIndexPageByServiceEs
            app.MapControllerRoute(
                name: "VideoIndexPageByServiceEs",
                pattern: Settings.GetSpanishUrl + "/{dbServiceUrl}/" + Site.Instance.Videos.GetUrlSection(SpanishAbbreviation) + "/{dbProfessionalUrl?}",
                constraints: new RouteValueDictionary { { "dbServiceUrl", dbServiceUrlContraints }, { "dbProfessionalUrl", dbProfessionalUrlContraints } },
                defaults: new RouteValueDictionary { { "controller", "VideoIndexPage" }, { "action", "Index" }, { "abbreviatedLanguage", SpanishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "VideoIndexPageByServiceEs" } }
                );

            //VideoIndexPageEs
            app.MapControllerRoute(
                name: "VideoIndexPageEs",
                pattern: Settings.GetSpanishUrl + "/" + Site.Instance.Videos.GetUrlSection(SpanishAbbreviation) + "/{dbProfessionalUrl?}",
                constraints: new RouteValueDictionary { { "dbProfessionalUrl", dbProfessionalUrlContraints } },
                defaults: new RouteValueDictionary { { "controller", "VideoIndexPage" }, { "action", "Index" }, { "abbreviatedLanguage", SpanishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "VideoIndexPageEs" } }
                );

            //VideoPageEs
            app.MapControllerRoute(
                name: "VideoPageEs",
                pattern: Settings.GetSpanishUrl + "/" + Site.Instance.VideoPage.UrlSectionSpanish + "/{videoUrl}",
                defaults: new RouteValueDictionary { { "controller", "VideoPage" }, { "action", "Index" }, { "abbreviatedLanguage", SpanishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "VideoPageEs" } }
                );
            //SpecialIndexPageByServiceEs
            app.MapControllerRoute(
                name: "SpecialIndexPageByServiceEs",
                pattern: Settings.GetSpanishUrl + "/{dbServiceUrl}/" + Site.Instance.Specials.GetUrlSection(SpanishAbbreviation) + "/{dbProfessionalUrl?}",
                constraints: new RouteValueDictionary { { "dbServiceUrl", dbServiceUrlContraints }, { "dbProfessionalUrl", dbProfessionalUrlContraints } },
                defaults: new RouteValueDictionary { { "controller", "SpecialIndexPage" }, { "action", "Index" }, { "abbreviatedLanguage", SpanishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "SpecialIndexPageByServiceEs" } }
                );



            //SpecialIndexPageBaseEs
            app.MapControllerRoute(
                name: "SpecialIndexPageEs",
                pattern: Settings.GetSpanishUrl + "/" + Site.Instance.Specials.GetUrlSection(SpanishAbbreviation) + "/{dbProfessionalUrl?}",
                constraints: new RouteValueDictionary { { "dbProfessionalUrl", dbProfessionalUrlContraints } },
                defaults: new RouteValueDictionary { { "controller", "SpecialIndexPage" }, { "action", "Index" }, { "abbreviatedLanguage", SpanishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "SpecialIndexpageEs" } }
                );

            //SpecialPageEs
            app.MapControllerRoute(
                name: "SpecialPageEs",
                pattern: Settings.GetSpanishUrl + Site.Instance.SpecialPage.GetUrlSection(SpanishAbbreviation) + "/{specialUrl}/{id?}",
                defaults: new RouteValueDictionary { { "controller", "SpecialPage" }, { "action", "Index" }, { "abbreviatedLanguage", SpanishAbbreviation } },
                dataTokens: new RouteValueDictionary { { "__RouteName", "SpecialPageEs" } }
                );




        }
    }
}
