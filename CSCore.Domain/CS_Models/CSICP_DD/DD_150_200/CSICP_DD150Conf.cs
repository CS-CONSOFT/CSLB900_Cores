using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD150Conf
{
    public int Id { get; set; }

    public string? Label { get; set; }

    public int? Order { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<CSICP_DD150> OsusrDfwCsicpDd150s { get; set; } = new List<CSICP_DD150>();
}
