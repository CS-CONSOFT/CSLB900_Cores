using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF132
{
    public int TenantId { get; set; }

    public long Ff132Id { get; set; }

    public long? Ff131Id { get; set; }

    public string? Ff102Id { get; set; }

    public virtual CSICP_FF102? Ff102 { get; set; }

    public virtual CSICP_FF131? Ff131 { get; set; }

    // Propriedades de navegação movidas do RepoDtoCSICP_FF132
    public CSICP_FF131? NavFF131 { get; set; }
    public CSICP_FF102? NavFF102 { get; set; }
}
