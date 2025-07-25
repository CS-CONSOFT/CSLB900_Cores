namespace CSCore.Domain;

public partial class Csicp_Sy011
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Sy011Userid { get; set; }

    public string? Sy903SubmenuId { get; set; }

    public Csicp_Sy001? Sy011User { get; set; }
}
