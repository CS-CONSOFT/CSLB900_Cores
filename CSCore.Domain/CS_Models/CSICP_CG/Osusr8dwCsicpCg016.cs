using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg016
{
    public int TenantId { get; set; }

    public string Cg016Id { get; set; } = null!;

    public string? Cg016RateioId { get; set; }

    public string? Cg016Seq { get; set; }

    public int? Cg016DebcreId { get; set; }

    public string? Cg016ContaId { get; set; }

    public decimal? Cg016Valor { get; set; }

    public string? Cg016HistoricoId { get; set; }

    public string? Cg016ContagerN2 { get; set; }

    public string? Cg016ContagerN3 { get; set; }

    public string? Cg016ContagerN4 { get; set; }

    public virtual Osusr8dwCsicpCg006? Cg016Conta { get; set; }

    public virtual Osusr8dwCsicpCg011? Cg016ContagerN2Navigation { get; set; }

    public virtual Osusr8dwCsicpCg011? Cg016ContagerN3Navigation { get; set; }

    public virtual Osusr8dwCsicpCg011? Cg016ContagerN4Navigation { get; set; }

    public virtual Osusr8dwCsicpCg993? Cg016Debcre { get; set; }

    public virtual Osusr8dwCsicpCg005? Cg016Historico { get; set; }

    public virtual Osusr8dwCsicpCg015? Cg016Rateio { get; set; }
}
