using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD820
{
    public int TenantId { get; set; }

    public string Dd820Id { get; set; } = null!;

    public string? Dd820AProdutoId { get; set; }

    public string? Dd820BProdutoId { get; set; }

    public decimal? Dd820QvendaA { get; set; }

    public decimal? Dd820QvendaB { get; set; }

    public decimal? Dd820VvendaA { get; set; }

    public decimal? Dd820VvendaB { get; set; }

    public DateTime? Dd820Dtultvenda { get; set; }

    public int? Dd820Qvezes { get; set; }
}
