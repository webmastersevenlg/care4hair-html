using BaseProject.Models.BaseModels;
using BaseProject.Models.EntityModels.XmlEntities;
using BaseProject.Models.ViewModels;
using BaseProject.XmlTools;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Web.Mvc;
using System.Web.Routing;

namespace BaseProject.Controllers
{
    public class ProfessionalIndexPageController : BaseController
    {
        public ActionResult Index(string abbreviatedLanguage, string page=null, string cleanCache=null)
        {
            page = page == null ? "1" : page;
            int pageNumber;

            bool pageIsValid = int.TryParse(page, out pageNumber);
            if (!pageIsValid)
                return HttpNotFound();

            ProfessionalIndexPageViewModel vm = new ProfessionalIndexPageViewModel(Request);           

            vm.PageNumber = pageNumber;

            vm.Size = 48;

            ICollection<ProfessionalEntity> allEntityElements = new List<ProfessionalEntity>();
            ICollection<ProfessionalPartialViewModel> allPartialViewModelElements = new List<ProfessionalPartialViewModel>();
            ICollection<ProfessionalPartialViewModel> allElements = new List<ProfessionalPartialViewModel>();
            ICollection<ProfessionalPartialViewModel> filteredElements = new List<ProfessionalPartialViewModel>();
            Dictionary<string, string> currentFilters = new Dictionary<string, string>();           
            currentFilters.Add("abbreviatedLanguage", abbreviatedLanguage);

            vm.AllElements = new List<IndexablePartialViewModel>();
            vm.FilteredElements = new List<IndexablePartialViewModel>();
            vm.CurrentFilters = new RouteValueDictionary();
            vm.CurrentFilters.Add("abbreviatedLanguage", abbreviatedLanguage);
            vm.FilterGroups = new List<FilterGroupPartialViewModel>();



            try
            {
                allEntityElements = XmlReader.GetAllElementsByFileName<ProfessionalEntity>(ProfessionalEntity.XmlFilePath)
                                    .Where(f => f.Active == "true").ToArray();
                foreach (var entityElement in allEntityElements)
                {
                    ProfessionalPartialViewModel elementPartialViewModel = new ProfessionalPartialViewModel();
                    elementPartialViewModel.MapFromDbEntity<ProfessionalEntity>(entityElement);
                    elementPartialViewModel.IndexablePageDetail = new ProfessionalIndexablePageDetailViewModel()
                    {
                        Url = elementPartialViewModel.Url,
                        UrlSpanish = elementPartialViewModel.UrlSpanish
                    };
                    vm.AllElements.Add(elementPartialViewModel);
                    vm.FilteredElements.Add(elementPartialViewModel);

                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            return BaseIndex(vm);
        }
    }
}