using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD202
{
    public int TenantId { get; set; }

    public long Dd202Id { get; set; }

    public long? Dd202Obraid { get; set; }

    public string? Dd202Usuarioid { get; set; }

    public DateTime? Dd202Datahorainc { get; set; }

    public bool? Dd202Isactive { get; set; }

    public DateTime? Dd202Dthrinativado { get; set; }

    public int? Dd202Tpprofisionalid { get; set; }

    public virtual CSICP_DD190? Dd202Obra { get; set; }

    public virtual CSICP_DD203Tp? Dd202Tpprofisional { get; set; }
}
