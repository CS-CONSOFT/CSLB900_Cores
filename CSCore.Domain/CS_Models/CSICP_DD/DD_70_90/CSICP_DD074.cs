using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD074
{
    public int TenantId { get; set; }

    public string Dd074Id { get; set; } = null!;

    public string? Dd070Id { get; set; }

    public int? Dd074Tiporegistro { get; set; }

    public string? Dd074DescricaoCompl { get; set; }

    public virtual CSICP_DD070? Dd070 { get; set; }
}
