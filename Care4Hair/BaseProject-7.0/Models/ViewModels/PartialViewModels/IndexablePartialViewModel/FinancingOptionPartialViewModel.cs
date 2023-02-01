using BaseProject_7_0.App_Resources;
using BaseProject_7_0.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class FinancingOptionPartialViewModel : IndexablePartialViewModel
    {
        public FinancingOptionPartialViewModel()
        {
            IndexablePageDetail = new FinancingOptionIndexablePageDetailViewModel();
            ImagesFolderPath = "/content/images/financing_options";
        }
    }
}