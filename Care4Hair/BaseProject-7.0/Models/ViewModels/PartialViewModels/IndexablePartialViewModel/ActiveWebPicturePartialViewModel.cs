using BaseProject_7_0.App_Resources;
using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.EntityModels.DbEntities;
using System;

namespace BaseProject_7_0.Models.ViewModels
{
    public class ActiveWebPicturePartialViewModel : IndexablePartialViewModel
    {

        //this fields is for easy navigation to the entityModel that this map from.
        public ActiveWebPicture NeverUsedField;

        public int WebPictureID { get; set; }
        public string PictureTitle { get; set; }
        public string PictureFileName { get; set; }
        public Nullable<int> PictureOrder { get; set; }
        public Nullable<int> WebPicResultID { get; set; }
        public string PatientID { get; set; }
        public string ServiceName { get; set; }
        public string ServiceNameSpanish { get; set; }
        public string ServiceUrl { get; set; }
        public string ServiceUrlSpanish { get; set; }
        public string ProfessionalUrl { get; set; }
        public string ProfessionalUrlSpanish { get; set; }
        public string ProfessionalName { get; set; }
        public string ProfessionalImageName { get; set; }


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


        public string GetImage(string resolution)
        {
            return "https://" + Settings.GetDomain + "/cdn/pictures/" + ProfessionalUrl +
                    "/" + PatientID + "/" + WebPicResultID + "/" + resolution + "/" + PictureFileName + "-" + WebPictureID + ".jpg";
        }
    }
}