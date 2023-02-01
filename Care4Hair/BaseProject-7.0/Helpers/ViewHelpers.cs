using BaseProject_7_0.App_Resources;
using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Helpers
{
    public class ViewHelpers
    {
        public static IHtmlContent MobileSlide(string MobileSlideImgUrl, string MobileSlideImageAlt, string Caption = null)
        {
            var result = String.Format("<div><div class='home-fader animate-top animate-time-1000'> <div class='swiper-wrapper'> <div class='swiper-slide'> <img class='responsive-image no-bottom' src='" + MobileSlideImgUrl + "' alt='" + MobileSlideImageAlt + "' title='" + MobileSlideImageAlt + "'><span>" + Caption + "</span></div></div></div></div>");
            return new HtmlString(result.Replace("'", "\""));
        }

        public static IHtmlContent Picture(string src, string alt, string placeholderSrc = "", string customClass = "", string customAttributes = "")
        {
            var cdnPath = bool.Parse(Settings.UseCdn) ? Settings.CdnPath : "";

            src = src.Replace(Settings.GetFullDomain, "");
                
            
            string fileExtension = Path.GetExtension(src);


            if (fileExtension == ".jpg" || fileExtension == ".jpeg")
            {
                var result = String.Format("<picture><source srcset='' data-srcset = '" + cdnPath + src.Replace("jpg", "webp") + "' type = 'image/webp'><source srcset='' data-srcset = '" + cdnPath + src + "' type = 'image/jpeg'><img src ='" + placeholderSrc + "' data-src = '" + cdnPath + src + "' class='img-responsive " + customClass + "' alt='" + alt + "' " + customAttributes + "></picture>");
                return new HtmlString(result.Replace("'", "\""));
            }
            if (fileExtension == ".png" || fileExtension == ".png")
            {
                var result = String.Format("<picture><source srcset='' data-srcset = '" + cdnPath + src.Replace("png", "webp") + "' type = 'image/webp' ><source srcset='' data-srcset = '" + cdnPath + src + "' type = 'image/png'><img src ='" + placeholderSrc + "' data-src = '" + cdnPath + src + "' class='img-responsive " + customClass + "' alt='" + alt + "' " + customAttributes + "></picture>");
                return new HtmlString(result.Replace("'", "\""));
            }

            return new HtmlString("not jpg, jpeg, or png");
        }

        public static IHtmlContent PictureNoWebpReady(string src, string alt, string placeholderSrc = "", string customClass = "", string customAttributes = "")
        {
            var cdnPath = bool.Parse(Settings.UseCdn) ? Settings.CdnPath : "";

            src = src.Replace(Settings.GetFullDomain, "");


            string fileExtension = Path.GetExtension(src);


            if (fileExtension == ".jpg" || fileExtension == ".jpeg")
            {
                var result = String.Format("<picture><source srcset='' data-srcset = '" + cdnPath + src + "' type = 'image/jpeg'><img src ='" + placeholderSrc + "' data-src = '" + cdnPath + src + "' class='" + customClass + "' alt='" + alt + "' " + customAttributes + "></picture>");
                return new HtmlString(result.Replace("'", "\""));
            }
            if (fileExtension == ".png" || fileExtension == ".png")
            {
                var result = String.Format("<picture><source srcset='' data-srcset = '" + cdnPath + src + "' type = 'image/png'><img src ='" + placeholderSrc + "' data-src = '" + cdnPath + src + "' class='" + customClass + "' alt='" + alt + "' " + customAttributes + "></picture>");
                return new HtmlString(result.Replace("'", "\""));
            }

            return new HtmlString("not jpg, jpeg, or png");
        }


        public static IHtmlContent ImageSrc(string src)
        {
            var cdnPath = bool.Parse(Settings.UseCdn) ? Settings.CdnPath : "";
            var result = String.Format(cdnPath + src);
            return new HtmlString(result);
        }

        public static IHtmlContent VideoSrc(string src)
        {
            var cdnPath = bool.Parse(Settings.UseCdn) ? Settings.CdnPath : "";
            var result = String.Format(cdnPath + src);
            return new HtmlString(result);
        }
    }

}