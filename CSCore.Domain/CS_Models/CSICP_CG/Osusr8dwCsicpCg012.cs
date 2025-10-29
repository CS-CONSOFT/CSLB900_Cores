using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg012
{
    public int TenantId { get; set; }

    public string Cg012Id { get; set; } = null!;

    public string? Cg012FilialId { get; set; }

    public string? Cg012TipoSaldoId { get; set; }

    public string? Cg012ContagerencialId { get; set; }

    public int? Cg012Ano { get; set; }

    public int? Cg012Mes { get; set; }

    public decimal? Cg012Totaldebito { get; set; }

    public decimal? Cg012Totalcredito { get; set; }

    public decimal? Cg012Saldo { get; set; }
}
