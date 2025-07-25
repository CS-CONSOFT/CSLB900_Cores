using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD077
{
    public int TenantId { get; set; }

    public string Dd077Id { get; set; } = null!;

    public string? Dd070Id { get; set; }

    public int? Dd077CodDocArrec { get; set; }

    public string? Dd077UfBeneficiaria { get; set; }

    public string? Dd077UfBenef { get; set; }

    public string? Dd077NumDocArrec { get; set; }

    public string? Dd077Autenticacao { get; set; }

    public decimal? Dd077ValorDocArrec { get; set; }

    public DateTime? Dd077DtVencimento { get; set; }

    public DateTime? Dd077DtPagamento { get; set; }

    public virtual CSICP_DD070? Dd070 { get; set; }
}
