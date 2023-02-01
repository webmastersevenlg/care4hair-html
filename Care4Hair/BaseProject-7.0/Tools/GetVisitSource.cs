using Microsoft.Extensions.Primitives;

namespace BaseProject_7_0.Tools
{
    public static class GetVisitSource
    {
        public static string GetByRequest(Uri urlReferrer, Dictionary<string, StringValues> queryString, string userAgent)
        {
            var referrerUrl = urlReferrer?.AbsoluteUri;
            var sourcePlatform = queryString.GetValueOrDefault("source_platform").ToString();
            var utmMedium = queryString.GetValueOrDefault("utm_medium").ToString();

            if (referrerUrl != null || sourcePlatform != null || utmMedium != null || userAgent != null)
            {
                if (CheckReferrerNameAgainstRequestData("google", referrerUrl, sourcePlatform, null, null))
                    return "google";

                if (CheckReferrerNameAgainstRequestData("bing", referrerUrl, sourcePlatform, null, null))
                    return "bing";

                if (CheckReferrerNameAgainstRequestData("yahoo", referrerUrl, sourcePlatform, null, null))
                    return "yahoo";

                if (CheckReferrerNameAgainstRequestData("youtube", referrerUrl, sourcePlatform, null, null))
                    return "youtube";

                if (CheckReferrerNameAgainstRequestData("instagram", referrerUrl, sourcePlatform, utmMedium, userAgent))
                    return "instagram";

                if (CheckReferrerNameAgainstRequestData("facebook", referrerUrl, sourcePlatform, utmMedium, userAgent))
                    return "facebook";

                if (CheckReferrerNameAgainstRequestData("mailchimp", referrerUrl, sourcePlatform, utmMedium, null))
                    return "mailchimp";

                if (CheckReferrerNameAgainstRequestData("madmimi", referrerUrl, sourcePlatform, utmMedium, null))
                    return "madmimi";

                if (CheckReferrerNameAgainstRequestData("realself", referrerUrl, sourcePlatform, null, null))
                    return "realself";

                if (urlReferrer != null)
                {
                    var referrerHost = urlReferrer.Host;
                    return referrerHost;
                }
            }

            return "Direct Traffic";

        }

        public static bool CheckReferrerNameAgainstRequestData(string referrerName, string referrerUrl, string sourcePlatform, string utmMedium, string userAgent)
        {
            if ((referrerUrl != null && referrerUrl.ToLower().Contains(referrerName)) ||
                (sourcePlatform != null && sourcePlatform.ToLower().Contains(referrerName)) ||
                (utmMedium != null && utmMedium.ToLower().Contains(referrerName)) ||
                (userAgent != null && userAgent.ToLower().Contains(referrerName)))
            {
                return true;
            }
            return false;
        }
    }
}