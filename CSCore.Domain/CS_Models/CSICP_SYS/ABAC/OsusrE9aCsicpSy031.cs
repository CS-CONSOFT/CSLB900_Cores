using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_SYS.ABAC;

public partial class OsusrE9aCsicpSy031
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Sy031Usuarioid { get; set; }

    [ForeignKey("NavGrupo_SY030")]
    public string? Sy031Grupoid { get; set; }

    public bool? Sy031Isactive { get; set; }

    public OsusrE9aCsicpSy030? NavGrupo_SY030 { get; set; }
}
