using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD127
{
    public int TenantId { get; set; }

    public string Dd127LogccredId { get; set; } = null!;

    public string? Dd127CartacreditoId { get; set; }

    public string? Dd126UsuariopropId { get; set; }

    public DateTime? Dd126DataReg { get; set; }

    public string? Dd126Mensagem { get; set; }

    public virtual CSICP_DD125? Dd127Cartacredito { get; set; }
}
