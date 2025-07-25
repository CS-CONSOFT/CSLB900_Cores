using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD115
{
    public int TenantId { get; set; }

    public string Dd115Id { get; set; } = null!;

    public string? Dd110Id { get; set; }

    public int? Dd115Tiporegistro { get; set; }

    public string? Dd115DescricaoCompl { get; set; }

    public virtual CSICP_DD110? Dd110 { get; set; }
}
