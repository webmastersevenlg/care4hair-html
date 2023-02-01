using System;

namespace BaseProject_7_0.Models.ViewModels
{
    public class VisitDataTransferViewModel
    {
        public string Url { get; set; }
        public string Referrer { get; set; }
        public DateTime Date { get; set; }
        public UrlDataDataTransferViewModel UrlData { get; set; }
        public string FullReferrer { get; set; }
        public string UserHostAddress { get; set; }
        public string UserAgent { get; set; }

    }
}