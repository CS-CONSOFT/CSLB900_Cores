using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD181
{
    public int TenantId { get; set; }

    public long Dd181Id { get; set; }

    public string? Dd181EstabId { get; set; }

    public string? Dd181Protocolo { get; set; }

    public string? Dd181UsuariopropId { get; set; }

    public DateTime? Dd181Datahora { get; set; }

    public bool? Dd181Isactive { get; set; }

    public int? Dd181Statusid { get; set; }

    public string? Dd181Observacao { get; set; }

    public string? Dd040Id { get; set; }

    public int? Dd181Tpconfid { get; set; }

    public virtual CSICP_DD040? Dd040 { get; set; }

    public virtual CSICP_DD181Tp? Dd181Tpconf { get; set; }
}
