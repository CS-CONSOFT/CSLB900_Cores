using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD140
{
    public int TenantId { get; set; }

    public long Dd140Id { get; set; }

    public DateTime? Dd140Dtinicio { get; set; }

    public DateTime? Dd140Dtfinal { get; set; }

    public int? Dd140Qdiasliberarcash { get; set; }

    public int? Dd140Modalidadeid { get; set; }

    public virtual CSICP_DD140Mcb? Dd140Modalidade { get; set; }
}
