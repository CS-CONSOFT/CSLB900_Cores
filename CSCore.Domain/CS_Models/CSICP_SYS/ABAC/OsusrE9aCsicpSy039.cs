using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_SYS.ABAC;

public partial class OsusrE9aCsicpSy039
{
    public int? TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Policyid { get; set; }

    public string? Rulename { get; set; }

    public string? Effect { get; set; }

    public int? Priority { get; set; }

    public string? Conditions { get; set; }

    public string? Actions { get; set; }

    public string? Resources { get; set; }

    public virtual OsusrE9aCsicpSy038? Policy { get; set; }
}
