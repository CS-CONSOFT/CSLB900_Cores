using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD131
{
    public int TenantId { get; set; }

    public string Dd131Id { get; set; } = null!;

    public DateTime? Dd131Datahora { get; set; }

    public string? Ff103Id { get; set; }

    public string? Dd131FilialId { get; set; }

    public int? Dd131TpMovto { get; set; }

    public string? Dd131Status { get; set; }

    public virtual CSICP_DD131Tpmovto? Dd131TpMovtoNavigation { get; set; }
}
