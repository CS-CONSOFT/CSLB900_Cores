using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD075
{
    public int TenantId { get; set; }

    public string Dd075Id { get; set; } = null!;

    public string? Dd070Id { get; set; }

    public int? Dd075Tiporegistro { get; set; }

    public string? Dd075Nomecampo { get; set; }

    public string? Dd075DescricaoCompl { get; set; }

    public virtual CSICP_DD070? Dd070 { get; set; }
}
