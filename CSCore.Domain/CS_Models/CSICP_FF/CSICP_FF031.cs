using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF031
{
    public int TenantId { get; set; }

    public long Id { get; set; }

    public int? Ff031Tipo { get; set; }

    public long? Ff031Permutaid { get; set; }

    public string? Ff102Id { get; set; }

    public decimal? Ff031Vtitulo { get; set; }

    public decimal? Ff031Vbaixa { get; set; }

    public int? Ff031AntSituacaoid { get; set; }

    public string? Ff031Baixaid { get; set; }

    public virtual CSICP_FF103? Ff031Baixa { get; set; }

    public virtual CSICP_FF030? Ff031Permuta { get; set; }

    public virtual CSICP_FF102? Ff102 { get; set; }
}
