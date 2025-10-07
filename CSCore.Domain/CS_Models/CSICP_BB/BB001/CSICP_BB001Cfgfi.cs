
using CSCore.Domain;

public record DtoCreateUpdateBB001CfgFi(
int? Bb001TptributacaoId,
decimal? Bb001PercIcms,
decimal? Bb001PercCsllBc,
decimal? Bb001PercCsllBcServico,
decimal? Bb001PercIrpjBc,
decimal? Bb001PercIrpjBcServico,
int? Bb001NaturezapjId,
int? Bb001TpatividadeId,
int? Bb001Regimetributarioid)
{
    public CSICP_BB001Cfgfi ToEntity(int tenantID, string emrpesaID, string confgID)
    {
        return new CSICP_BB001Cfgfi
        {
            TenantId = tenantID,
            Bb001CfgId = confgID,
            Bb001EmpresaId = emrpesaID,
            Bb001TptributacaoId = Bb001TptributacaoId,
            Bb001PercIcms = Bb001PercIcms,
            Bb001PercCsllBc = Bb001PercCsllBc,
            Bb001PercCsllBcServico = Bb001PercCsllBcServico,
            Bb001PercIrpjBc = Bb001PercIrpjBc,
            Bb001PercIrpjBcServico = Bb001PercIrpjBcServico,
            Bb001NaturezapjId = Bb001NaturezapjId,
            Bb001TpatividadeId = Bb001TpatividadeId,
            Bb001Regimetributarioid = Bb001Regimetributarioid
        };
    }
};


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

    public CSICP_BB001Natpj? Bb001Naturezapj { get; set; }

    public CSICP_AA030Regime? Bb001Regimetributario { get; set; }

    public CSICP_BB001_ATPJS? Bb001Tpatividade { get; set; }

    public CSICP_BB001TpTri? Bb001Tptributacao { get; set; }

}
