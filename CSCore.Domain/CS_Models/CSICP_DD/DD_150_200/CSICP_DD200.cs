using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD200
{
    public int TenantId { get; set; }

    public long Dd200Checklistid { get; set; }

    public string? Dd200Descricao { get; set; }

    public decimal? Dd200Qtdestimada { get; set; }

    public bool? Dd200Isactive { get; set; }
}
