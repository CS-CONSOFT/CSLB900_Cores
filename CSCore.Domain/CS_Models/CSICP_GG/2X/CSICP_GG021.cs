using CSCore.Domain.CS_Models.Staticas.GG;

namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG021
{
    public int TenantId { get; set; } = default;

    public string Id { get; set; } = null!;

    public decimal? Gg021Ncm { get; set; } = default;

    public string? Gg021ExNcm { get; set; } = default;

    public string? Gg021Descricao { get; set; } = default;

    public string? Gg021Unidade { get; set; } = default;

    public string? Gg021Unid { get; set; } = default;

    public decimal? Gg021PercIpi { get; set; } = default;

    public decimal? Gg021PercIcms { get; set; } = default;

    public string? Gg021Tipi { get; set; } = default;

    public string? Gg021ExNbm { get; set; } = default;

    public bool? Gg021IsActive { get; set; } = default;

    public string? Gg021NcmGenero { get; set; } = default;

    public int? Gg021Mp255Id { get; set; } = default;

    public int? Gg021GeneroId { get; set; } = default;

    public string? Gg021CnaeId { get; set; } = default;

    public int? Gg021IsinalanteId { get; set; } = default;

    public int? Gg021CestId { get; set; } = default;

    public string? Gg021CestN2 { get; set; } = default;

    public string? Gg021CestN3 { get; set; } = default;

    public decimal? Gg021PercCsll { get; set; } = default;

    public decimal? Gg021PercCofins { get; set; } = default;

    public decimal? Gg021PercPis { get; set; } = default;

    public decimal? Gg021IcmsPauta { get; set; } = default;

    public decimal? Gg021IpiPauta { get; set; } = default;

    public decimal? Gg021AliquotaIrpj { get; set; } = default;

    public int? Gg021Ierelevanteid { get; set; } = default;

    public DateTime? Gg021Dtiniciovigencia { get; set; } = default;

    public DateTime? Gg021Dtfimvigencia { get; set; } = default;

    public OsusrE9aCsicpGg021cest? NavGg021Cest { get; set; } = default;
    public OsusrNnxSpedInGenItem? NavSpedGenero { get; set; } = default;

    public CSICP_GG007? NavGg007Un { get; set; } = default;

}
