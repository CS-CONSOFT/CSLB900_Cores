using CSCore.Domain.CS_Models.CSICP_CG;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.Staticas.CG;

public partial class Osusr8dwCsicpCg093tmp
{
    public int TenantId { get; set; }

    public long Cg093Id { get; set; }

    public long? Cg093Tempdemcolid { get; set; }

    public string? Cg093Contaid { get; set; }

    public decimal? Cg093Valor { get; set; }

    public virtual Osusr8dwCsicpCg006? Cg093Conta { get; set; }

    public virtual Osusr8dwCsicpCg091tmp? Cg093Tempdemcol { get; set; }
}
