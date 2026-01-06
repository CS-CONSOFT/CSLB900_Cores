using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_SYS.ABAC;

public partial class OsusrE9aCsicpSy036
{
    public int? TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Resourceid { get; set; }

    public string? Actionname { get; set; }

    public virtual OsusrE9aCsicpSy035? Resource { get; set; }
}
