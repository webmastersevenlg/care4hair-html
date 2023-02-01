using BaseProject_7_0.App_Resources;
using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.EntityModels.DbEntities;
using System;
using System.ComponentModel.DataAnnotations;

namespace BaseProject_7_0.Models.ViewModels
{ 
    public class WebReviewPartialViewModel : IndexablePartialViewModel
    {
        public string ProfessionalUrl { get; set; }
        public string ProfessionalName { get; set; }
        public string ServiceUrl { get; set; }
        public string ServiceName { get; set; }
        public string ServiceUrlSpanish { get; set; }
        public string ServiceNameSpanish { get; set; }
        public int ExternalId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public float Rating { get; set; }
        public string Text { get; set; }
        public int ReviewTypeId { get; set; }
        public Nullable<int> CenterId { get; set; }
        public int SourceId { get; set; }
        public Nullable<int> StatusId { get; set; }
        public int PublishSurvey { get; set; }
        public int SurveyTemplateID { get; set; }
        public bool IsSatified { get; set; }
        public bool IsFillSurvey { get; set; }
        public Nullable<int> SurveyCustomerID { get; set; }
        public Nullable<int> SurveyGeneralAnswerId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }


        public float GetRatingInPercent 
        {
            get
            {
                return (Rating * 100) / 5;
            }
        }

        public bool IsPublished
        {
            get
            {
                return StatusId == 1;
            }
        }

        public bool IsDestined
        {
            get
            {
                return StatusId != 2 && StatusId != 0 && StatusId != null;
            }
        }

        public string ReviewPrivacy
        {
            get
            {
                return PublishSurvey.ToString();
            }
        }

        public string ReviewAction
        {
            get
            {
                return SurveyTemplateID == 1 ? "Call" : (SurveyTemplateID == 2 ? "Visits" : "Other");
            }
        }

        public string ReviewFilledOrNot
        {
            get
            {
                return IsFillSurvey.ToString();
            }
        }

        public string ReviewSatisfaction
        {
            get
            {
                return IsSatified.ToString();
            }
        }

        public string GetServiceUrl
        {
            get
            {
                return IsEnglishThread ? ServiceUrl : ServiceUrlSpanish;
            }
        }


        public string GetServiceName
        {
            get
            {
                return IsEnglishThread ? ServiceName : ServiceNameSpanish;
            }
        }


        public static string GetProfessionalIdProperty()
        {
            return "ProfessionalUrl";
        }

        public static string GetServiceIdProperty()
        {
            return IsEnglishThread ? "ServiceUrl" : "ServiceUrlSpanish";
        }
    }
}