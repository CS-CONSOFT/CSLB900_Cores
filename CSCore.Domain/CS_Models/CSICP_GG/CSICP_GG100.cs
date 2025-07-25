namespace CSCore.Domain.CS_Models.CSICP_GG;

public partial class CSICP_GG100
{
    public int TenantId { get; set; }

    public long Gg100Id { get; set; }

    public string? Gg100Estabid { get; set; }

    public string? Gg100PdvendaAlmoxid { get; set; }

    public string? Gg100Pdtransfalmoxid2 { get; set; }

    public string? Gg100Pdtipoprodutoid { get; set; }

    public bool? Gg100Iscopia { get; set; }

    public string? Gg100AwsBucket { get; set; }

    public string? Gg100Awsregion { get; set; }

    public string? Gg100Awsaccesskeyid { get; set; }

    public string? Gg100Awssecretaccesskey { get; set; }

    public CSICP_GG002? Gg100Pdtipoproduto { get; set; }

    public CSICP_GG001? Gg100Pdtransfalmoxid2Navigation { get; set; }

    public CSICP_GG001? Gg100PdvendaAlmox { get; set; }
}
