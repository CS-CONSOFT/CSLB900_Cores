using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD156
{
    public int TenantId { get; set; }

    public string Dd156Id { get; set; } = null!;

    public string? Gg008Produtoid { get; set; }

    public int? Dd156Regramontgid { get; set; }

    public decimal? Dd156Vunitmontagem { get; set; }

    public decimal? Dd156Psobrefaturliq { get; set; }

    public int? Dd156Tempoestimado { get; set; }

    public int? Dd156Qmontador { get; set; }

    public bool? Dd156Isautomatico { get; set; }

    public virtual CSICP_DD156Rg? Dd156Regramontg { get; set; }
}
