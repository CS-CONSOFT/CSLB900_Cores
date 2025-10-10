using System;
using System.Collections.Generic;

namespace CSCore.Domain.DELETAR;

public partial class OsusrTo3CsicpRr008
{
    public int TenantId { get; set; }

    public long Id { get; set; }

    public string? Rr008Regalimentar { get; set; }

    public string? Rr008Descritivo { get; set; }

    public virtual ICollection<OsusrTo3CsicpRr020> OsusrTo3CsicpRr020s { get; set; } = new List<OsusrTo3CsicpRr020>();
}
