using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_RR;

public partial class OsusrTo3CsicpRr007
{
    public int TenantId { get; set; }

    public long Id { get; set; }

    public string? Rr007Proprietario { get; set; }

    //public virtual ICollection<OsusrTo3CsicpRr001> OsusrTo3CsicpRr001s { get; set; } = new List<OsusrTo3CsicpRr001>();
}
