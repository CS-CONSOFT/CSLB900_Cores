using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF024
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff024Filialid { get; set; }

    public string? Ff024Descricao { get; set; }

    public DateTime? Ff024DtIni { get; set; }

    public DateTime? Ff024DtFim { get; set; }

    public int? Ff024Finalizado { get; set; }

    public int? Ff024Diasmargem { get; set; }

    public decimal? Ff024Valorcupom { get; set; }

    public string? Ff024Protocolnumber { get; set; }
}
