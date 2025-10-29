using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg009
{
    public int TenantId { get; set; }

    public string Cg009Id { get; set; } = null!;

    public string? Cg009FilialId { get; set; }

    public string? Cg009TipoSaldoId { get; set; }

    public string? Cg009ContaId { get; set; }

    public int? Cg009Ano { get; set; }

    public int? Cg009Mes { get; set; }

    public decimal? Cg009Totaldebito { get; set; }

    public decimal? Cg009Totalcredito { get; set; }

    public decimal? Cg009Saldo { get; set; }
}
