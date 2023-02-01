using BaseProject_7_0.App_Resources;
using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.EntityModels.XmlEntities;
using BaseProject_7_0.XmlTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class MenuPartialViewModel : BaseViewModel
    {
        public ICollection<ProfessionalPartialViewModel> Professionals { get; set; }
        public ICollection<CategoryPartialViewModel> Categories { get; set; }
        public ICollection<HomePagePartialViewModel> UncategorizedPages { get; set; }
        public ICollection<ServicePartialViewModel> MainServices { get; set; }

        public MenuPartialViewModel()
        {
            UncategorizedPages = new List<HomePagePartialViewModel>();
            Professionals = new List<ProfessionalPartialViewModel>();           
            Categories = new List<CategoryPartialViewModel>();            


        var xmlUncategorizedPages = XmlReader.GetAllElementsByFileName<UncategorizedPageEntity>(
                UncategorizedPageEntity.XmlFilePath
                );

            var xmlprofessionals = XmlReader.GetElementsByFileNameAttributeNameAndAttributeValue<ProfessionalEntity>(
                ProfessionalEntity.XmlFilePath,
                "active",
                "true"
                );

            var xmlCategories = XmlReader.GetAllElementsByFileName<CategoryEntity>(
                CategoryEntity.XmlFilePath
                );

            var xmlservices = XmlReader.GetElementsByFileNameAttributeNameAndAttributeValue<ServiceEntity>(
                 ServiceEntity.XmlFilePath,
                 "active",
                 "true"
                 );
            
            foreach (var xmlprofessional in xmlprofessionals)
            {
                ProfessionalPartialViewModel professionalPVM = new ProfessionalPartialViewModel();
                professionalPVM.MapFromXmlEntity<ProfessionalEntity>(xmlprofessional);
                Professionals.Add(professionalPVM);
            }

            foreach (var xmlUncategorizedPage in xmlUncategorizedPages)
            {
                HomePagePartialViewModel uncategorizedPageVm = new HomePagePartialViewModel();
                uncategorizedPageVm.MapFromXmlEntity<UncategorizedPageEntity>(xmlUncategorizedPage);
                UncategorizedPages.Add(uncategorizedPageVm);
            }

            foreach (var xmlcategory in xmlCategories)
            {
                foreach (var xmlservice in xmlservices.Where(s => s.Categories.Any(c => c.Id == xmlcategory.Id)))
                {
                    xmlcategory.Services.Add(xmlservice);
                }
                CategoryPartialViewModel categoryPVM = new CategoryPartialViewModel();
                categoryPVM.MapFromXmlEntity<CategoryEntity>(xmlcategory);
                Categories.Add(categoryPVM);
            }
        }
    }

}