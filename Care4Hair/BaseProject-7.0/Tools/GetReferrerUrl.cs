using System;


namespace BaseProject_7_0.Tools
{
    public static class GetReferrerUrl
    {
        public static string GetByRequest(Uri urlReferrer, string userAgent)
        {
            if (urlReferrer != null)
            {
                return urlReferrer.AbsoluteUri;
            }
            else
            {
                if (userAgent.ToLower().Contains("instagram"))
                    return "instagram by User Agent";
                return "Direct Traffic";
            }
        }

    }
}
