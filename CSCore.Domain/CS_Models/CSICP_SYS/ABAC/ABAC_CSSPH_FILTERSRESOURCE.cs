using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_SYS.ABAC;

public partial class ABAC_CSSPH_FILTERSRESOURCE
{
    public long Id { get; set; }

    public string? Resourceid { get; set; }

    public string? Filterid { get; set; }

    public int? Orderindex { get; set; }

    public bool? Isrequired { get; set; }
}
