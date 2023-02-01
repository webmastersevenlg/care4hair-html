using System.Collections.Generic;

namespace BaseProject_7_0.Models.ViewModels
{
    public class ServiceGroupPartialViewModel
    {
        public string ServiceGroupName { get; set; }
        public ICollection<ServicePartialViewModel> Services { get; set; }
    }
}