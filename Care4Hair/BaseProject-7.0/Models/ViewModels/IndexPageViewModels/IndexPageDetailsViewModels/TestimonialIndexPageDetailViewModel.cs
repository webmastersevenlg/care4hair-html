using BaseProject_7_0.Models.BaseModels;

namespace BaseProject_7_0.Models.ViewModels
{
    public class TestimonialIndexPageDetailViewModel : IndexPageDetailViewModel
    {
        public TestimonialIndexPageDetailViewModel()
        {
            Name = "Testimonials";
            NameSpanish = "Testimonios";          

            ElementTypeName = "Testimonial";
            ElementTypeNameSpanish = "Testimonio";

            ElementTypeNamePlural = "Testimonials";
            ElementTypeNamePluralSpanish = "Testimonios";

            AllElementsLabel = "All Testimonials";
            AllElementsLabelSpanish = "Todos Los Testimonios";

            UrlSection = "testimonials";
            UrlSectionSpanish = "testimonios";
        }
    }
}