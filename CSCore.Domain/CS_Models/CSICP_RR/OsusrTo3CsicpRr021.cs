using System;
using System.Collections.Generic;

namespace CSCore.Domain.DELETAR;

public partial class OsusrTo3CsicpRr021
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Rr021Loteid { get; set; }

    public string? Rr021Animalid { get; set; }

    public DateTime? Rr021Dtregistro { get; set; }

    public virtual ICollection<OsusrTo3CsicpRr022> OsusrTo3CsicpRr022s { get; set; } = new List<OsusrTo3CsicpRr022>();

    public virtual OsusrTo3CsicpRr001? Rr021Animal { get; set; }

    public virtual OsusrTo3CsicpRr020? Rr021Lote { get; set; }
}
