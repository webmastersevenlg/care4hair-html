using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaseProject_7_0.Models.ViewModels
{
    public class FilterGroupPartialViewModel
    {
        public int Id { get; set; }
        public int Order { get; set; }
        public string Name { get; set; }
        public string FilterParamName { get; set; }
        public virtual ICollection<FilterChoicePartialViewModel> FilterOptions { get; set; }
        

        public FilterGroupPartialViewModel()
        {
            FilterOptions = new List<FilterChoicePartialViewModel>();
        }      

    }
}