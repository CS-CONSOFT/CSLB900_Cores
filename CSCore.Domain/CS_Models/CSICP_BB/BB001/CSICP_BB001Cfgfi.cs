
using CSCore.Domain;



public partial class CSICP_BB001Cfgfi
{
    public int TenantId { get; set; }

    public string Bb001CfgId { get; set; } = null!;

    public string? Bb001EmpresaId { get; set; }

    public int? Bb001TptributacaoId { get; set; }

    public decimal? Bb001PercIcms { get; set; }

    public decimal? Bb001PercCsllBc { get; set; }

    public decimal? Bb001PercCsllBcServico { get; set; }

    public decimal? Bb001PercIrpjBc { get; set; }

    public decimal? Bb001PercIrpjBcServico { get; set; }

    public int? Bb001NaturezapjId { get; set; }

    public int? Bb001TpatividadeId { get; set; }

    public int? Bb001Regimetributarioid { get; set; }

    // public  CSICP_BB001? Bb001Empresa { get; set; }

    public CSICP_BB001Natpj? Bb001Naturezapj { get; set; }

    public CSICP_AA030Regime? Bb001Regimetributario { get; set; }

    public CSICP_BB001_ATPJS? Bb001Tpatividade { get; set; }

    public CSICP_BB001TpTri? Bb001Tptributacao { get; set; }
}
