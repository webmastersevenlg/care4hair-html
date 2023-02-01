using System;
using System.Collections.Generic;

namespace BaseProject_7_0.Models.EntityModels.DbEntities;

public partial class WebRelatedProcedure
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? UrlSection { get; set; }

    public int? WebRelatedProcedureCategoryId { get; set; }

    public string? NameSpanish { get; set; }

    public string? UrlSectionSpanish { get; set; }

    public int? RegularPrice { get; set; }

    public virtual WebRelatedProcedureCategory? WebRelatedProcedureCategory { get; set; }

    public virtual ICollection<WebRelatedProceduresRequiredPhotosPerSession> WebRelatedProceduresRequiredPhotosPerSessions { get; } = new List<WebRelatedProceduresRequiredPhotosPerSession>();

    public virtual ICollection<WebSpecial> WebSpecials { get; } = new List<WebSpecial>();
}
