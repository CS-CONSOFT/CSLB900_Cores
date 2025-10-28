using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg013
{
    public int TenantId { get; set; }

    public string Cg013Id { get; set; } = null!;

    public string? Cg013FilialId { get; set; }

    public string? Cg013TipoSaldoId { get; set; }

    public string? Cg013ContagerencialId { get; set; }

    public int? Cg013Ano { get; set; }

    public DateTime? Cg013Dia { get; set; }

    public decimal? Cg013Totaldebito { get; set; }

    public decimal? Cg013Totalcredito { get; set; }

    public decimal? Cg013Saldo { get; set; }

    public virtual Osusr8dwCsicpCg011? Cg013Contagerencial { get; set; }

    public virtual Osusr8dwCsicpCg008? Cg013TipoSaldo { get; set; }
}
