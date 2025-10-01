using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_DD;

public partial class CSICP_DD042
{
    public int TenantId { get; set; }

    public string Dd042Id { get; set; } = null!;

    public string? Dd040Id { get; set; }

    public string? Dd042Fpagtoid { get; set; }

    public decimal? Dd042ValorPago { get; set; }

    public int? Dd042Qtd { get; set; }

    public decimal? Dd042ValorTotalpago { get; set; }

    public decimal? Dd042ValorTroco { get; set; }

    public string? Dd042Condicaoid { get; set; }

    public int? Dd042Nroparcelas { get; set; }

    public decimal? Dd042Valor1aparcela { get; set; }

    public string? Dd042Administradoraid { get; set; }

    public int? Dd042Filial { get; set; }

    public decimal? Dd042Ci { get; set; }

    public int? Dd042FormaPagto { get; set; }

    public DateTime? Dd042DataMovimento { get; set; }

    public int? Dd042Operador { get; set; }

    public string? Dd042Regtransferido { get; set; }

    public string? Dd042ChaveVincId { get; set; }

    public int? Dd042Produtoservico { get; set; }

    public string? Dd042Cnsu { get; set; }

    public string? Dd042Cdatamovimento { get; set; }

    public int? Dd042Cpv { get; set; }

    public string? Dd042Cdoc { get; set; }

    public string? Dd042Caut { get; set; }

    public decimal? Dd042Perccomissao { get; set; }

    public decimal? Dd042Valorcomissao { get; set; }

    public string? Dd042Cnsuctf { get; set; }

    public string? Dd042Cautorizadora { get; set; }

    public string? Dd042Cvanctf { get; set; }

    public string? Dd042Cinstituicaoctf { get; set; }

    public string? Dd042Cnsucanc { get; set; }

    public string? Dd042Cdatacanc { get; set; }

    public string? Dd042RetCompestab { get; set; }

    public string? Dd042RetCompcliente { get; set; }

    public string? Dd042RetCompcanc { get; set; }

    public decimal? Dd042Nrotitulo { get; set; }

    public decimal? Dd042Fatoracresc { get; set; }
    
    //Navs movidos do antigo RepoDTO_CSICPDD042
    public CSICP_Bb019? NavBB019 { get; set; }
    public CSICP_Bb026? NavBB026 { get; set; }
    public CSICP_Bb026Classe? NavBb026Classe { get; set; }
    public IEnumerable<CSICP_DD043?> NavDD043 { get; set; } = [];
}
