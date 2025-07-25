using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD093
{
    public int TenantId { get; set; }

    public long Dd093Id { get; set; }

    public long? Dd093Romaneioid { get; set; }

    public string? Dd093Saldoid { get; set; }

    public decimal? Dd093Qvendida { get; set; }

    public decimal? Dd093Qdisponivel { get; set; }

    public decimal? Dd093Qatendida { get; set; }

    public string? Dd093Motivo { get; set; }

    public bool? Dd093Ismarcado { get; set; }

    public virtual CSICP_DD092? Dd093Romaneio { get; set; }
}
