using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD084
{
    public int TenantId { get; set; }

    public string Dd084Id { get; set; } = null!;

    public string? Dd084Itemdoatendimento { get; set; }

    public decimal? Dd084Quantidade { get; set; }

    public string? Dd084SaldoId { get; set; }

    public string? Dd084RiId { get; set; }

    public int? Dd084StatId { get; set; }

    public virtual CSICP_DD080? Dd084ItemdoatendimentoNavigation { get; set; }

    public virtual CSICP_DD084Stat? Dd084Stat { get; set; }
}
