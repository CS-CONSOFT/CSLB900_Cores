using CSCore.Domain.CS_Models.CSICP_SYS;

namespace CSCore.Domain;

public partial class Csicp_Sy009
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Sy009Grupoid { get; set; }

    public string? Sy904ProgramaId { get; set; }

    public Csicp_Sy002? Sy009Grupo { get; set; }
    public CsicpSy904Prg NavSY904Prg { get; set; } = null!;

}
