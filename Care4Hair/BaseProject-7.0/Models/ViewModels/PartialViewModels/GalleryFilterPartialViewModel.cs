using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class GalleryFilterPartialViewModel
    {
        public string filterName { get; set; }
        public string filterValue { get; set; }
        public string filterCaption { get; set; }
        public string filterRemovalLink { get; set; }
        public ICollection<FilterOptionPartialViewModel> optionsAvaiables { get; set; }

        public GalleryFilterPartialViewModel(string filterName, string filterValue, ICollection<FilterOptionPartialViewModel> optionsAvaiables)
        {
            this.filterName = filterName;
            this.filterValue = filterValue;
            this.optionsAvaiables = optionsAvaiables;
        }
    }
}