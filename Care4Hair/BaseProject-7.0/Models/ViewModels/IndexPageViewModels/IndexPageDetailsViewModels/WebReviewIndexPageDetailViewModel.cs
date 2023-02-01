using BaseProject_7_0.Models.BaseModels;

namespace BaseProject_7_0.Models.ViewModels
{
    public class WebReviewIndexPageDetailViewModel : IndexPageDetailViewModel
    {
        public WebReviewIndexPageDetailViewModel()
        {
            Name = "Reviews";
            NameSpanish = "Reseñas";

            ElementTypeName = "Review";
            ElementTypeNameSpanish = "Reseña";

            ElementTypeNamePlural = "Reviews";
            ElementTypeNamePluralSpanish = "Reseñas";

            AllElementsLabel = "All Reviews";
            AllElementsLabelSpanish = "Todas Las Reseñas";

            UrlSection = "reviews";
            UrlSectionSpanish = "resenas";

        }
    }
}

