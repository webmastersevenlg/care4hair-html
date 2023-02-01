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
        }
}
