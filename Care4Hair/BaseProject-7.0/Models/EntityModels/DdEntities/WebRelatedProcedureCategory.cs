using System;
using System.Collections.Generic;

namespace BaseProject_7_0.Models.EntityModels.DdEntities;

public partial class WebRelatedProcedureCategory
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? UrlSection { get; set; }

    public virtual ICollection<WebRelatedProcedure> WebRelatedProcedures { get; } = new List<WebRelatedProcedure>();
}
