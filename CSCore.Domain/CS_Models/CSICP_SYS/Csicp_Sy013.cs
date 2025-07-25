namespace CSCore.Domain;

public partial class Csicp_Sy013
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Sy013Usuarioid { get; set; }

    public string? Sy013Filialid { get; set; }

    public CSICP_BB001? NavCSICP_BB001 { get; set; }
}

