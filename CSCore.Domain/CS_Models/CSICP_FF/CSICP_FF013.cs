using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF013
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff013Filialid { get; set; }

    public string? Ff013Grupocobrancaid { get; set; }

    public string? Ff013Cobradorid { get; set; }

    public string? Ff013Zonaid { get; set; }

    public string? Ff013Contaid { get; set; }

    public int? Ff013Tpregistro { get; set; }

    public virtual CSICP_FF012? Ff013Grupocobranca { get; set; }
}
