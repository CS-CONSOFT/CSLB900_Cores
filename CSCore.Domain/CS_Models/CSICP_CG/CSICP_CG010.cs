using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class CSICP_CG010 
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

    public static CSICP_CG010 CreateInstance(
    int tenant, string id, string? Cg010FilialId, string? Cg010TipoSaldoId, string? Cg010ContaId, int Cg010Ano, DateTime? Dia)
    {
        return new CSICP_CG010
        {
            TenantId = tenant,
            Cg010Id = id,
            Cg010FilialId = Cg010FilialId,
            Cg010TipoSaldoId = Cg010TipoSaldoId,
            Cg010ContaId = Cg010ContaId,
            Cg010Ano = Cg010Ano,
            Cg010Dia = Dia
        };
    }

}
