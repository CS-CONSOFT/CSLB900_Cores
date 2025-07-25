using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD063
{
    public int TenantId { get; set; }

    public string Dd063Id { get; set; } = null!;

    public string? Dd062Id { get; set; }

    public int? Dd063SequenciaAd { get; set; }

    public decimal? Dd063Nadicao { get; set; }

    public string? Dd063Cfabricante { get; set; }

    public decimal? Dd063Vdescdi { get; set; }

    public string? Dd063Xped { get; set; }

    public int? Dd063Nitemped { get; set; }

    public string? Dd063Ndraw { get; set; }

    public virtual CSICP_DD062? Dd062 { get; set; }
}
