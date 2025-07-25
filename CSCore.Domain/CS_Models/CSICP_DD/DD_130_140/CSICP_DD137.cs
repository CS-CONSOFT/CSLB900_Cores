using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD137
{
    public int TenantId { get; set; }

    public long Dd137Id { get; set; }

    public string? Dd137EstabId { get; set; }

    public string? Dd137Descricao { get; set; }

    public DateTime? Dd137Dregistro { get; set; }

    public string? Dd137Usuariopropid { get; set; }

    public string? Dd137Contaid { get; set; }

    public string? Dd137Marcaid { get; set; }

    public DateTime? Dd137Dinicio { get; set; }

    public DateTime? Dd137Dfinal { get; set; }

    public int? Dd137Statusid { get; set; }

    public virtual CSICP_DD137St? Dd137Status { get; set; }
}
