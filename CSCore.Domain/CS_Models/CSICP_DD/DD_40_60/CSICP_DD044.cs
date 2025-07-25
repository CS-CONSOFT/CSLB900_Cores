using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD044
{
    public int TenantId { get; set; }

    public string Dd044Id { get; set; } = null!;

    public string? Dd040Id { get; set; }

    public int? Dd044Tiporegistro { get; set; }

    public string? Dd044DescricaoCompl { get; set; }

    public int? Dd044Filial { get; set; }

    public decimal? Dd044Ci { get; set; }

    public virtual CSICP_DD040? Dd040 { get; set; }
}
