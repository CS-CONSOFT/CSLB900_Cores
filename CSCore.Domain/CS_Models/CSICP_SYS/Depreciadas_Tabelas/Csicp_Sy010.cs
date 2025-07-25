namespace CSCore.Domain;

public partial class Csicp_Sy010
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Sy010Userid { get; set; }

    public string? Sy902MenuId { get; set; }

    public Csicp_Sy001? Sy010User { get; set; }
}
