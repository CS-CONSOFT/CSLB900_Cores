namespace CSCore.Domain.CS_Models.CSICP_SYS;

public partial class Csicp_Sy014
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Sy014Grupoid { get; set; }

    public string? Sy902MenuId { get; set; }

    public Csicp_Sy002? Sy014Grupo { get; set; }

    public CsicpSy902Menu CsicpSy902Menu { get; set; } = null!;
}
