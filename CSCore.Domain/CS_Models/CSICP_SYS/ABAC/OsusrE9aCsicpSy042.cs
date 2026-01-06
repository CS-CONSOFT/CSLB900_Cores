using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_SYS.ABAC;

public partial class OsusrE9aCsicpSy042
{
    public string Id { get; set; } = null!;

    public string? Filterid { get; set; }

    public string? Operatorid { get; set; }

    public virtual OsusrE9aCsicpSy040? Filter { get; set; }

    public virtual OsusrE9aCsicpSy041? Operator { get; set; }
}
