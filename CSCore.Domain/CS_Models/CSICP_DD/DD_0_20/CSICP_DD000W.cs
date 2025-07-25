namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD000W
{
    public int TenantId { get; set; }

    public string Dd000Id { get; set; } = null!;

    public string? Dd000ConfigId { get; set; }

    public int? Dd000NfcfId { get; set; }

    public int? Dd000ServnfeId { get; set; }

    public string? Dd000Url { get; set; }

    public bool? Dd000Isactive { get; set; }

    public string? Dd000UrlHomologacao { get; set; }

    public string? Dd000UfOrgaoId { get; set; }

    public virtual CSICP_DD000? Dd000Config { get; set; }

    public virtual CSICP_DD999Nfcf? Dd000Nfcf { get; set; }

    public virtual CSICP_DD904Snfe? Dd000Servnfe { get; set; }
}
