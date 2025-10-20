using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSCore.Domain.CS_Models.CSICP_RR;

public partial class OsusrTo3CsicpRr021
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    [ForeignKey("NavRR020RegLote_RR021")]
    public string? Rr021Loteid { get; set; }

    [ForeignKey("NavRR001Animal_RR021")]
    public string? Rr021Animalid { get; set; }

    public DateTime? Rr021Dtregistro { get; set; }

    //public virtual ICollection<OsusrTo3CsicpRr022> OsusrTo3CsicpRr022s { get; set; } = new List<OsusrTo3CsicpRr022>();

    public OsusrTo3CsicpRr001? NavRR001Animal_RR021 { get; set; }

    public OsusrTo3CsicpRr020? NavRR020RegLote_RR021 { get; set; }
}
