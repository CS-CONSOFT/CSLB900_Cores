using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_RR;

public partial class OsusrTo3CsicpRr031
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Rr031IatfId { get; set; }

    public string? Rr031Animalid { get; set; }

    public DateTime? Rr031Dtregistro { get; set; }

    public bool? Rr031Ispositivo { get; set; }

    public string? Rr031Montaanimalid { get; set; }

    public string? Rr031Semenid { get; set; }

    public OsusrTo3CsicpRr001? NavRR001Animal_RR031 { get; set; }

    public OsusrTo3CsicpRr030? NavRR030Iatf_RR031 { get; set; }

    public OsusrTo3CsicpRr001? NavRR001MontaAnimal_RR031 { get; set; }

    public OsusrTo3CsicpRr035? NavRR035Semen_RR031 { get; set; }
}
