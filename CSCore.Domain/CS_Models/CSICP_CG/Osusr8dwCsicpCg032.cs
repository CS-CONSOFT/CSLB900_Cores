using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg032
{
    public int TenantId { get; set; }

    public string Cg032Id { get; set; } = null!;

    public string? Cg031Id { get; set; }

    public string? Cg032Contadre { get; set; }

    public string? Cg032Descricao { get; set; }

    public decimal? Cg032Vinformado { get; set; }

    public int? Cg032Qcaractercodigo { get; set; }
}
