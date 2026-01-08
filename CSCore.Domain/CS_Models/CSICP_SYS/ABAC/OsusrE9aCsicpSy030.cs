using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_SYS.ABAC;

public partial class OsusrE9aCsicpSy030
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Sy030Name { get; set; }

    public string? Sy030Descricao { get; set; }

    public bool? Sy030Isactive { get; set; }
}
