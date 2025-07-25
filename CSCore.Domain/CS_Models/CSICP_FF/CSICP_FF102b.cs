using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF102b
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff102bFilialid { get; set; }

    public int? Ff102bFilial { get; set; }

    public string? Ff102Id { get; set; }

    public string? Ff102bPfxTitulo { get; set; }

    public decimal? Ff102bNotitulo { get; set; }

    public string? Ff102bSfxTitulo { get; set; }

    public string? Ff102bContaid { get; set; }

    public int? Ff102bCodgcliente { get; set; }

    public decimal? Ff102bPercImposto { get; set; }

    public decimal? Ff102bValorImposto { get; set; }

    public decimal? Ff102bValorImpostoOrigina { get; set; }

    public string? Ff102bCpagarid { get; set; }

    public string? Ff102bContafornid { get; set; }

    public string? Ff102bPfxTituloLink { get; set; }

    public decimal? Ff102bNotituloLink { get; set; }

    public string? Ff102bSfxTituloLink { get; set; }

    public int? Ff102bCodgfornecLink { get; set; }

    public int? Ff102bRegistro { get; set; }

    public int? Ff102bImpostoId { get; set; }

    public virtual CSICP_FF102? Ff102 { get; set; }

    public virtual CSICP_FF102? Ff102bCpagar { get; set; }
}
