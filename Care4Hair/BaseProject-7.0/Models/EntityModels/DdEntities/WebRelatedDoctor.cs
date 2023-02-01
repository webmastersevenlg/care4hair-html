using System;
using System.Collections.Generic;

namespace BaseProject_7_0.Models.EntityModels.DdEntities;

public partial class WebRelatedDoctor
{
    public int Id { get; set; }

    public string? UrlSection { get; set; }

    public int? ImageId { get; set; }

    public string? FullName { get; set; }

    public bool? HasAdditionalSpecialContent { get; set; }

    public string? Avatar { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<WebPicResult> WebPicResults { get; } = new List<WebPicResult>();
}
