using BaseProject_7_0.App_Resources;

namespace BaseProject_7_0.Models.BaseModels
{
    public class TestimonialIndexPartialViewModel : BasePartialViewModel
    {
        public string GetIndexName
        {
            get
            {
                return IsEnglish ? "Testimonials" : "Testimonios";
            }
        }
        public string GetElementTypeName
        {
            get
            {
                return IsEnglish ? "Testimonial" : "Testimonio";
            }
        }
        public string GetElementTypeNamePlural
        {
            get
            {
                return IsEnglish ? "Testimonials" : "Testimonios";
            }
        }
        public string GetAllElementsLabel
        {
            get
            {
                return IsEnglish ? "All Testimonials" : "Todos Los Testimonios";
            }
        }
        public override string GetPageUrl(string abbreviatedLanguage)
        {
            return IsEnglishAbbreviation(abbreviatedLanguage) ? "/testimonials" : "/" + Settings.GetSpanishUrl + "/testimonios";
        }
    }
}