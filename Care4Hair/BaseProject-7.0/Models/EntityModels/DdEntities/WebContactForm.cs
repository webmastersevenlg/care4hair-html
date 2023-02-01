using System;
using System.Collections.Generic;

namespace BaseProject_7_0.Models.EntityModels.DdEntities;

public partial class WebContactForm
{
    public int WebContactFormId { get; set; }

    public string? WebScontactFormName { get; set; }

    public virtual ICollection<WebSpecial> WebSpecialContactFormEnNavigations { get; } = new List<WebSpecial>();

    public virtual ICollection<WebSpecial> WebSpecialContactFormEsNavigations { get; } = new List<WebSpecial>();
}
