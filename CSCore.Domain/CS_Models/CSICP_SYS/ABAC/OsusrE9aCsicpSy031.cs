using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_SYS.ABAC;

public partial class OsusrE9aCsicpSy031
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Sy031Usuarioid { get; set; }

    public string? Sy031Grupoid { get; set; }

    public bool? Sy031Isactive { get; set; }

    public virtual OsusrE9aCsicpSy030? Sy031Grupo { get; set; }
}
