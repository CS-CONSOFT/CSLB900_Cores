using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_SYS.ABAC;

public partial class OsusrE9aCsicpSy038
{
    public int? TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? Descripton { get; set; }

    public string? Policyjson { get; set; }

    public int? Priority { get; set; }

    public bool? Isactive { get; set; }

    public ICollection<OsusrE9aCsicpSy039>? NavAbacRules { get; set; } 
}
