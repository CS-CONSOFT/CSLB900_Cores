using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class OsusrE9aCsicpGg992
{
    public int TenantId { get; set; }

    public string Gg992Id { get; set; } = null!;

    public string? Gg992OrganogramaId { get; set; }

    public string? Gg992AlmoxId { get; set; }

    public CSICP_GG001? Gg992Almox { get; set; }

    public OsusrE9aCsicpGg991? Gg992Organograma { get; set; }
}
