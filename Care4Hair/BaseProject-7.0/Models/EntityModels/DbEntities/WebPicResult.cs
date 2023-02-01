using System;
using System.Collections.Generic;

namespace BaseProject_7_0.Models.EntityModels.DbEntities;

public partial class WebPicResult
{
    public int WebPicResultId { get; set; }

    public string? PatientId { get; set; }

    public int? StaffId { get; set; }

    public DateTime? DtModified { get; set; }

    public int? ModifiedBy { get; set; }

    public bool? IsActive { get; set; }

    public int? Priority { get; set; }

    public string? Title { get; set; }

    public int? PictureConsent { get; set; }

    public virtual WebRelatedDoctor? Staff { get; set; }
}
