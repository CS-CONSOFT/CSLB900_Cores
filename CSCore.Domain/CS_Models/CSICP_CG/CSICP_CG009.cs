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

    public CSICP_BB001? NavBB001Estab_CG009 { get; set; }
    public CSICP_CG006? NavCG006Conta_CG009 { get; set; }
    public Osusr8dwCsicpCg008? NavCG008TipoSaldo_CG009 { get; set; }

    }
