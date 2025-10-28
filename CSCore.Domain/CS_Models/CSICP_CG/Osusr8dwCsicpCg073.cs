using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg073
{
    public int TenantId { get; set; }

    public long Cg073Id { get; set; }

    public long? Cg073Contlancinter { get; set; }

    public long? Cg073Contparametro { get; set; }

    public string? Cg073Conteventopartp { get; set; }

    public virtual Osusr8dwCsicpCg071? Cg073ContlancinterNavigation { get; set; }

    public virtual Osusr8dwCsicpCg052? Cg073ContparametroNavigation { get; set; }
}
