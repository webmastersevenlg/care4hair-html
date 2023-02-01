using System;
using System.Collections.Generic;

namespace BaseProject_7_0.Models.EntityModels.DdEntities;

public partial class ActiveWebSpecialsGroupedWithJoin
{
    public int EntityId { get; set; }

    public string? WebRelatedDoctors { get; set; }

    public string? WebRelatedProcedures { get; set; }

    public string? WebRelatedProcedureCategories { get; set; }
}
