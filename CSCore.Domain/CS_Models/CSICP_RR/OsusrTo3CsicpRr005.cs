using System;
using System.Collections.Generic;

namespace CSCore.Domain.DELETAR;

public partial class OsusrTo3CsicpRr005
{
    public int TenantId { get; set; }

    public long Id { get; set; }

    public string? Rr005Situacao { get; set; }

    public virtual ICollection<OsusrTo3CsicpRr001> OsusrTo3CsicpRr001s { get; set; } = new List<OsusrTo3CsicpRr001>();
}
