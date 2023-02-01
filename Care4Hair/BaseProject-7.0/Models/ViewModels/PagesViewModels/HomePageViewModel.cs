using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.EntityModels.XmlEntities;
using BaseProject_7_0.XmlTools;
using Shyjus.BrowserDetection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class HomePageViewModel : BasePageWithStaticHtmlFilesViewModel
    {
        public ICollection<CategoryPartialViewModel> Categories;
        public ICollection<ProfessionalPartialViewModel> FeaturedProfessionals { get; set; }
        public ICollection<ProfessionalPartialViewModel> Professionals { get; set; }
        public ICollection<ImagePartialViewModel> FeaturedBeforeAndAfterPhotos { get; set; }
        public ICollection<TestimonialPartialViewModel> Testimonials { get; set; }
        public ICollection<ServiceGalleryThumbnailPartialViewModel> ServiceGalleryThumbnails { get; set; }
        public ICollection<InstagramPostPartialViewModel> InstagramPosts { get; set; }
        public ICollection<FinancingOptionPartialViewModel> FinancingOptions { get; set; }
        public ICollection<BlogPostPartialViewModel> BlogPosts { get; set; }
        public ICollection<BlogPostPartialViewModel> RecentFourBlogPosts { get; set; }
        public ICollection<WebSpecialPartialViewModel> Specials { get; set; }


        //public ICollection<VideoObject> VideoObjects { get; set; }





        public string GetOutOfTownLink
        {
            get
            {
                return CurrentLanguage.AbbreviatedName.ToLower() == "en" ?
                    "/out-of-town-patients" : "espanol/pacientes-fuera-de-miami";

            }
        }


        public string GetHomeFinancingText
        {
            get
            {
                return CurrentLanguage.AbbreviatedName.ToLower() == "es"
                ? "Tenemos las mejores opciones de financiamiento, clic en el botón y vea los planes."
                : "We have the best finance options for you, click on the button and see our plans.";
            }
        }

        public ICollection<TestimonialPartialViewModel> GetTestimonials
        {
            get
            {
                return Testimonials.Where(t => t.AbbreviatedLanguage?.ToLower() == CurrentLanguage.AbbreviatedName?.ToLower())
                    .OrderBy(s => Guid.NewGuid()).Take(3).ToArray();
            }
        }

        public HomePageViewModel(IHttpContextAccessor _httpContextAccessor, IBrowserDetector _browserDetector) : base(_httpContextAccessor, _browserDetector)
        {
            SkinName = "HomePageSkin";
            Categories = new List<CategoryPartialViewModel>();
            //ICollection<ServicePartialViewModel> Services = new List<ServicePartialViewModel>();
            FeaturedProfessionals = new List<ProfessionalPartialViewModel>();
            Professionals = new List<ProfessionalPartialViewModel>();
            Testimonials = new List<TestimonialPartialViewModel>();
            ServiceGalleryThumbnails = new List<ServiceGalleryThumbnailPartialViewModel>();
            InstagramPosts = new List<InstagramPostPartialViewModel>();

            var xmlCategories = XmlReader.GetAllElementsByFileName<CategoryEntity>(
                CategoryEntity.XmlFilePath
                );

            var xmlservices = XmlReader.GetElementsByFileNameAttributeNameAndAttributeValue<ServiceEntity>(
                 ServiceEntity.XmlFilePath,
                 "active",
                 "true"
                 );

            var xmlprofessionals = XmlReader.GetElementsByFileNameAttributeNameAndAttributeValue<ProfessionalEntity>(
                ProfessionalEntity.XmlFilePath,
                "active",
                "true"
                );

            var xmlTestimonials = XmlReader.GetElementsByFileNameAttributeNameAndAttributeValue<TestimonialEntity>(
                  TestimonialEntity.XmlFilePath,
                  "active",
                  "true"
                  );


            var xmlInstagramPosts = XmlReader.GetElementsByFileNameAttributeNameAndAttributeValue<InstagramPostEntity>(
               InstagramPostEntity.XmlFilePath,
               "active",
               "true"
               );

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

            foreach (var xmlprofessional in xmlprofessionals)
            {
                ProfessionalPartialViewModel professionalVm = new ProfessionalPartialViewModel();
                professionalVm.MapFromXmlEntity<ProfessionalEntity>(xmlprofessional);
                if (professionalVm.Featured == "true")
                {
                    FeaturedProfessionals.Add(professionalVm);
                }
                Professionals.Add(professionalVm);

            }

            foreach (var xmltestimonial in xmlTestimonials)
            {
                TestimonialPartialViewModel testimonialVm = new TestimonialPartialViewModel();
                testimonialVm.MapFromXmlEntity<TestimonialEntity>(xmltestimonial);
                Testimonials.Add(testimonialVm);
            }
            

            foreach (var xmlInstagramPost in xmlInstagramPosts)
            {
                InstagramPostPartialViewModel xmlInstagramPostVm = new InstagramPostPartialViewModel();
                xmlInstagramPostVm.MapFromXmlEntity<InstagramPostEntity>(xmlInstagramPost);
                InstagramPosts.Add(xmlInstagramPostVm);
            }



            ServiceGalleryThumbnails = new List<ServiceGalleryThumbnailPartialViewModel>()
            {
                new ServiceGalleryThumbnailPartialViewModel(){
                    Service = Categories.SelectMany(c=>c.Services).FirstOrDefault(s=>s.Id=="brazilian-butt-lift"),
                    Professional= Professionals.FirstOrDefault(p=>p.Id=="anthony-hasan"),
                    SingleResultImage = "/content/images/services/gallery-thumbnails/single-result/"+"brazilian-butt-lift"+".jpg",
                    CollageResultImage = "/content/images/services/gallery-thumbnails/collage/"+"brazilian-butt-lift"+".jpg",
                },
                new ServiceGalleryThumbnailPartialViewModel(){
                    Service = Categories.SelectMany(c=>c.Services).FirstOrDefault(s=>s.Id=="breast-augmentation"),
                    Professional= Professionals.FirstOrDefault(p=>p.Id=="jonathan-fisher"),
                    SingleResultImage = "/content/images/services/gallery-thumbnails/single-result/"+"breast-augmentation"+".jpg",
                    CollageResultImage = "/content/images/services/gallery-thumbnails/collage/"+"breast-augmentation"+".jpg",
                },
                new ServiceGalleryThumbnailPartialViewModel(){
                    Service = Categories.SelectMany(c=>c.Services).FirstOrDefault(s=>s.Id=="liposuction"),
                    Professional= Professionals.FirstOrDefault(p=>p.Id=="robert-kagan"),
                    SingleResultImage = "/content/images/services/gallery-thumbnails/single-result/"+"liposuction"+".jpg",
                    CollageResultImage = "/content/images/services/gallery-thumbnails/collage/"+"liposuction"+".jpg",
                },
                new ServiceGalleryThumbnailPartialViewModel(){
                    Service = Categories.SelectMany(c=>c.Services).FirstOrDefault(s=>s.Id=="tummy-tuck"),
                    Professional= Professionals.FirstOrDefault(p=>p.Id=="earl-brewster"),
                    SingleResultImage = "/content/images/services/gallery-thumbnails/single-result/"+"tummy-tuck"+".jpg",
                    CollageResultImage = "/content/images/services/gallery-thumbnails/collage/"+"tummy-tuck"+".jpg",
                }
            };         
        }     
    }

    public class HomePageFeature
    {
        public string Title { get; set; }
        public string TitleSpanish { get; set; }
        public string Text { get; set; }
        public string TextSpanish { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
        public string LinkSpanish { get; set; }
    }
}