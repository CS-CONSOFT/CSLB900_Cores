using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD192
{
    public int TenantId { get; set; }

    public long Dd192Id { get; set; }

    public long? Dd190Obraid { get; set; }

    public string? Dd192Fpagtoid { get; set; }

    public decimal? Dd192ValorPago { get; set; }

    public int? Dd192Qtd { get; set; }

    public decimal? Dd192ValorTotalpago { get; set; }

    public decimal? Dd192ValorTroco { get; set; }

    public string? Dd192Condicaoid { get; set; }

    public int? Dd192Nroparcelas { get; set; }

    public decimal? Dd192Valor1aparcela { get; set; }

    public DateTime? Dd192DataMovimento { get; set; }

    public string? Dd192ChaveVincId { get; set; }

    public virtual CSICP_DD190? Dd190Obra { get; set; }
}
