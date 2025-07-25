using CSCore.Domain.CS_Models.CSICP_SYS;

namespace CSCore.Domain;

public partial class Csicp_Sy015
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Sy015Grupoid { get; set; }

    public string? Sy903SubmenuId { get; set; }

    public Csicp_Sy002? Sy015Grupo { get; set; }

    public CsicpSy903Smenu NavSY903SubMenu { get; set; } = null!;
}
