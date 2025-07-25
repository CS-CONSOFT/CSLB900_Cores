using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD822
{
    public int TenantId { get; set; }

    public string Dd822Id { get; set; } = null!;

    public int? Dd822FreqCtambemId { get; set; }

    public int? Dd822FrequenciaCtambem { get; set; }

    public DateTime? Dd822Dultprocctambem { get; set; }

    public DateTime? Dd822Dprxprocctambem { get; set; }

    public int? Dd822Qtdminencontros { get; set; }

    public virtual CSICP_DD901Freq? Dd822FreqCtambem { get; set; }
}
