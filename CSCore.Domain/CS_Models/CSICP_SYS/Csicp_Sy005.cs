namespace CSCore.Domain.CS_Models.CSICP_SYS;

public partial class Csicp_Sy005
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Sy005Grupoid { get; set; }

    public string? Sy005Userid { get; set; }

    public Csicp_Sy002? Sy005Grupo { get; set; }

    public Csicp_Sy014? Sy014GrupoMenu { get; set; }
}
