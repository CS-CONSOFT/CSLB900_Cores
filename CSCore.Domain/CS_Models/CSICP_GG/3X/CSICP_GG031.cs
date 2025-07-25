using CSCore.Domain.CS_Models.Staticas.GG;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG031
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Gg031Filialid { get; set; }

    public string? Gg030Id { get; set; }

    public string? Gg031KardexId { get; set; }

    public int? Gg031Produto { get; set; }

    public string? Gg031Produtoid { get; set; }

    public decimal? Gg031Codigobarra { get; set; }

    public DateTime? Gg031DataReferente { get; set; }

    public decimal? Gg031PercAjuste { get; set; }

    public decimal? Gg031PrcAnterior { get; set; }

    public decimal? Gg031PrcMovimento { get; set; }

    public decimal? Gg031PrcCalculado { get; set; }

    public int? Gg031PrecoajusteId { get; set; }

    public string? Gg031Codbarrasalfa { get; set; }
}

public partial class RepoDto_CSICP_GG031 : CSICP_GG031
{
    public CSICP_BB001? Nav_BB001 { get; set; }
    public CSICP_GG030? Nav_GG030 { get; set; }
    public CSICP_GG008Kdx? Nav_GG008_Kdx { get; set; }
    public CSICP_GG008? Nav_GG008 { get; set; }
    public CSICP_GG023Val? Nav_GG023_Val { get; set; }
}
