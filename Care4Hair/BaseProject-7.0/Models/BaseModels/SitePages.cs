using BaseProject_7_0.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseProject_7_0.XmlTools;
using BaseProject_7_0.Models.EntityModels.XmlEntities;
using BaseProject_7_0.Models.EntityModels.DbEntities;
using System.Collections;
using BaseProject_7_0.Models.BaseModels;
using Microsoft.EntityFrameworkCore;

namespace BaseProject_7_0.Models.BaseModels
{
    public class Site
    {

       private static Site instance;

        public static Site Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Site();
                }
                return instance;
            }
        }

        //////////////////////////////
        public BasePartialViewModel HomePage = new HomePagePartialViewModel();

        public ICollection<BasePartialViewModel> UncategorizedPages;
        public ICollection<ServicePartialViewModel> GalleryServices;
        public ICollection<ServicePartialViewModel> SpecialsServices;
        public ICollection<ProfessionalPartialViewModel> GalleryProfessionals;
        public ICollection<ProfessionalPartialViewModel> SpecialsProfessionals;

        public ICollection<GalleryServicesProfessionals> GalleryServicesProfessionals { get; set; }
        public ICollection<SpecialsServicesProfessionals> SpecialsServicesProfessionals { get; set; }

        //index pages
        public IndexPageDetailViewModel Blog = new BlogIndexPageDetailViewModel();
        public IndexPageDetailViewModel FinancingOptions = new FinancingOptionIndexPageDetailViewModel();
        public IndexPageDetailViewModel Videos = new VideoIndexPageDetailViewModel();
        public IndexPageDetailViewModel Specials = new SpecialIndexPageDetailViewModel();
        public IndexPageDetailViewModel Professionals = new ProfessionalIndexPageDetailViewModel();
        public IndexPageDetailViewModel Testimonials = new TestimonialIndexPageDetailViewModel();
        public IndexPageDetailViewModel Pictures = new PictureIndexPageDetailViewModel();
        public IndexPageDetailViewModel WebReviews = new WebReviewIndexPageDetailViewModel();
        

        public IndexPageDetailViewModel BeforeAndAfterPhotos = new BeforeAndAfterPhotosIndexPageDetailViewModel();

        //indexable pages
        public IndexablePageDetailViewModel BlogPostPage = new BlogPostIndexablePageDetailViewModel();
        public IndexablePageDetailViewModel FinancingOptionPage = new FinancingOptionIndexablePageDetailViewModel();
        public IndexablePageDetailViewModel SppecialOfferPage = new SpecialOfferIndexablePageDetailViewModel();
        public IndexablePageDetailViewModel VideoPage = new VideoIndexablePageDetailViewModel();
        public IndexablePageDetailViewModel SpecialPage = new SpecialIndexablePageDetailViewModel();
        public IndexablePageDetailViewModel ProfessionalPage = new ProfessionalIndexablePageDetailViewModel();

        ///uncategorizedpages acces properties
        //////////////////////////////        

        public BasePartialViewModel Contact
        {
            get
            {
                
                return UncategorizedPages.FirstOrDefault(u => u.Id == "contact");
            }
        }

        public BasePartialViewModel About
        {
            get
            {
                return UncategorizedPages.FirstOrDefault(u => u.Id == "about");
            }
        }

        public BasePartialViewModel PrivacyPolicy
        {
            get
            {
                return UncategorizedPages.FirstOrDefault(u => u.Id == "privacypolicy");
            }
        }


        public BasePartialViewModel MiamiLocation
        {
            get
            {
                return UncategorizedPages.FirstOrDefault(u => u.Id == "miami");
            }
        }

        public BasePartialViewModel PressRelease
        {
            get
            {
                return UncategorizedPages.FirstOrDefault(u => u.Id == "press-release");
            }
        }

        public BasePartialViewModel Disclaimer
        {
            get
            {
                return UncategorizedPages.FirstOrDefault(u => u.Id == "disclaimer");
            }
        }

        public BasePartialViewModel OutOfTownPatients
        {
            get
            {
                return UncategorizedPages.FirstOrDefault(u => u.Id == "outoftownpatients");
            }
        }

        public BasePartialViewModel StateOfArtFacility
        {
            get
            {
                return UncategorizedPages.FirstOrDefault(u => u.Id == "stateofartfacility");
            }
        }

        public BasePartialViewModel  PostSurgicalCompressionGarments
        {
            get
            {
                return UncategorizedPages.FirstOrDefault(u => u.Id == "postsurgicalcompressiongarments");
            }
        }

        public BasePartialViewModel PreopFrequentQuestionsAnswers
        {
            get
            {
                return UncategorizedPages.FirstOrDefault(u => u.Id == "preopfrequentquestionsanswers");
            }
        }

        public BasePartialViewModel CancellationPolicy
        {
            get
            {
                return UncategorizedPages.FirstOrDefault(u => u.Id == "cancellationpolicy");
            }
        }
        public BasePartialViewModel Calculateyourbmi
        {
            get
            {
                return UncategorizedPages.FirstOrDefault(u => u.Id == "bmi-requirements");
            }
        }

        public BasePartialViewModel PostOpMassage
        {
            get
            {
                return UncategorizedPages.FirstOrDefault(u => u.Id == "post-op-massage");
            }
        }



        private Site()
        {
            UncategorizedPages = new List<BasePartialViewModel>();
            GalleryServices = new List<ServicePartialViewModel>();
            SpecialsServices = new List<ServicePartialViewModel>();
            SpecialsProfessionals = new List<ProfessionalPartialViewModel>();
            GalleryProfessionals = new List<ProfessionalPartialViewModel>();
           

            //loading uncategorizedPartialPages 
            //================================================================================================================
            var xmlUncategorizedPages = XmlReader.GetAllElementsByFileName<UncategorizedPageEntity>(
              UncategorizedPageEntity.XmlFilePath
              );

            foreach (var xmlUncategorizedPage in xmlUncategorizedPages)
            {
                UncategorizedPagePartialViewModel uncategorizedPageVm = new UncategorizedPagePartialViewModel();
                uncategorizedPageVm.MapFromXmlEntity<UncategorizedPageEntity>(xmlUncategorizedPage);
                UncategorizedPages.Add(uncategorizedPageVm);
            }

            //loading services and professionals with pictures
            //================================================================================================================           
            using (var db = new BscrmCare4hairContext())
            {
                GalleryServicesProfessionals = db.ActiveWebPictures.GroupBy(p => new { p.ServiceUrl, p.ProfessionalUrl })
                                                  .Select(e => new GalleryServicesProfessionals()
                                                  {
                                                      ServiceUrl = e.Key.ServiceUrl,
                                                      ProfessionalUrl = e.Key.ProfessionalUrl,
                                                  }).ToArray();


                var today = DateTime.Now.Date;
                SpecialsServicesProfessionals = db.WebSpecials.Include(s=>s.WebRelatedProcedures)
                                                  .Where(s => s.RunFrom <= today && today < s.RunUntil)
                                                  .Where(s => s.WebRelatedProcedures.Count == 1)
                                                  .GroupBy(s => new { ServiceUrl = s.WebRelatedProcedures.FirstOrDefault().UrlSection, ProfessionalUrl = s.WebRelatedDoctors.FirstOrDefault().UrlSection })
                                                  .Select(e => new SpecialsServicesProfessionals()
                                                  {
                                                      ServiceUrl = e.Key.ServiceUrl,
                                                      ProfessionalUrl = e.Key.ProfessionalUrl,
                                                  }).ToArray();
            }

            var activeXmlServices = XmlReader.GetAllElementsByFileName<ServiceEntity>(ServiceEntity.XmlFilePath).Where(s => s.Active.ToLower()=="true").ToArray();

            var activeXmlProfessionals = XmlReader.GetAllElementsByFileName<ProfessionalEntity>(ProfessionalEntity.XmlFilePath).Where(p => p.Active.ToLower() == "true").ToArray();

            var activeXmlServicesWihActivePicturesInTheDataBase = activeXmlServices.Where(s => GalleryServicesProfessionals.Any(e => (activeXmlProfessionals.Any(p => p.DbUrl == e.ProfessionalUrl)) && e.ServiceUrl == s.DbUrl)).ToArray();

            var activeXmlServicesWihActiveSpecialsInTheDataBase = activeXmlServices.Where(s => SpecialsServicesProfessionals.Any(e => e.ServiceUrl == s.DbUrl)).ToArray();


            var activeXmlProfessionalsWihActivePicturesInTheDataBase = activeXmlProfessionals.Where(s => GalleryServicesProfessionals.Any(e => e.ProfessionalUrl == s.DbUrl)).ToArray();

            var activeXmlProfessionalsWihActiveSpecialsInTheDataBase = activeXmlProfessionals.Where(s => SpecialsServicesProfessionals.Any(e => e.ProfessionalUrl == s.DbUrl)).ToArray();


            foreach (var xmlService in activeXmlServicesWihActivePicturesInTheDataBase)
            {
                ServicePartialViewModel servicePartialVm = new ServicePartialViewModel();
                servicePartialVm.MapFromXmlEntity<ServiceEntity>(xmlService);
                GalleryServices.Add(servicePartialVm);
            }

            foreach (var xmlService in activeXmlServicesWihActiveSpecialsInTheDataBase)
            {
                ServicePartialViewModel servicePartialVm = new ServicePartialViewModel();
                servicePartialVm.MapFromXmlEntity<ServiceEntity>(xmlService);
                SpecialsServices.Add(servicePartialVm);
            }

            foreach (var xmlProfessional in activeXmlProfessionalsWihActiveSpecialsInTheDataBase)
            {
                ProfessionalPartialViewModel professionalPartialVm = new ProfessionalPartialViewModel();
                professionalPartialVm.MapFromXmlEntity<ProfessionalEntity>(xmlProfessional);
                SpecialsProfessionals.Add(professionalPartialVm);
            }

            foreach (var xmlProfessional in activeXmlProfessionalsWihActivePicturesInTheDataBase)
            {
                ProfessionalPartialViewModel professionalPartialVm = new ProfessionalPartialViewModel();
                professionalPartialVm.MapFromXmlEntity<ProfessionalEntity>(xmlProfessional);
                GalleryProfessionals.Add(professionalPartialVm);
            }
        }
        
    }
}