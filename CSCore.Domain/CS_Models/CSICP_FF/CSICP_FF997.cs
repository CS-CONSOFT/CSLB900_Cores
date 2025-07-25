using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF997
{
    public int TenantId { get; set; }

    public string Ff997Id { get; set; } = null!;

    public string? Ff997FilialId { get; set; }

    public string? Ff997Usuario { get; set; }

    public DateTime? Ff997DataVencto { get; set; }

    public decimal? Ff997SaldoBanco { get; set; }

    public decimal? Ff997TotalCpagar { get; set; }

    public decimal? Ff997TotalCreceber { get; set; }

    public decimal? Ff997Saldo { get; set; }

    public DateTime? Ff997DataAtualizacao { get; set; }
}
