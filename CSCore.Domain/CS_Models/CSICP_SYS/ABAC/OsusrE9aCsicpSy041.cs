using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_SYS.ABAC;

public partial class OsusrE9aCsicpSy041
{
    public string Id { get; set; } = null!;

    public string? Operator { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<OsusrE9aCsicpSy042> OsusrE9aCsicpSy042s { get; set; } = new List<OsusrE9aCsicpSy042>();
}
