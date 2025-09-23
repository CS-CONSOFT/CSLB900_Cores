using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF042
{
    public int TenantId { get; set; }

    public long Ff042Id { get; set; }

    public long? Ff040Id { get; set; }

    public string? Ff042Fpagtoid { get; set; }

    public decimal? Ff042ValorPago { get; set; }

    public int? Ff042Qtd { get; set; }

    public decimal? Ff042ValorTotalpago { get; set; }

    public decimal? Ff042ValorTroco { get; set; }

    public string? Ff042Condicaoid { get; set; }

    public int? Ff042Nroparcelas { get; set; }

    public decimal? Ff042Valor1aparcela { get; set; }

    public DateTime? Ff042DataMovimento { get; set; }

    public string? Ff042ChaveVincId { get; set; }

    public virtual CSICP_FF040? Ff040 { get; set; }

    public IEnumerable<CSICP_FF043> NavListFF043 { get; set; } = new List<CSICP_FF043>();
}
