using BaseProject_7_0.Models.BaseModels;

namespace BaseProject_7_0.Models.ViewModels
{
    public class BlogIndexPageDetailViewModel : IndexPageDetailViewModel
    {        
        public BlogIndexPageDetailViewModel() 
        {
            Name = "Blog";
            NameSpanish = "Publicaciones";

            ElementTypeName = "Blog Post";
            ElementTypeNameSpanish = "Publicación";

            ElementTypeNamePlural = "Blog Posts";
            ElementTypeNamePluralSpanish = "Publicaciones";

            AllElementsLabel = "All Blog Posts";
            AllElementsLabelSpanish = "Todas Las Publicaciones";

            UrlSection = "blog";
            UrlSectionSpanish = "publicaciones";
        }
    }
}