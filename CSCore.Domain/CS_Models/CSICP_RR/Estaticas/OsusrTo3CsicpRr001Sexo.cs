using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_RR;

public partial class OsusrTo3CsicpRr001Sexo
{
    public int Id { get; set; }

    public string? Label { get; set; }

    public int? Order { get; set; }

    public bool? IsActive { get; set; }

    //public virtual ICollection<OsusrTo3CsicpRr001> OsusrTo3CsicpRr001s { get; set; } = new List<OsusrTo3CsicpRr001>();
}
