using System;
using System.Collections.Generic;

namespace BaseProject_7_0.Models.EntityModels.DdEntities;

public partial class WebBanner
{
    public int Id { get; set; }

    public string? BannerName { get; set; }

    public string? LargeImageEn { get; set; }

    public string? MediumImageEn { get; set; }

    public string? SmallImageEn { get; set; }

    public string? LargeImageEs { get; set; }

    public string? MediumImageEs { get; set; }

    public string? SmallImageEs { get; set; }

    public string? Urlen { get; set; }

    public string? Urles { get; set; }

    public DateTime? RunFrom { get; set; }

    public DateTime? RunUntil { get; set; }

    public bool? IsFullWidth { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DtCreated { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? DtUpdated { get; set; }
}
