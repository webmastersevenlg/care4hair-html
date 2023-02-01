using BaseProject_7_0.Models.BaseModels;

namespace BaseProject_7_0.Models.ViewModels
{
    public class BeforeAndAfterPhotosIndexPageDetailViewModel : IndexPageDetailViewModel
    {
        public BeforeAndAfterPhotosIndexPageDetailViewModel()
        {
            Name = "Before and After Photos";
            NameSpanish = "Fotos Antes y Después";

            ElementTypeName = "Before And After Photos";
            ElementTypeNameSpanish = "Especial";

            ElementTypeNamePlural = "Before And After Photos";
            ElementTypeNamePluralSpanish = "Especiales";

            AllElementsLabel = "All Photos";
            AllElementsLabelSpanish = "Todas Las Fotos";

            UrlSection = "Before-And-After-Photos";
            UrlSectionSpanish = "fotos-de-antes-y-despues";
        }
    }
}

