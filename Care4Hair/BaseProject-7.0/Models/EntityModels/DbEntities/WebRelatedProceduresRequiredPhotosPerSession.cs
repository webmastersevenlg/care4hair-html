using System;
using System.Collections.Generic;

namespace BaseProject_7_0.Models.EntityModels.DbEntities;

public partial class WebRelatedProceduresRequiredPhotosPerSession
{
    public int WebRelatedProcedureId { get; set; }

    public int RequiredPhotosPerSession { get; set; }

    public virtual WebRelatedProcedure WebRelatedProcedure { get; set; } = null!;
}
