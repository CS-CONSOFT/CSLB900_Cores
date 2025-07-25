using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD047
{
    public int TenantId { get; set; }

    public string Dd047Id { get; set; } = null!;

    public string? Dd045Id { get; set; }

    public string? Dd040Id { get; set; }

    public int? Dd047Filial { get; set; }

    public decimal? Dd047Ci { get; set; }

    public int? Dd047CodDocArrec { get; set; }

    public string? Dd047UfBeneficiaria { get; set; }

    public string? Dd047UfBenef { get; set; }

    public string? Dd047NumDocArrec { get; set; }

    public string? Dd047Autenticacao { get; set; }

    public decimal? Dd047ValorDocArrec { get; set; }

    public DateTime? Dd047DtVencimento { get; set; }

    public DateTime? Dd047DtPagamento { get; set; }

    public virtual CSICP_DD040? Dd040 { get; set; }

    public virtual CSICP_DD045? Dd045 { get; set; }
}
