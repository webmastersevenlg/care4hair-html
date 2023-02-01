using System;
using System.Collections.Generic;

namespace BaseProject_7_0.Models.EntityModels.DbEntities;

public partial class WebSpecial
{
    public int Id { get; set; }

    public DateTime? RunFrom { get; set; }

    public DateTime? RunUntil { get; set; }

    public string? NameEn { get; set; }

    public string? Urlen { get; set; }

    public int? ContactFormEn { get; set; }

    public string? SmallImageEn { get; set; }

    public string? LargeImageEn { get; set; }

    public string? DetailEn { get; set; }

    public string? NameEs { get; set; }

    public string? Urles { get; set; }

    public int? ContactFormEs { get; set; }

    public string? SmallImageEs { get; set; }

    public string? LargeImageEs { get; set; }

    public string? DetailEs { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DtCreated { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? DtUpdated { get; set; }

    public decimal? Price { get; set; }

    public string? Includes { get; set; }

    public string? IncludesEs { get; set; }

    public string? SmallImageEncensored { get; set; }

    public string? LargeImageEncensored { get; set; }

    public string? SmallImageEscensored { get; set; }

    public string? LargeImageEscensored { get; set; }

    public decimal? Discount { get; set; }

    public bool? ShowDiscountInsteadPrice { get; set; }

    public bool? ShowPercentInsteadOfNumber { get; set; }

    public virtual WebContactForm? ContactFormEnNavigation { get; set; }

    public virtual WebContactForm? ContactFormEsNavigation { get; set; }

    public virtual ICollection<WebRelatedDoctor> WebRelatedDoctors { get; } = new List<WebRelatedDoctor>();

    public virtual ICollection<WebRelatedProcedure> WebRelatedProcedures { get; } = new List<WebRelatedProcedure>();
}
