using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF001
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff001Filialid { get; set; }

    public int? Ff001Filial { get; set; }

    public DateTime? Ff001Data { get; set; }

    public string? Ff001Descferiado { get; set; }

    public string? Ff001NomeDoDia { get; set; }

    public CSICP_BB001? NavBB001 { get; set; }
}
