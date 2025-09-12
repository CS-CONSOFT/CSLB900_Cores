using CSCore.Domain.CS_Models.Staticas.FF;
using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF018
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff017Id { get; set; }

    public string? Ff102Tituloid { get; set; }

    public decimal? Ff018ValorTitulo { get; set; }

    public decimal? Ff018ValorMulta { get; set; }

    public decimal? Ff018ValorJuros { get; set; }

    public decimal? Ff018ValorDescontos { get; set; }

    public decimal? Ff018ValorAberto { get; set; }

    public int? Ff018Situacaotituloid { get; set; }

    public int? Ff018Filial { get; set; }

    public int? Ff018FilialTit { get; set; }

    public string? Ff018Pfx { get; set; }

    public decimal? Ff018Titulo { get; set; }

    public string? Ff018Sfx { get; set; }

    public string? Ff018Situacao { get; set; }

    public string? Ff018Protocolnumber { get; set; }

    public decimal? Ff018Vmultaorig { get; set; }

    public decimal? Ff018Vjurosorig { get; set; }

    public decimal? Ff018Vabertoorig { get; set; }

    public virtual CSICP_FF017? Ff017 { get; set; }

    public virtual CSICP_FF102? Ff102Titulo { get; set; }

    // Propriedades de navegação movidas do RepoDtoCSICP_FF018
    public CSICP_FF102? NavFF102 { get; set; }
    public CSICP_FF102Sit? NavFF102Sit { get; set; }
}
