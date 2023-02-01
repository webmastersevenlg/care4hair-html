using System;
using System.Collections.Generic;

namespace BaseProject_7_0.Models.EntityModels.DdEntities;

public partial class WebSpecialsGroupedWithJoin
{
    public int EntityId { get; set; }

    public string? WebRelatedDoctor { get; set; }

    public string? WebRelatedProcedure { get; set; }

    public string? WebRelatedProcedureCategory { get; set; }
}
