using BaseProject_7_0.Models.BaseModels;
using System;


namespace BaseProject_7_0.Models.EntityModels.XmlEntities
{
    public class PictureEntity : BaseXmlEntityModel
    {
        public string Title { get; set; }
        public string Src { get; set; }
        public static string XmlFilePath ="false"; 
    }
}