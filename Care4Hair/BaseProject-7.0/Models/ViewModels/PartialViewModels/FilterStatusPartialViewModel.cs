using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class FilterStatusPartialViewModel
    {
        public string currentFilter { get; set; }
        public ICollection<GalleryFilterPartialViewModel> filtersApplied { get; set; }
        public ICollection<GalleryFilterPartialViewModel> filtersAvaiables =
            new List<GalleryFilterPartialViewModel>
            {
                new GalleryFilterPartialViewModel("Doctor", null,  
                    new List<FilterOptionPartialViewModel>{
                        new FilterOptionPartialViewModel("Anthony Hasan MD","dr-anthony-hasan", null, 0),
                        new FilterOptionPartialViewModel("Jonathan Fisher MD","dr-jonathan-fisher", null, 0),
                        //new FilterOption("James McAdoo MD","dr-james-mcadoo", null, 0),
                        //new FilterOption("Orlando Llorente MD","dr-orlando-llorente", null, 0),
                        new FilterOptionPartialViewModel("Ravinder Jarial MD","dr-ravinder-jarial", null, 0),
                        new FilterOptionPartialViewModel("Arnaldo Valls MD","dr-arnaldo-valls", null, 0),
                        //new FilterOption("Camille Chavez MD","dr-camille-chavez", null, 0),
                        //new FilterOption("Daniel Calva MD","dr-daniel-calva", null, 0),
                        new FilterOptionPartialViewModel("Amaryllis Pascual MD","dr-amaryllis-pascual", null, 0),
                        new FilterOptionPartialViewModel("Carlos Verdeza MD","dr-carlos-verdeza-md", null, 0),
                        //new FilterOption("Tim Sayed","dr-tim-sayed", null, 0)
                    }),
                    new GalleryFilterPartialViewModel("Procedure", null,  
                    new List<FilterOptionPartialViewModel>{ 
                        new FilterOptionPartialViewModel("Rhinoplasty","rhinoplasty-miami", null, 0),
                        new FilterOptionPartialViewModel("Breast Augmentation","breast-augmentation-miami", null, 0),
                        new FilterOptionPartialViewModel("Tummy Tuck","tummy-tuck-miami", null, 0),
                        new FilterOptionPartialViewModel("Brazilian Butt Lift","brazilian-butt-lift-miami", null, 0),
                        new FilterOptionPartialViewModel("Liposuction","liposuction-miami", null, 0),
                        new FilterOptionPartialViewModel("Breast Reduction","breast-reduction-miami-mammoplasty", null, 0),
                        new FilterOptionPartialViewModel("Breast Lift","breast-lift-miami", null, 0),
                        new FilterOptionPartialViewModel("Mommy Makeover","mommy-makeover-miami", null, 0),
                        new FilterOptionPartialViewModel("Facelift","facelift-miami", null, 0),
                        new FilterOptionPartialViewModel("Blepharoplasty","blepharoplasty-eyelid-surgery-miami", null, 0),
                        new FilterOptionPartialViewModel("Weight Loss","weight-loss-miami", null, 0)
                    })
            };
    }


    
}