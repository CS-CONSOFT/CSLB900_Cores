using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF026
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff026Filialid { get; set; }

    public string? Ff102Id { get; set; }

    public string? Ff026Pfx { get; set; }

    public decimal? Ff026NoTitulo { get; set; }

    public string? Ff026Complemento { get; set; }

    public decimal? Ff026Valor { get; set; }

    public string? Ff026Contaid { get; set; }

    public string? Ff024Sorteioid { get; set; }

    public virtual CSICP_FF024? Ff024Sorteio { get; set; }

    public virtual CSICP_FF102? Ff102 { get; set; }
}
