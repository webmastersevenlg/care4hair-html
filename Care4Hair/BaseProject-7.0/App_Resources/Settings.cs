using System.Collections.Specialized;

namespace BaseProject_7_0.App_Resources
{
    public class Settings
    {
        public static IConfiguration Configuration;

        public static string GetStreetAddress
        {
            get
            {
                return Configuration["appSettings:center_address"];
            }
        }
        public static string GetCity
        {
            get
            {
                return Configuration["center_city"];
            }
        }
        public static string GetState
        {
            get
            {
                return Configuration["center_state"];
            }
        }
        public static string GetRegion
        {
            get
            {
                return Configuration["center_region"];
            }
        }
        public static string GetZipCode
        {
            get
            {
                return Configuration["center_zipcode"];
            }
        }
        public static string GetCountry
        {
            get
            {
                return Configuration["center_contry"];
            }
        }
        public static string GetFullAddress
        {
            get
            {
                return Configuration["center_full_address"];
            }
        }

        public static string GetAddressLink
        {
            get
            {
                return Configuration["center_address_link"];
            }
        }



        public static string GetSpanishUrl
        {
            get
            {
                return Configuration["spanish_url"];
            }
        }

        public static string GetGeoRegion
        {
            get
            {
                return Configuration["center_region"];
            }
        }
        public static string GetCenterName
        {
            get
            {
                return Configuration["center_name"];
            }
        }

        public static string GetCenterLogoPath
        {
            get
            {
                return Configuration["center_logo_path"];
            }
        }

        public static string GetCenterLogoLightPath
        {
            get
            {
                return Configuration["center_logo_light_path"];
            }
        }

        public static string GetCenterId
        {
            get
            {
                return Configuration["center_id"];
            }
        }

        public static int GetCenterIdAsInt
        {
            get
            {
                return int.Parse(Configuration["center_id"]);
            }
        }

        public static string GetCenterAcronym
        {
            get
            {
                return Configuration["center_acronym"];
            }
        }

        public static string GetLivechatId
        {
            get
            {
                return Configuration["livechat_id"];
            }
        }

        public static string GetLivechatGroup
        {
            get
            {
                return Configuration["livechat_group"];
            }
        }
          

        public static string GetAnalyticsId
        {
            get
            {
                return Configuration["g4_analytics_id"];
            }
        }

        public static string GetUAAnalyticsId
        {
            get
            {
                return Configuration["ua_analytics_id"];
            }
        }

        public static string GetChatConversionId
        {
            get
            {
                return Configuration["chat_conversion_id"];
            }
        }

        public static string GetCallConversionId
        {
            get
            {
                return Configuration["call_conversion_id"];
            }
        }

        public static string GetContactFormConversionId
        {
            get
            {
                return Configuration["contact_form_conversion_id"];
            }
        }

        public static string GetFinancingInquireConversionId
        {
            get
            {
                return Configuration["financing_inquire_conversion_id"];
            }
        }

        public static string GetPreopFormConversionId
        {
            get
            {
                return Configuration["preop_form_conversion_id"];
            }
        }

        public static string GetEnviroment
        {
            get
            {
                return Configuration["enviroment"];
            }
        }

        public static string GetDomain
        {
            get
            {
                return Configuration["domain"];
            }
        }

        public static string GetFullDomain
        {
            get
            {
                return Configuration["full_domain"];
            }
        }

        public static string GetSpecialsCdnDomain
        {
            get
            {
                return Configuration["specials_cdn_domain"];
            }
        }


        public static string GetEmail
        {
            get
            {
                return Configuration["center_email"];
            }
        }
      
        public static string GetPhone
        {
            get
            {
                return Configuration["center_phone"];
            }
        }
        public static string GetPhoneFormated
        {
            get
            {
                return Configuration["center_phone_formatted"];
            }
        }
        public static string GetTollFreePhone
        {
            get
            {
                return Configuration[""];
            }
        }

        public static string GetFacebook
        {
            get
            {
                return "https://www.facebook.com/" + Configuration["facebook_id"];
            }
        }

