using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class CSICP_CG020
{
    public int TenantId { get; set; }

    public string Cg020Id { get; set; } = null!;

    [ForeignKey("NavBB001Estab_CG020")]
    public string? Cg020FilialId { get; set; }

    public int? Cg020Ano { get; set; }

    public int? Cg020Mes { get; set; }

    public int? Cg020Lote { get; set; }

    public DateTime? Cg020Datainicio { get; set; }

    public DateTime? Cg020Datafinal { get; set; }

    public int? Cg020Ultlancto { get; set; }

    public int? Cg020Qtdlanctos { get; set; }

    public decimal? Cg020Totaldebito { get; set; }

    public decimal? Cg020Totalcredito { get; set; }

    public decimal? Cg020Difdebcre { get; set; }

    public decimal? Cg020Gtdebcre { get; set; }

    [ForeignKey("NavCG008TpSaldo_CG020")]
    public string? Cg020TiposaldoId { get; set; }

    [ForeignKey("NavCG992Situacao_CG020")]
    public int? Cg020SituacaoloteId { get; set; }

    [ForeignKey("NavBB001ConsoEstab_CG020")]
    public string? Cg020ConsolidadoFilialId { get; set; }

    public int? Cg020UltSeq { get; set; }

    public CSICP_BB001? NavBB001Estab_CG020 { get; set; }

    public CSICP_BB001? NavBB001ConsoEstab_CG020 { get; set; }

    public CSICP_CG008? NavCG008TpSaldo_CG020 { get; set; }

    public Osusr8dwCsicpCg992? NavCG992Situacao_CG020 { get; set; }
}
