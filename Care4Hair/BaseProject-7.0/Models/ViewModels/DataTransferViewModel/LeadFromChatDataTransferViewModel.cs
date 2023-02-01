using System;

namespace BaseProject_7_0.Models.ViewModels
{
    public class LeadFromChatDataTransferViewModel
    {
        public int Id { get; set; }
        public string ChatId { get; set; }
        public string VisitorId { get; set; }
        public string ClientPhone { get; set; }
        public string ClientEmail { get; set; }
        public DateTime Date { get; set; }
        public int? FirstVisitId { get; set; }
        public int? LastVisitId { get; set; }
        public string Url { get; set; }
        public string Referrer { get; set; }
        public bool Processed { get; set; }
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }
    }
}