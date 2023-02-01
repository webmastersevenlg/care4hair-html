using System;
using System.Collections.Generic;

namespace BaseProject_7_0.Models.EntityModels.DbEntities;

public partial class ActiveWebPicture
{
    public int WebPictureId { get; set; }

    public int? Priority { get; set; }

    public string? Title { get; set; }

    public string? ServiceName { get; set; }

    public string? ServiceUrl { get; set; }

    public string? ProfessionalUrl { get; set; }

    public string? ProfessionalName { get; set; }

    public string? PictureTitle { get; set; }

    public string? PictureFileName { get; set; }

    public int? PictureOrder { get; set; }

    public int? WebPicResultId { get; set; }

    public string? PatientId { get; set; }

    public string? ProfessionalImageName { get; set; }
}
