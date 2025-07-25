
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD903Anfe
{
    public int Id { get; set; }

    public string? Label { get; set; }

    public int? Order { get; set; }

    public bool? IsActive { get; set; }

    public string? Parametro { get; set; }

    public virtual ICollection<CSICP_DD000> OsusrTeiCsicpDd000s { get; set; } = new List<CSICP_DD000>();
}
