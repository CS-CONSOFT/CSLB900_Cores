using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.CSICP_NN;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class Osusr8dwCsicpCg021
{
    public int TenantId { get; set; }

    public string Cg021Id { get; set; } = null!;

    [ForeignKey("NavBB001Estab_CG021")]
    public string? Cg021FilialId { get; set; }

    [ForeignKey("NavCG020Lote_CG021")]
    public string? Cg021LoteId { get; set; }

    public int? Cg021Nrolancamento { get; set; }

    public int? Cg021Seq { get; set; }

    [ForeignKey("NavBB001EstabConsolida_CG021")]
    public string? Cg021ConsolidarFilialId { get; set; }

    public DateTime? Cg021Data { get; set; }

    [ForeignKey("NavCG006ContaContabil_CG021")]
    public string? Cg021ContacontabilId { get; set; }

    [ForeignKey("NavCG993DebCre_CG021")]
    public int? Cg021Debcre { get; set; }

    public string? Cg021Nrodocumento { get; set; }

    public decimal? Cg021Valorlancto { get; set; }

    [ForeignKey("NavCG005Hist_CG021")]
    public string? Cg021HistoricoId { get; set; }

    public string? Cg021Historico { get; set; }

    [ForeignKey("NavCG011ContaGerencialN2_CG021")]
    public string? Cg021CtagerencialN2Id { get; set; }

    [ForeignKey("NavCG012ContaGerencialN3_CG021")]
    public string? Cg021CtagerencialN3Id { get; set; }

    [ForeignKey("NavCG013ContaGerencialN4_CG021")]
    public string? Cg021CtagerencialN4Id { get; set; }

    [ForeignKey("NavCG008TpSaldo_CG021")]
    public string? Cg021TiposaldoId { get; set; }

    [ForeignKey("NavStaticConsolidar_CG021")]
    public int? Cg021Consolidar { get; set; }

    public bool? Cg021Isconsolidado { get; set; }

    public string? Cg021Contacontabil { get; set; }

    public decimal? Cg021Valorlanctoant { get; set; }

    [ForeignKey("NavCG007Projeto_CG021")]
    public string? Cg021ProjetoId { get; set; }

    [ForeignKey("NavNN010_CG021")]
    public string? Nn010Id { get; set; }

    [ForeignKey("NavNN015_CG021")]
    public string? Nn015Id { get; set; }

    [ForeignKey("NavCG070Protocolo_CG021")]
    public long? Cg021Protocolo { get; set; }

    public int? Cg021Sequencia { get; set; }

    public CSICP_BB001? NavBB001Estab_CG021 { get; set; }
    public CSICP_BB001? NavBB001EstabConsolida_CG021 { get; set; }
    public CSICP_CG005? NavCG005Hist_CG021 { get; set; }
    public CSICP_CG006? NavCG006ContaContabil_CG021 { get; set; }
    public Osusr8dwCsicpCg007? NavCG007Projeto_CG021 { get; set; }
    public CSICP_CG008? NavCG008TpSaldo_CG021 { get; set; }
    public csicp_cg993_st? NavCG993DebCre_CG021 { get; set; }
    public Osusr8dwCsicpCg011? NavCG011ContaGerencialN2_CG021 { get; set; }
    public Osusr8dwCsicpCg011? NavCG012ContaGerencialN3_CG021 { get; set; }
    public Osusr8dwCsicpCg011? NavCG013ContaGerencialN4_CG021 { get; set; }
    public CSICP_CG020? NavCG020Lote_CG021 { get; set; }
    public Osusr8dwCsicpCg070? NavCG070Protocolo_CG021 { get; set; }
    public OsusrE9aCsicpNn010? NavNN010_CG021 { get; set; }
    public CSICP_NN015? NavNN015_CG021 { get; set; }
    public CSICP_Statica? NavStaticConsolidar_CG021 { get; set; }

}
