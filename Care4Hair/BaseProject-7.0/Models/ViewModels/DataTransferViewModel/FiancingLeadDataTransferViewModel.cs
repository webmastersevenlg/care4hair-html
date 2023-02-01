using System;

namespace BaseProject_7_0.Models.ViewModels
{
    public class FiancingLeadDataTransferViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public int? FirstVisitId { get; set; }
        public int? LastVisitId { get; set; }
        public string Url { get; set; }
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }
        public string Referrer { get; set; }
        public string AcceptComunicationBySms { get; set; }
        public string AcceptComunicationByEmail { get; set; }

        public string ProviderUrl { get; set; }
        public string ProviderName { get; set; }
    }
}