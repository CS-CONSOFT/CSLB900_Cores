using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF999
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff999IdControle { get; set; }

    public int? Ff999Parcela { get; set; }

    public DateTime? Ff999Datavencto { get; set; }

    public decimal? Ff999Valorparcela { get; set; }
}
