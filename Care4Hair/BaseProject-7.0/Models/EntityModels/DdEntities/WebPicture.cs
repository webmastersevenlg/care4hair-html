using System;
using System.Collections.Generic;

namespace BaseProject_7_0.Models.EntityModels.DdEntities;

public partial class WebPicture
{
    public int WebPictureId { get; set; }

    public int? WebPicResultId { get; set; }

    public bool? IsActive { get; set; }

    public int? PicOrder { get; set; }

    public string? Title { get; set; }

    public string? Name { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DtModified { get; set; }
}
