using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_RR;

public partial class OsusrTo3CsicpRr009
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    [ForeignKey("NavRR001Animal_RR009")]
    public string? Rr001Id { get; set; } = null!;

    [ForeignKey("NavRR001AnimalVirtual_RR009")]
    public string? Rr001Virtualid { get; set; } = null!;

    // Navegações
    public OsusrTo3CsicpRr001? NavRR001Animal_RR009 { get; set; }
    
    public OsusrTo3CsicpRr001? NavRR001AnimalVirtual_RR009 { get; set; }
}
