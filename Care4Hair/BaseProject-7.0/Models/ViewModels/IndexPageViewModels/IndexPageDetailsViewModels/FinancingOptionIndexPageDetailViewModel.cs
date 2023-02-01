using BaseProject_7_0.Models.BaseModels;

namespace BaseProject_7_0.Models.ViewModels
{
    public class FinancingOptionIndexPageDetailViewModel : IndexPageDetailViewModel
    { 
        public FinancingOptionIndexPageDetailViewModel() 
        {            
            Name = "Financing";
            NameSpanish = "Financiamiento";

            ElementTypeName = "Financing Option";
            ElementTypeNameSpanish = "Opción de Financiamiento";

            ElementTypeNamePlural = "Financing Options";
            ElementTypeNamePluralSpanish = "Opciones de Financiamiento";

            AllElementsLabel = "All Financing Options";
            AllElementsLabelSpanish = "Todas Las Opciones de Financiamiento";

            UrlSection = "financing-options";
            UrlSectionSpanish = "opciones-de-financiamiento";
        }
    }
}