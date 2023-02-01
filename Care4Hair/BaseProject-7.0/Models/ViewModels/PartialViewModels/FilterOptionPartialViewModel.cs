using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseProject_7_0.Models.ViewModels
{
    public class FilterOptionPartialViewModel
    {
        public string Caption { get; set; }
        public string Valor { get; set; }
        public string Link { get; set; }
        public int Results { get; set; }
        public FilterOptionPartialViewModel(string caption, string valor, string link, int results)
        {
            Caption = caption;
            Valor = valor;
            Link = link;
            Results = results;
        }
    }
}