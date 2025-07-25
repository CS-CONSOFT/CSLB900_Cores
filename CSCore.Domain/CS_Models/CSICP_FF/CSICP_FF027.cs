using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF027
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff024Id { get; set; }

    public string? Ff027Contaid { get; set; }

    public decimal? Ff027TotalTitulospagos { get; set; }

    public int? Ff027QtdCupons { get; set; }

    public decimal? Ff027Saldo { get; set; }

    public virtual CSICP_FF024? Ff024 { get; set; }
}
