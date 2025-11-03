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


    private Osusr8dwCsicpCg009() { }

    public static Osusr8dwCsicpCg009 CreateInstance(
        int tenant,string cg009Id, string? cg009FilialId, string? cg009TipoSaldoId, string? cg009ContaId, int cg009Ano, int cg009Mes, decimal? cg009Totaldebito, decimal? cg009Totalcredito, decimal? cg009Saldo)
    {
        return new Osusr8dwCsicpCg009
        {
            TenantId = tenant,
            Cg009Id = cg009Id,
            Cg009FilialId = cg009FilialId,
            Cg009TipoSaldoId = cg009TipoSaldoId,
            Cg009ContaId = cg009ContaId,
            Cg009Ano = cg009Ano,
            Cg009Mes = cg009Mes,
            Cg009Totaldebito = cg009Totaldebito,
            Cg009Totalcredito = cg009Totalcredito,
            Cg009Saldo = cg009Saldo,
        };
    }

    public static Osusr8dwCsicpCg009 CreateInstance(
        int tenant, string cg009Id, string? cg009FilialId, string? cg009TipoSaldoId, string? cg009ContaId, int cg009Ano, int cg009Mes)
    {
        return new Osusr8dwCsicpCg009
        {
            TenantId = tenant,
            Cg009Id = cg009Id,
            Cg009FilialId = cg009FilialId,
            Cg009TipoSaldoId = cg009TipoSaldoId,
            Cg009ContaId = cg009ContaId,
            Cg009Ano = cg009Ano,
            Cg009Mes = cg009Mes
        };
    }



    public static Osusr8dwCsicpCg009 FakeGet()
    {
        return new Osusr8dwCsicpCg009
        {
            
        };
    }
}
