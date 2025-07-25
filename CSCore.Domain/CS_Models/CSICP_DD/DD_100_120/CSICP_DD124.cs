using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD124
{
    public int TenantId { get; set; }

    public string Dd124Id { get; set; } = null!;

    public string? Dd123MovtoNdId { get; set; }

    public string? Dd120TrocaId { get; set; }

    public virtual CSICP_DD120? Dd120Troca { get; set; }

    public virtual CSICP_DD123? Dd123MovtoNd { get; set; }
}
