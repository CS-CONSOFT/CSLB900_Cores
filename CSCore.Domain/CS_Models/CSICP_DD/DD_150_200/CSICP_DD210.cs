using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD210
{
    public int TenantId { get; set; }

    public string Dd210Id { get; set; } = null!;

    public int? Dd210Seguroid { get; set; }

    public decimal? Dd210Piof { get; set; }

    public decimal? Dd210Pcomrep { get; set; }

    public string? Dd210Contratoseguradora { get; set; }

    public string? GazinCdPlano { get; set; }

    public int? GazinNrolote { get; set; }

    public string? GazinRangeNrosorte { get; set; }
}
