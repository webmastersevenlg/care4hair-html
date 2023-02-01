using System;
using System.Collections.Generic;

namespace BaseProject_7_0.Models.EntityModels.DbEntities;

public partial class ActiveWebSpecialsWithJoin
{
    public int WebSpecialId { get; set; }

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

    public int? WebContactFormId { get; set; }

    public string? WebScontactFormName { get; set; }

    public string? UrlSection { get; set; }

    public string? Name { get; set; }

    public string? Expr1 { get; set; }

    public string? FullName { get; set; }

    public int? ImageId { get; set; }

    public string? Expr2 { get; set; }

    public string? Expr3 { get; set; }
}
