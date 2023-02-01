using BaseProject_7_0.Models.BaseModels;
using System.Collections.Generic;

namespace BaseProject_7_0.Models.ViewModels
{
    public class PreopFormDataTransferViewModel : BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public int HeightFt { get; set; }
        public int HeightIn { get; set; }
        public int WeightLb { get; set; }
        public decimal Bmi { get; set; }
        public string ProfessionalId { get; set; }
        public List<ProfessionalPartialViewModel> Professionals { get; set; }
        public string ServiceId { get; set; }
        public List<ServicePartialViewModel> Services { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public bool? SmokeHabit { get; set; }
        public string SmokeHabitDetails { get; set; }
        public bool? AlchoolHabit { get; set; }
        public string AlchoolHabitDetails { get; set; }
        public bool? PriorSurgeries { get; set; }
        public string PriorSurgeriesDetails { get; set; }
        public bool? Allergies { get; set; }
        public string AllergiesDetails { get; set; }
        public bool? HealthConditions { get; set; }
        public string HealthConditionsDetails { get; set; }
        public bool? Childbirths { get; set; }
        public string ChildbirthsDetails { get; set; }
        public string UrlReferer { get; set; }
        public string Url { get; set; }
        public string UserAgent { get; set; }
        public string IpAddress { get; set; }
        public bool AcceptComunicationByEmail { get; set; }
        public bool AcceptComunicationBySms { get; set; }
        public string NamePropertyName
        {
            get
            {
                return IsEnglish ? "Name" : "NameSpanish";
            }
        }
        public PreopFormDataTransferViewModel()
        {
            SmokeHabit = null;
            AcceptComunicationByEmail = true;
            AcceptComunicationBySms = true;
        }
        public int? FirstVisitId { get; set; }
        public int? LastVisitId { get; set; }
    }
}