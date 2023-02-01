using System.ComponentModel.DataAnnotations.Schema;
namespace BaseProject_7_0.Models.ViewModels
{
    public class FilterChoicePartialViewModel
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public bool Selected { get; set; }
        public string Link { get; set; }
        public int Avaiability { get; set; }
        public int PublishedAvaiability { get; set; }
        public int UnPublishedAvaiability { get; set; }
        public string FilterNameLabel { get; set; }
        public string FilterValueLabel { get; set; }
        public string UrlSection { get; set; }
        public int Order { get; set; }
        public FilterGroupPartialViewModel FilterGroup { get; set; }

        [NotMapped]
        public string SelectedStatusClass
        {
            get 
            {
                return Selected ? "fa fa-check-square-o" : "fa fa-square-o";
            } 
        }
        [NotMapped]
        public string AvaiablilityStatusClass
        {
            get
            {
                return Avaiability > 0 ? "" : "disabledLabelFor";
            }
        }

        [NotMapped]
        public string LinkClass
        {
            get
            {
                return FilterGroup.Name == "Ammount per Rating" ? "ratingOptionClass ratingValue" + Label : "";
            }
        }
    }
}