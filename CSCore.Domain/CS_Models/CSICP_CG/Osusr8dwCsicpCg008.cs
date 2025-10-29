using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg008
{
    public int TenantId { get; set; }

    public string Cg008Id { get; set; } = null!;

    public int? Cg008Cod { get; set; }

    public string? Cg008Descricao { get; set; }

    public string? Cg008Descresumida { get; set; }

    public bool? Cg008Isactive { get; set; }
}
