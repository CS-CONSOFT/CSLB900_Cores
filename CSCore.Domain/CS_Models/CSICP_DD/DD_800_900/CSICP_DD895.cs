using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD895
{
    public int TenantId { get; set; }

    public string Dd895Id { get; set; } = null!;

    public string? Dd070Id { get; set; }

    public string? Cc020Id { get; set; }

    public string? Cc030PedidoId { get; set; }

    public string? Cc040Id { get; set; }

    public string? Dd040Id { get; set; }

    public int? Processid { get; set; }

    public int? Dd895Stat { get; set; }

    public int? Dd895Execid { get; set; }

    public virtual CSICP_DD040? Dd040 { get; set; }

    public virtual CSICP_DD070? Dd070 { get; set; }

    public virtual CSICP_DD895Exec? Dd895Exec { get; set; }

    public virtual CSICP_DD895Stat? Dd895StatNavigation { get; set; }
}
