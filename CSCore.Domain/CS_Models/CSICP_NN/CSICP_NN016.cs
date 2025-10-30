using System;
using System.Collections.Generic;

namespace CSCore.Domain.CS_Models.CSICP_NN;

public partial class CSICP_NN016
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

    public CSICP_NN016 CreateInstance(int TenantId,
string Nn016Id,
string? Nn016CrcpId,
int? Nn016Filial,
int? Nn016TipoMovimento,
int? Nn016FilialBaixa,
string? Nn016TituloId,
string? Nn016Prefixo,
decimal? Nn016Titulo,
string? Nn016Sfx,
int? Nn016SequenciaBaixa,
DateTime? Nn016DataVencimento,
int? Nn016Diasatraso,
decimal? Nn016Vlrabertotitulos,
decimal? Nn016ValorJuros,
decimal? Nn016ValorDesconto,
decimal? Nn016ValorMulta,
decimal? Nn016ValorTaxa,
decimal? Nn016ValorPago,
int? Nn016SituacaotitId,
bool? Nn016BaixarSn,
int? Nn016CliFor,
string? Nn016Historico,
string? Nn016Mensagem,
decimal? Nn016ValorJurosCalc,
decimal? Nn016ValorMultaCalc,
decimal? Nn016ValorTaxaCalc,
decimal? Nn016TotalApagar,
string? Nn016Protocolnumber,
string? Nn016IdEstorno,
decimal? Nn016TaxaAntecipacao,
decimal? Nn016ValorTxAntcartao,
decimal? Nn016Vcorrmonetaria,
decimal? Nn016Vhonorarios
)
    {
        return new CSICP_NN016
        {
            TenantId = TenantId,
            Nn016Id = Nn016Id,
            Nn016CrcpId = Nn016CrcpId,
            Nn016Filial = Nn016Filial,
            Nn016TipoMovimento = Nn016TipoMovimento,
            Nn016FilialBaixa = Nn016FilialBaixa,
            Nn016TituloId = Nn016TituloId,
            Nn016Prefixo = Nn016Prefixo,
            Nn016Titulo = Nn016Titulo,
            Nn016Sfx = Nn016Sfx,
            Nn016SequenciaBaixa = Nn016SequenciaBaixa,
            Nn016DataVencimento = Nn016DataVencimento,
            Nn016Diasatraso = Nn016Diasatraso,
            Nn016Vlrabertotitulos = Nn016Vlrabertotitulos,
            Nn016ValorJuros = Nn016ValorJuros,
            Nn016ValorDesconto = Nn016ValorDesconto,
            Nn016ValorMulta = Nn016ValorMulta,
            Nn016ValorTaxa = Nn016ValorTaxa,
            Nn016ValorPago = Nn016ValorPago,
            Nn016SituacaotitId = Nn016SituacaotitId,
            Nn016BaixarSn = Nn016BaixarSn,
            Nn016CliFor = Nn016CliFor,
            Nn016Historico = Nn016Historico,
            Nn016Mensagem = Nn016Mensagem,
            Nn016ValorJurosCalc = Nn016ValorJurosCalc,
            Nn016ValorMultaCalc = Nn016ValorMultaCalc,
            Nn016ValorTaxaCalc = Nn016ValorTaxaCalc,
            Nn016TotalApagar = Nn016TotalApagar,
            Nn016Protocolnumber = Nn016Protocolnumber,
            Nn016IdEstorno = Nn016IdEstorno,
            Nn016TaxaAntecipacao = Nn016TaxaAntecipacao,
            Nn016ValorTxAntcartao = Nn016ValorTxAntcartao,
            Nn016Vcorrmonetaria = Nn016Vcorrmonetaria,
            Nn016Vhonorarios = Nn016Vhonorarios,

        };
    }




}
