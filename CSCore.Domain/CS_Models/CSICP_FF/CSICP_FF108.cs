using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF108
{
    public int TenantId { get; set; }

    public long Ff108Id { get; set; }

    public string? Ff105Borderoid { get; set; }

    public DateTime? Ff108Datahora { get; set; }

    public string? Ff108Mensagem { get; set; }

    public string? Ff108UsuarioId { get; set; }

    public virtual CSICP_FF105? Ff105Bordero { get; set; }
}
