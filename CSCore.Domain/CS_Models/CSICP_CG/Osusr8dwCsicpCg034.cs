using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg034
{
    public int TenantId { get; set; }

    public string Cg034Id { get; set; } = null!;

    public string? Cg032InCtadreId { get; set; }

    public int? Cg034Operandoid { get; set; }

    public decimal? Cg034Operador { get; set; }

    public virtual Osusr8dwCsicpCg032? Cg032InCtadre { get; set; }
}
