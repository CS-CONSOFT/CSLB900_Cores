using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD894
{
    public int TenantId { get; set; }

    public string Dd894Id { get; set; } = null!;

    public string? Dd894DoctoId { get; set; }

    public string? Dd894DoctoParentId { get; set; }

    public int? Dd894DoctoTipo { get; set; }

    public DateTime? Dd894Datahora { get; set; }

    public virtual CSICP_DD894Nat? Dd894DoctoTipoNavigation { get; set; }
}