        public static string GetYoutubeChannel
        {
            get
            {
                return "https://www.youtube.com/" + Configuration["youtube_channel_id"];
            }
        }

        public static string GetYoutubeApiKey
        {
            get
            {
                return Configuration["youtube_api_key"];
            }
        }

        public static string GetTiktok
        {
            get
            {
                return "https://www.tiktok.com/" + Configuration["tiktok_id"];
            }
        }
   

        public static string GetInstagram
        {
            get
            {
                return "https://www.instagram.com/" + Configuration["instagram_id"];
            }
        }

        public static string GetGoogleReviewsUrl
        {
            get
            {
                return Configuration["google_reviews"];
            }
        }      

 
        public static string GetGoogleCloudApiKey
        {
            get
            {
                return Configuration["google_cloud_api_key"];
            }
        }

        public static string GetGoogleMapsAddressLink
        {
            get
            {
                return Configuration["google_maps_address_link"];
            }
        }

        public static string GetCenterLatitude
        {
            get
            {
                return Configuration["center_latitude"];
            }
        }

        public static string GetCenterLongitude
        {
            get
            {
                return Configuration["center_longitude"];
            }
        }

        public static string GetGeoPosition
        {
            get
            {
                return Configuration["center_latitude"] + ", " + Configuration["center_longitude"];
            }
        }

        public static string GetProfessionalsProfession
        {
            get
            {
                return Vocabulary.ResourceManager.GetString(Configuration["professional_profession"]);
            }
        }

        public static string GetProfessionalsProfessionPlural
        {
            get
            {
                return Vocabulary.ResourceManager.GetString(Configuration["professional_profession_plural"]);
            }
        }

        public static bool OptimizeBundle
        {
            get
            {
                return Configuration["bundle_optimization_status"] == "true" ? true : false; ;
            }
        }
        public static bool CompressHtml
        {
            get
            {
                return Configuration["html_compression_status"] == "true" ? true : false;
            }
        }

        public static bool GetScriptBundleAsync
        {
            get
            {
                return Configuration["script_bundle_async"] == "true" ? true : false;
            }
        }

        public static bool GetStyleBundleAsync
        {
            get
            {
                return Configuration["style_bundle_async"] == "true" ? true : false;
            }
        }

        public static string UseCdn
        {
            get
            {
                return Configuration["Use_CDN"];
            }
        }
        public static string CdnPath
        {
            get
            {
                return Configuration["CDN_Path"];
            }
        }

        public static string GetTheme
        {
            get
            {
                return Configuration["theme_name"];
            }
        }

        public static string GetPhoneErrorNotificationList
        { 
            get
            {
                return Configuration["phone_error_notification_list"];
            }
        }

        public static string GetTwilioAccountSid
        {
            get
            {
                return Configuration["twilio_accountSid"];
            }
        }

        public static string GetTwilioAuthToken
        {
            get
            {
                return Configuration["twilio_authToken"];
            }
        }

        public static string GetTwilioFrom
        {
            get
            {
                return Configuration["twilio_from"];
            }
        }

        public static string GetFacebookPixelId
        {
            get
            {
                return Configuration["facebook_pixel_id"];
            }
        }

        public static string GetRealselfReviewsUrl
        {
            get
            {
                return "realself_reviews_url";
            }
        }

        public static string GetContactFormErrorUrl
        {
            get
            {
                return "contact_form_error_url";
            }
        }


        public static string GetAdwordsPhone
        {
            get
            {
                return Configuration["adwords_phone"];
            }
        }

        public static string GetAdwordsPhoneFormated
        {
            get
            {
                return Configuration["adwords_phone_formated"];
            }
        }


        public static string ReCaptchaPrivateKey
        {
            get
            {
                return Configuration["reCaptchaPrivateKey"];
            }
        }

        public static string ReCaptchaPublicKey
        {
            get
            {
                return Configuration["reCaptchaPublicKey"];
            }
        }

        public static string GetPortalLink
        {
            get
            {
                return Configuration["portal_link"];
            }
        }

        public static string GetFreeConsultationJotFormId
        {
            get
            {
                return Configuration["freeConsultationJotFormId"];
            }
        }
    }
}