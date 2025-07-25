using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_FF;

public partial class CSICP_FF110
{
    public int TenantId { get; set; }

    public string Id { get; set; } = null!;

    public string? Ff110Filialid { get; set; }

    public string? Ff110Usuariopropid { get; set; }

    public string? Ff110Administradoraid { get; set; }

    public DateTime? Ff110DataMovto { get; set; }

    public string? Ff110Agcobradorid { get; set; }

    public decimal? Ff110TotalBruto { get; set; }

    public decimal? Ff110TotalTaxa { get; set; }

    public bool? Ff110Antecipacao { get; set; }

    public decimal? Ff110ValorAntecipacao { get; set; }

    public decimal? Ff110TaxaAntecipacao { get; set; }

    public decimal? Ff110JurosAntecipacao { get; set; }

    public decimal? Ff110Valordespesa { get; set; }

    public decimal? Ff110ValorCreditado { get; set; }

    public decimal? Ff110LoteReferente { get; set; }

    public string? Ff110Observacao { get; set; }

    public decimal? Ff110NroRo { get; set; }

    public int? Ff110Situacaoid { get; set; }

    public DateTime? Ff110VenctoInicial { get; set; }

    public DateTime? Ff110VenctoFinal { get; set; }

    public bool? Ff110IsActive { get; set; }

    public string? Ff110Protocolnumber { get; set; }

    public string? Nn010Id { get; set; }

    public DateTime? Ff110Dtbaixa { get; set; }
}
