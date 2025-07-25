using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF030
{
    public int TenantId { get; set; }

    public long Id { get; set; }

    public DateTime? Ff030Dtmovto { get; set; }

    public string? Ff030Descricao { get; set; }

    public string? Ff030Protocolnumber { get; set; }

    public string? Ff030CrContaid { get; set; }

    public string? Ff030CpContaid { get; set; }

    public decimal? Ff030Treceita { get; set; }

    public decimal? Ff030Tdespesa { get; set; }

    public decimal? Ff030Vdiferenca { get; set; }

    public int? Ff030Situacaoid { get; set; }
}
