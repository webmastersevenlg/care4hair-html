using System.Collections.Generic;
using BaseProject_7_0.Models.BaseModels;
using System.Linq;
using BaseProject_7_0.App_Resources;
using BaseProject_7_0.Models.EntityModels.XmlEntities;

namespace BaseProject_7_0.Models.ViewModels
{
    public class ProfessionalPartialViewModel : IndexablePartialViewModel
    {
        //this fields is for easy navigation to the entityModel that this map from.
        public ProfessionalEntity NeverUsedField;

        public string Keywords { get; set; }
        public string KeywordsSpanish { get; set; }
        public string HonorificPrefix { get; set; }
        public string HonorificSuffix { get; set; }
        public string HonorificPrefixSpanish { get; set; }
        public string HonorificSuffixSpanish { get; set; }
        public string WorkLocation { get; set; }
        public string JobTitle { get; set; }
        public string JobTitleSpanish { get; set; }
        public string BriefIntroForAboutPage { get; set; }
        public string BriefIntroForAboutPageSpanish { get; set; }

        public decimal? BblMaxBmi { get; set; }


        public ICollection<CategoryPartialViewModel> Categories;
        public ICollection<VideoPartialViewModel> Videos;

        public string GetUrlPageFromDbModel
        {
            get
            {
                return "/dr-" + Url;
            }
        }

        public string GetBriefIntroForAboutPage
        {
            get
            {
                return IsEnglish ? BriefIntroForAboutPage : BriefIntroForAboutPageSpanish ;
            }
        }


        public string GetHonorificPrefix
        {
            get
            {
                return IsEnglish ? HonorificPrefix : HonorificPrefix;
            }
        }


        public string GetHonorificSuffix
        {
            get
            {
                return IsEnglish ? HonorificSuffix : HonorificSuffixSpanish;
            }
        }
    


        public string GetByThisProfessionalLabel
        {
            get
            {
                return IsEnglish ? "por " + Name : "by " + Name;
            }
        }

        public string GetJobTitle
        {
            get
            {
                return IsEnglish ? JobTitle : JobTitleSpanish;
            }
        }

        //static members
        //============================================================================================
        public static string GetProfession
        {
            get
            {
                return Settings.GetProfessionalsProfession;
            }
        }

        public static string GetProfessionPlural
        {
            get
            {
                return Settings.GetProfessionalsProfessionPlural;
            }
        }

        public static string GetEntityName()
        {
            return GetProfession;
        }

        public ProfessionalPartialViewModel()
        {
            IndexablePageDetail = new ProfessionalIndexablePageDetailViewModel();
            ImagesFolderPath = "/content/images/professionals";
        }
    }
}