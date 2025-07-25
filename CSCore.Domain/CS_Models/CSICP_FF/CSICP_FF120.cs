using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF120
{
    public int TenantId { get; set; }

    public long Id { get; set; }

    public string? Ff102Id { get; set; }

    public DateTime? Ff120Datahora { get; set; }

    public int? Ff120TrilhaapiId { get; set; }

    public string? Ff120Texto { get; set; }

    public string? Ff120Metodoapi { get; set; }

    public string? Ff120Json { get; set; }

    public virtual CSICP_FF102? Ff102 { get; set; }
}
