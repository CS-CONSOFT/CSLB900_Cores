using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD154
{
    public int TenantId { get; set; }

    public int Dd154Id { get; set; }

    public int? Dd151Detmontagemid { get; set; }

    public string? Dd154Montadorid { get; set; }

    public DateTime? Dd154Dregistro { get; set; }

    public string? Dd154Mensagem { get; set; }

    public bool? Dd154Ispendente { get; set; }

    public virtual CSICP_DD151? Dd151Detmontagem { get; set; }

    public virtual CSICP_DD158? Dd154Montador { get; set; }
}
