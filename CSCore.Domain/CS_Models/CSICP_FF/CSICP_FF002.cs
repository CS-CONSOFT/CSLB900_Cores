using CSCore.Domain.CS_Models.Staticas.FF;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF002
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public int? Ff002Tiporegistro { get; set; }

    public int? Ff002Codigo { get; set; }

    public string? Ff002Motivo { get; set; }

    public int? Ff002Peso { get; set; }
}

public class RepoCSICP_FF002 : CSICP_FF002
{
    public OsusrE9aCsicpFf002Mod? NavFF002_Mod { get; set; }
}
