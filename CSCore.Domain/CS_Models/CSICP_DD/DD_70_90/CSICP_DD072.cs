using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD072
{
    public int TenantId { get; set; }

    public string Dd072Id { get; set; } = null!;

    public string? Dd070Id { get; set; }

    public string? Dd072Fpagtoid { get; set; }

    public decimal? Dd072ValorPago { get; set; }

    public int? Dd072Qtd { get; set; }

    public decimal? Dd072ValorTotalpago { get; set; }

    public decimal? Dd072ValorTroco { get; set; }

    public string? Dd072Condicaoid { get; set; }

    public int? Dd072Nroparcelas { get; set; }

    public decimal? Dd072Valor1aparcela { get; set; }

    public string? Dd072Administradoraid { get; set; }

    public int? Dd072Filial { get; set; }

    public decimal? Dd072Ci { get; set; }

    public int? Dd072FormaPagto { get; set; }

    public DateTime? Dd072DataMovimento { get; set; }

    public int? Dd072Operador { get; set; }

    public string? Dd072Regtransferido { get; set; }

    public string? Dd072ChaveVincId { get; set; }

    public int? Dd072Produtoservico { get; set; }

    public string? Dd072Cnsu { get; set; }

    public string? Dd072Cdatamovimento { get; set; }

    public int? Dd072Cpv { get; set; }

    public string? Dd072Cdoc { get; set; }

    public string? Dd072Caut { get; set; }

    public string? Dd072Cnsuctf { get; set; }

    public string? Dd072Cautorizadora { get; set; }

    public string? Dd072Cvanctf { get; set; }

    public string? Dd072Cinstituicaoctf { get; set; }

    public string? Dd072Cnsucanc { get; set; }

    public string? Dd072Cdatacanc { get; set; }

    public string? Dd072RetCompestab { get; set; }

    public string? Dd072RetCompcliente { get; set; }

    public string? Dd072RetCompcanc { get; set; }

    public string? Dd072Valordesconto { get; set; }

    public decimal? Dd072Fatoracresc { get; set; }

    public virtual CSICP_DD070? Dd070 { get; set; }
}
