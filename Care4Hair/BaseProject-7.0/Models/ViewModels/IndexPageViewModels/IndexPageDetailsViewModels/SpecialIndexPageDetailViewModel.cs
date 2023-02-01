using BaseProject_7_0.Models.BaseModels;

namespace BaseProject_7_0.Models.ViewModels
{
    public class SpecialIndexPageDetailViewModel : IndexPageDetailViewModel
    {
        public SpecialIndexPageDetailViewModel()
        {
            Name = "Specials";
            NameSpanish = "Especiales";

            ElementTypeName = "Special";
            ElementTypeNameSpanish = "Especial";

            ElementTypeNamePlural = "Specials";
            ElementTypeNamePluralSpanish = "Especiales";

            AllElementsLabel = "All Specials";
            AllElementsLabelSpanish = "Todos Los Especiales";

            UrlSection = "specials";
            UrlSectionSpanish = "especiales";
        }
    }
}