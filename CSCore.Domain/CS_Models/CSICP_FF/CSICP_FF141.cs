using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF141
{
    public int TenantId { get; set; }

    public long Ff141Id { get; set; }

    public long? Ff140RdId { get; set; }

    public string? Ff141Descricao { get; set; }

    public decimal? Ff141Vunitario { get; set; }

    public decimal? Ff141Qtd { get; set; }

    public decimal? Ff141Total { get; set; }

}
