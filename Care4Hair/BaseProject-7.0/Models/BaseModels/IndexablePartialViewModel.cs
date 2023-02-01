using BaseProject_7_0.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.BaseModels
{
    public class IndexablePartialViewModel : BasePartialViewModel
    {
        public IndexablePageDetailViewModel IndexablePageDetail { get; set; }
        public string IndexablePartialViewsFolderPath = "~/Views/BaseIndex/Partials/IndexableElements/";
        public Nullable<int> Priority { get; set; }
        public string Title { get; set; }
        
        public string GetElementClassName
        {
            get
            {
                return this.GetType().Name;
            }
        }        

        public string GetElementPartialViewName
        {
            get
            {
                return IndexablePartialViewsFolderPath + GetElementClassName.Replace("Model", "") + "/pc.cshtml";
            }
        }
    }
}