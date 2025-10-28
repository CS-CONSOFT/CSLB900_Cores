using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg010
{
    public int TenantId { get; set; }

    public string Cg010Id { get; set; } = null!;

    public string? Cg010FilialId { get; set; }

    public string? Cg010TipoSaldoId { get; set; }

    public string? Cg010ContaId { get; set; }

    public int? Cg010Ano { get; set; }

    public DateTime? Cg010Dia { get; set; }

    public decimal? Cg010Totaldebito { get; set; }

    public decimal? Cg010Totalcredito { get; set; }

    public decimal? Cg010Saldo { get; set; }

    public virtual Osusr8dwCsicpCg006? Cg010Conta { get; set; }

    public virtual Osusr8dwCsicpCg008? Cg010TipoSaldo { get; set; }
}
