using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg033
{
    public int TenantId { get; set; }

    public string Cg033Id { get; set; } = null!;

    public string? Cg032Id { get; set; }

    public string? Cg033InCtaplanoId { get; set; }

    public int? Cg033Operandoid { get; set; }

    public decimal? Cg033Operador { get; set; }

    //public virtual Osusr8dwCsicpCg032? Cg032 { get; set; }

    //public virtual Osusr8dwCsicpCg006? Cg033InCtaplano { get; set; }
}
