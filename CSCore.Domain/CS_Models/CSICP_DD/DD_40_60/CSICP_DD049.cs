using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD049
{
    public int TenantId { get; set; }

    public string Dd049Id { get; set; } = null!;

    public string? Dd040Id { get; set; }

    public int? Dd049Filial { get; set; }

    public decimal? Dd049Ci { get; set; }

    public string? Dd049SerieEquip { get; set; }

    public int? Dd049NumeroEcf { get; set; }

    public int? Dd049NumeroCoo { get; set; }

    public string? Dd049ModDocFiscal { get; set; }

    public DateTime? Dd049DtEmisDocto { get; set; }

    public virtual CSICP_DD040? Dd040 { get; set; }
}
