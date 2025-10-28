using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_NN;

public partial class OsusrE9aCsicpNn016
{
    public int TenantId { get; set; }

    public string Nn016Id { get; set; } = null!;

    public string? Nn016CrcpId { get; set; }

    public int? Nn016Filial { get; set; }

    public int? Nn016TipoMovimento { get; set; }

    public int? Nn016FilialBaixa { get; set; }

    public string? Nn016TituloId { get; set; }

    public string? Nn016Prefixo { get; set; }

    public decimal? Nn016Titulo { get; set; }

    public string? Nn016Sfx { get; set; }

    public int? Nn016SequenciaBaixa { get; set; }

    public DateTime? Nn016DataVencimento { get; set; }

    public int? Nn016Diasatraso { get; set; }

    public decimal? Nn016Vlrabertotitulos { get; set; }

    public decimal? Nn016ValorJuros { get; set; }

    public decimal? Nn016ValorDesconto { get; set; }

    public decimal? Nn016ValorMulta { get; set; }

    public decimal? Nn016ValorTaxa { get; set; }

    public decimal? Nn016ValorPago { get; set; }

    public int? Nn016SituacaotitId { get; set; }

    public bool? Nn016BaixarSn { get; set; }

    public int? Nn016CliFor { get; set; }

    public string? Nn016Historico { get; set; }

    public string? Nn016Mensagem { get; set; }

    public decimal? Nn016ValorJurosCalc { get; set; }

    public decimal? Nn016ValorMultaCalc { get; set; }

    public decimal? Nn016ValorTaxaCalc { get; set; }

    public decimal? Nn016TotalApagar { get; set; }

    public string? Nn016Protocolnumber { get; set; }

    public string? Nn016IdEstorno { get; set; }

    public decimal? Nn016TaxaAntecipacao { get; set; }

    public decimal? Nn016ValorTxAntcartao { get; set; }

    public decimal? Nn016Vcorrmonetaria { get; set; }

    public decimal? Nn016Vhonorarios { get; set; }

    public virtual CSICP_NN015? Nn016Crcp { get; set; }
}
