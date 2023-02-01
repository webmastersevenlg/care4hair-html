using BaseProject_7_0.Models.BaseModels;
using BaseProject_7_0.Models.EntityModels.XmlEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models.EntityModels.XmlEntities
{
    public class PatientResultEntity : BaseXmlEntityModel
    {
        public ProfessionalEntity Profesinal { get; set; }
        public ICollection<ServiceEntity> Services { get; set; }
        public ICollection<PictureEntity> Pictures { get; set; }
        public int Priority { get; set; }
        public string Xml { get; set; }
        public static string XmlFilePath = "~/app_data/patientresultentities.xml";

    }
}