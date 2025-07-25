using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD083
{
    public int TenantId { get; set; }

    public string Dd083Id { get; set; } = null!;

    public string? Dd082Id { get; set; }

    public int? Dd083SequenciaAd { get; set; }

    public decimal? Dd083Nadicao { get; set; }

    public string? Dd083Cfabricante { get; set; }

    public decimal? Dd083Vdescdi { get; set; }

    public string? Dd083Xped { get; set; }

    public int? Dd083Nitemped { get; set; }

    public string? Dd083Ndraw { get; set; }

    public virtual CSICP_DD082? Dd082 { get; set; }
}
