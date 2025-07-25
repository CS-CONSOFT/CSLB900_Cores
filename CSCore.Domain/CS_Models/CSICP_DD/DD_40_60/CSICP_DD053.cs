using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD053
{
    public int TenantId { get; set; }

    public long Dd053Id { get; set; }

    public string? Bb001Id { get; set; }

    public string? Dd040Id { get; set; }

    public string? Dd053Chavenfce { get; set; }

    public string? Dd053Serie { get; set; }

    public int? Dd053NoNf { get; set; }

    public string? Aa013Id { get; set; }

    public string? Dd053Digival { get; set; }

    public string? Dd053Urlqrcode { get; set; }

    public DateTime? Dd053Dh { get; set; }

    public int? Dd040SitNfeId { get; set; }

    public string? Dd040NotageradaId { get; set; }

    public virtual CSICP_DD040? Dd040 { get; set; }

    public virtual CSICP_DD040? Dd040Notagerada { get; set; }

    public virtual CSICP_DD040Nfe? Dd040SitNfe { get; set; }
}
