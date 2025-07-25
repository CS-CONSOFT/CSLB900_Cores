using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF025
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff024Id { get; set; }

    public int? Ff025NoCupom { get; set; }

    public string? Ff025DescricaoPremio { get; set; }

    public DateTime? Ff025DataSorteio { get; set; }

    public DateTime? Ff025DataPremiacao { get; set; }

    public string? Ff025NomeGanhador { get; set; }

    public string? Ff025Protocolnumber { get; set; }

    public virtual CSICP_FF024? Ff024 { get; set; }
}
