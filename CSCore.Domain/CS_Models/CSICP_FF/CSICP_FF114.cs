using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF114
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff114Refconfigbanco { get; set; }

    public decimal? Ff114Lote { get; set; }

    public int? Ff114Ordem { get; set; }

    public string? Ff114Linha240 { get; set; }

    public string? Ff114Linha400 { get; set; }

    public string? Ff114Idcontrole { get; set; }

    public virtual CSICP_FF113? Ff114IdcontroleNavigation { get; set; }

    public virtual CSICP_FF112? Ff114RefconfigbancoNavigation { get; set; }
}
