using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class CSICP_CG009
{
    public int TenantId { get; set; }

    public string Cg009Id { get; set; } = null!;

    [ForeignKey("NavBB001Estab_CG009")]
    public string? Cg009FilialId { get; set; }

    [ForeignKey("NavCG008TipoSaldo_CG009")]
    public string? Cg009TipoSaldoId { get; set; }

    [ForeignKey("NavCG006Conta_CG009")]
    public string? Cg009ContaId { get; set; }

    public int? Cg009Ano { get; set; }

    public int? Cg009Mes { get; set; }

    public decimal? Cg009Totaldebito { get; set; }

    public decimal? Cg009Totalcredito { get; set; }

    public decimal? Cg009Saldo { get; set; }


    private CSICP_CG009() { }
    
    public static CSICP_CG009 CreateInstance(
        int tenant,string cg009Id, string? cg009FilialId, string? cg009TipoSaldoId, string? cg009ContaId, int cg009Ano, int cg009Mes, decimal? cg009Totaldebito, decimal? cg009Totalcredito, decimal? cg009Saldo)
    {
        return new CSICP_CG009
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

    public static CSICP_CG009 CreateInstance(
        int tenant, string cg009Id, string? cg009FilialId, string? cg009TipoSaldoId, string? cg009ContaId, int cg009Ano, int cg009Mes)
    {
        return new CSICP_CG009
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



    public static CSICP_CG009 FakeGet()
    {
        return new CSICP_CG009
        {
            
        };
    }

    public CSICP_BB001? NavBB001Estab_CG009 { get; set; }
    public CSICP_CG006? NavCG006Conta_CG009 { get; set; }
    public Osusr8dwCsicpCg008? NavCG008TipoSaldo_CG009 { get; set; }

    }
