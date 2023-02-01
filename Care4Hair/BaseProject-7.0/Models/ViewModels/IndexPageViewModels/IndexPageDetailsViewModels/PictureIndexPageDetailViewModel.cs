using BaseProject_7_0.Models.BaseModels;

namespace BaseProject_7_0.Models.ViewModels
{
    public class PictureIndexPageDetailViewModel : IndexPageDetailViewModel
    {
        public PictureIndexPageDetailViewModel() 
        {
            Name = "Before and After";
            NameSpanish = "Antes y Después";

            ElementTypeName = "Picture";
            ElementTypeNameSpanish = "Foto";

            ElementTypeNamePlural = "Pictures";
            ElementTypeNamePluralSpanish = "Fotos";

            AllElementsLabel = "All Pictures";
            AllElementsLabelSpanish = "Todas Las Fotos";

            UrlSection = "before-and-after";
            UrlSectionSpanish = "antes-y-despues";
        }
    }
}