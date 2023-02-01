using BaseProject_7_0.Models.BaseModels;

namespace BaseProject_7_0.Models.ViewModels
{
    public class VideoIndexPageDetailViewModel : IndexPageDetailViewModel
    {
        public VideoIndexPageDetailViewModel()
        {
            Name = "Videos";
            NameSpanish = "Videos";

            ElementTypeName = "Video";
            ElementTypeNameSpanish = "Video";

            ElementTypeNamePlural = "Videos";
            ElementTypeNamePluralSpanish = "Videos";

            AllElementsLabel = "All Videos";
            AllElementsLabelSpanish = "Todos Los Videos";

            UrlSection = "videos";
            UrlSectionSpanish = "videos";
        }
    }
}

