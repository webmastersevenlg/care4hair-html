using BaseProject_7_0.Models.BaseModels;

namespace BaseProject_7_0.Models.ViewModels
{
    public class ProfessionalIndexPageDetailViewModel : IndexPageDetailViewModel
    {
        public ProfessionalIndexPageDetailViewModel() 
        {
            Name = "Medical Staff";
            NameSpanish = "Personal Médico";

            ElementTypeName = "Doctor";
            ElementTypeNameSpanish = "Doctor";

            ElementTypeNamePlural = "Doctors";
            ElementTypeNamePluralSpanish = "Doctores";

            AllElementsLabel = "All Doctors";
            AllElementsLabelSpanish = "Todos Los Doctores";

            UrlSection = "medical-staff";
            UrlSectionSpanish = "personal-medico";
        }
     }
}