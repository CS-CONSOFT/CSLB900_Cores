using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF129
{
    public int TenantId { get; set; }

    public string Ff129Id { get; set; } = null!;

    public string? Ff130CalendarioId { get; set; }

    public string? Ff129Cobradorid { get; set; }

    public string? Ff129Zonaid { get; set; }

    public string? Ff129Contaid { get; set; }

    public bool? Ff129Isactive { get; set; }

    public int? Ff129Qtddiaslimite { get; set; }

    public virtual CSICP_FF130? Ff130Calendario { get; set; }
}
