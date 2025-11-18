using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_CG;

public partial class CSICP_CG006 
{
    public int TenantId { get; set; }

    public string Cg006Id { get; set; } = null!;

    [ForeignKey("NavBB001Estab_CG006")]
    public string? Cg006FilialId { get; set; }

    public string? Cg006Codigoplano { get; set; }

    public string? Cg006Descricao { get; set; }

    public string? Cg006Descresumida { get; set; }

    [ForeignKey("NavCG997ClassConta_CG006")]
    public int? Cg006ClassificacaoId { get; set; }

    [ForeignKey("NavCG999TpAmarracao_CG006")]
    public int? Cg006NaturezaId { get; set; }

    [ForeignKey("NavCG996TpConta_CG006")]
    public int? Cg006TipocontaId { get; set; }

    public int? Cg006Grau { get; set; }

    [ForeignKey("NavCG006PlanoContas_ContaSuperior")]
    public string? Cg006CtasuperiorId { get; set; }

    public int? Cg006Codgreduzido { get; set; }

    [ForeignKey("NavCG003GpContabil_CG006")]
    public string? Cg006GrupoId { get; set; }

    [ForeignKey("NavCG005HistPadrao_CG006")]
    public string? Cg006HistoricoId { get; set; }

    public DateTime? Cg006Dtiniexistencia { get; set; }

    [ForeignKey("NavCG004AmarracaoNivel2_CG006")]
    public string? Cg006AmarracaoNivel2 { get; set; }

    [ForeignKey("NavCG004AmarracaoNivel3_CG006")]
    public string? Cg006AmarracaoNivel3 { get; set; }

    [ForeignKey("NavCG004AmarracaoNivel4_CG006")]
    public string? Cg006AmarracaoNivel4 { get; set; }

    public bool? Cg006Isactive { get; set; }

    [ForeignKey("NavStatica_CG006_LancNivel2")]
    public int? Cg006LanctoN2obrig { get; set; }

    [ForeignKey("NavStatica_CG006_LancNivel3")]
    public int? Cg006LanctoN3obrig { get; set; }

    [ForeignKey("NavStatica_CG006_LancNivel4")]
    public int? Cg006LanctoN4obrig { get; set; }

    [ForeignKey("NavStatica_CG006_ConsolidaLanc")]
    public int? Cg006ConsolidaLancto { get; set; }

    public CSICP_BB001? NavBB001Estab_CG006 { get; set; }
    public CSICP_CG003? NavCG003GpContabil_CG006 { get; set; }
    public Osusr8dwCsicpCg004? NavCG004AmarracaoNivel2_CG006 { get; set; }
    public Osusr8dwCsicpCg004? NavCG004AmarracaoNivel3_CG006 { get; set; }
    public Osusr8dwCsicpCg004? NavCG004AmarracaoNivel4_CG006 { get; set; }
    public CSICP_CG005? NavCG005HistPadrao_CG006 { get; set; }
    public CSICP_CG006? NavCG006PlanoContas_ContaSuperior { get; set; }
    public Osusr8dwCsicpCg996? NavCG996TpConta_CG006 { get; set; }
    public Osusr8dwCsicpCg997? NavCG997ClassConta_CG006 { get; set; }
    public Osusr8dwCsicpCg999? NavCG999TpAmarracao_CG006 { get; set; }
    public CSICP_Statica? NavStatica_CG006_LancNivel2 { get; set; }
    public CSICP_Statica? NavStatica_CG006_LancNivel3 { get; set; }
    public CSICP_Statica? NavStatica_CG006_LancNivel4 { get; set; }
    public CSICP_Statica? NavStatica_CG006_ConsolidaLanc { get; set; }

    public static CSICP_CG006 Empty() => new()
    {
        Cg006Id = string.Empty
    };

}
