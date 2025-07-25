using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD088
{
    public int TenantId { get; set; }

    public string Dd088Id { get; set; } = null!;

    public string? Dd088AprovacaoId { get; set; }

    public int? Dd088Ano { get; set; }

    public int? Dd088Mes { get; set; }

    public decimal? Dd088Valor { get; set; }

    public int? Dd088TipoRegId { get; set; }

    public virtual CSICP_DD085? Dd088Aprovacao { get; set; }

    public virtual CSICP_DD088Tpreg? Dd088TipoReg { get; set; }
}
