using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF112Faixa
{
    public int TenantId { get; set; }

    public string Ff112FaixaId { get; set; } = null!;

    public string? Ff112Id { get; set; }

    public decimal? Ff112NossonroInicial { get; set; }

    public decimal? Ff112NossonroFinal { get; set; }

    public decimal? Ff112NossonroAtual { get; set; }

    public decimal? Ff112Avisonossonro { get; set; }

    public bool? Ff112Isactive { get; set; }

    public virtual CSICP_FF112? Ff112 { get; set; }
}
