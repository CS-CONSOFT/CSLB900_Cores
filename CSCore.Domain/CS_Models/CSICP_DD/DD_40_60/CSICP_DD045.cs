using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD045
{
    public int TenantId { get; set; }

    public string Dd045Id { get; set; } = null!;

    public string? Dd040Id { get; set; }

    public int? Dd045Tiporegistro { get; set; }

    public string? Dd045Nomecampo { get; set; }

    public string? Dd045DescricaoCompl { get; set; }

    public virtual CSICP_DD040? Dd040 { get; set; }
}
