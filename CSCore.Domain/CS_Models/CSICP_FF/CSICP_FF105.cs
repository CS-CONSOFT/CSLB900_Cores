using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF105
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff105Filialid { get; set; }

    public string? Ff105Descricaobordero { get; set; }

    public int? Ff105ClienteInicial { get; set; }

    public int? Ff105ClienteFinal { get; set; }

    public DateTime? Ff105EmissaoInicial { get; set; }

    public DateTime? Ff105EmissaoFinal { get; set; }

    public DateTime? Ff105VenctoInicial { get; set; }

    public DateTime? Ff105VenctoFinal { get; set; }

    public int? Ff105CodgcategIni { get; set; }

    public int? Ff105CodgcategFim { get; set; }

    public int? Ff105CodgrotaIni { get; set; }

    public int? Ff105CodgrotaFim { get; set; }

    public decimal? Ff105ValorMinimo { get; set; }

    public string? Ff105Agcobradorid { get; set; }

    public string? Ff105Tipocobrancaid { get; set; }

    public string? Ff105InstCobranca1 { get; set; }

    public string? Ff105InstCobranca2 { get; set; }

    public int? Ff105Agencia { get; set; }

    public string? Ff105AgenciaDv { get; set; }

    public int? Ff105ContaCorrente { get; set; }

    public string? Ff105ContaDv { get; set; }

    public DateTime? Ff105DataEnvio { get; set; }

    public decimal? Ff105ValorBordero { get; set; }

    public int? Ff105QtdTitulos { get; set; }

    public bool? Ff105Fechado { get; set; }

    public bool? Ff105IsActive { get; set; }

    public int? Ff105Status { get; set; }

    public string? Ff105Protocolnumber { get; set; }

    public int? Ff105ApiId { get; set; }

    public int? Ff105Statusapi { get; set; }

    public DateTime? Ff105DataCriacao { get; set; }
}
