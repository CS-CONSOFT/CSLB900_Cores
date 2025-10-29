using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg005
{
    public int TenantId { get; set; }

    public string Cg005Id { get; set; } = null!;

    public string? Cg005FilialId { get; set; }

    public int? Cg005Codigo { get; set; }

    public string? Cg005Historicoresumido { get; set; }

    public string? Cg005Historico { get; set; }

    public bool? Cg005Isactive { get; set; }
}
