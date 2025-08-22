using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.External.Parametros
{
    public class AlteraBoletoRequest
    {
        [JsonPropertyName("numeroConvenio")]
        public long NumeroConvenio { get; set; }

        [JsonPropertyName("indicadorNovaDataVencimento")]
        public string? IndicadorNovaDataVencimento { get; set; }

        [JsonPropertyName("alteracaoData")]
        public AlteracaoData? AlteracaoData { get; set; }

        [JsonPropertyName("indicadorNovoValorNominal")]
        public string? IndicadorNovoValorNominal { get; set; }

        [JsonPropertyName("alteracaoValor")]
        public AlteracaoValor? AlteracaoValor { get; set; }

        [JsonPropertyName("indicadorAtribuirDesconto")]
        public string? IndicadorAtribuirDesconto { get; set; }

        [JsonPropertyName("desconto")]
        public DescontoCompleto? Desconto { get; set; }

        [JsonPropertyName("indicadorAlterarDesconto")]
        public string? IndicadorAlterarDesconto { get; set; }

        [JsonPropertyName("alteracaoDesconto")]
        public AlteracaoDesconto? AlteracaoDesconto { get; set; }

        [JsonPropertyName("indicadorAlterarDataDesconto")]
        public string? IndicadorAlterarDataDesconto { get; set; }

        [JsonPropertyName("alteracaoDataDesconto")]
        public AlteracaoDataDesconto? AlteracaoDataDesconto { get; set; }

        [JsonPropertyName("indicadorProtestar")]
        public string? IndicadorProtestar { get; set; }

        [JsonPropertyName("protesto")]
        public Protesto? Protesto { get; set; }

        [JsonPropertyName("indicadorSustacaoProtesto")]
        public string? IndicadorSustacaoProtesto { get; set; }

        [JsonPropertyName("indicadorCancelarProtesto")]
        public string? IndicadorCancelarProtesto { get; set; }

        [JsonPropertyName("indicadorIncluirAbatimento")]
        public string? IndicadorIncluirAbatimento { get; set; }

        [JsonPropertyName("abatimento")]
        public Abatimento? Abatimento { get; set; }

        [JsonPropertyName("indicadorAlterarAbatimento")]
        public string? IndicadorAlterarAbatimento { get; set; }

        [JsonPropertyName("alteracaoAbatimento")]
        public AlteracaoAbatimento? AlteracaoAbatimento { get; set; }

        [JsonPropertyName("indicadorCobrarJuros")]
        public string? IndicadorCobrarJuros { get; set; }

        [JsonPropertyName("juros")]
        public Juros? Juros { get; set; }

        [JsonPropertyName("indicadorDispensarJuros")]
        public string? IndicadorDispensarJuros { get; set; }

        [JsonPropertyName("indicadorCobrarMulta")]
        public string? IndicadorCobrarMulta { get; set; }

        [JsonPropertyName("multa")]
        public MultaCompleta? Multa { get; set; }

        [JsonPropertyName("indicadorDispensarMulta")]
        public string? IndicadorDispensarMulta { get; set; }

        [JsonPropertyName("indicadorNegativar")]
        public string? IndicadorNegativar { get; set; }

        [JsonPropertyName("negativacao")]
        public Negativacao? Negativacao { get; set; }

        [JsonPropertyName("indicadorAlterarSeuNumero")]
        public string? IndicadorAlterarSeuNumero { get; set; }

        [JsonPropertyName("alteracaoSeuNumero")]
        public AlteracaoSeuNumero? AlteracaoSeuNumero { get; set; }

        [JsonPropertyName("indicadorAlterarEnderecoPagador")]
        public string? IndicadorAlterarEnderecoPagador { get; set; }

        [JsonPropertyName("alteracaoEndereco")]
        public AlteracaoEndereco? AlteracaoEndereco { get; set; }

        [JsonPropertyName("indicadorAlterarPrazoBoletoVencido")]
        public string? IndicadorAlterarPrazoBoletoVencido { get; set; }

        [JsonPropertyName("alteracaoPrazo")]
        public AlteracaoPrazo? AlteracaoPrazo { get; set; }
    }

    public class AlteracaoData
    {
        [JsonPropertyName("novaDataVencimento")]
        public string? NovaDataVencimento { get; set; }
    }

    public class AlteracaoValor
    {
        [JsonPropertyName("novoValorNominal")]
        public decimal NovoValorNominal { get; set; }
    }

    public class DescontoCompleto
    {
        [JsonPropertyName("tipoPrimeiroDesconto")]
        public int TipoPrimeiroDesconto { get; set; }

        [JsonPropertyName("valorPrimeiroDesconto")]
        public decimal ValorPrimeiroDesconto { get; set; }

        [JsonPropertyName("percentualPrimeiroDesconto")]
        public decimal PercentualPrimeiroDesconto { get; set; }

        [JsonPropertyName("dataPrimeiroDesconto")]
        public string? DataPrimeiroDesconto { get; set; }

        [JsonPropertyName("tipoSegundoDesconto")]
        public int TipoSegundoDesconto { get; set; }

        [JsonPropertyName("valorSegundoDesconto")]
        public decimal ValorSegundoDesconto { get; set; }

        [JsonPropertyName("percentualSegundoDesconto")]
        public decimal PercentualSegundoDesconto { get; set; }

        [JsonPropertyName("dataSegundoDesconto")]
        public string? DataSegundoDesconto { get; set; }

        [JsonPropertyName("tipoTerceiroDesconto")]
        public int TipoTerceiroDesconto { get; set; }

        [JsonPropertyName("valorTerceiroDesconto")]
        public decimal ValorTerceiroDesconto { get; set; }

        [JsonPropertyName("percentualTerceiroDesconto")]
        public decimal PercentualTerceiroDesconto { get; set; }

        [JsonPropertyName("dataTerceiroDesconto")]
        public string? DataTerceiroDesconto { get; set; }
    }

    public class AlteracaoDesconto
    {
        [JsonPropertyName("tipoPrimeiroDesconto")]
        public int TipoPrimeiroDesconto { get; set; }

        [JsonPropertyName("novoValorPrimeiroDesconto")]
        public decimal NovoValorPrimeiroDesconto { get; set; }

        [JsonPropertyName("novoPercentualPrimeiroDesconto")]
        public decimal NovoPercentualPrimeiroDesconto { get; set; }

        [JsonPropertyName("novaDataLimitePrimeiroDesconto")]
        public string? NovaDataLimitePrimeiroDesconto { get; set; }

        [JsonPropertyName("tipoSegundoDesconto")]
        public int TipoSegundoDesconto { get; set; }

        [JsonPropertyName("novoValorSegundoDesconto")]
        public decimal NovoValorSegundoDesconto { get; set; }

        [JsonPropertyName("novoPercentualSegundoDesconto")]
        public decimal NovoPercentualSegundoDesconto { get; set; }

        [JsonPropertyName("novaDataLimiteSegundoDesconto")]
        public string? NovaDataLimiteSegundoDesconto { get; set; }

        [JsonPropertyName("tipoTerceiroDesconto")]
        public int TipoTerceiroDesconto { get; set; }

        [JsonPropertyName("novoValorTerceiroDesconto")]
        public decimal NovoValorTerceiroDesconto { get; set; }

        [JsonPropertyName("novoPercentualTerceiroDesconto")]
        public decimal NovoPercentualTerceiroDesconto { get; set; }

        [JsonPropertyName("novaDataLimiteTerceiroDesconto")]
        public string? NovaDataLimiteTerceiroDesconto { get; set; }
    }

    public class AlteracaoDataDesconto
    {
        [JsonPropertyName("novaDataLimitePrimeiroDesconto")]
        public string? NovaDataLimitePrimeiroDesconto { get; set; }

        [JsonPropertyName("novaDataLimiteSegundoDesconto")]
        public string? NovaDataLimiteSegundoDesconto { get; set; }

        [JsonPropertyName("novaDataLimiteTerceiroDesconto")]
        public string? NovaDataLimiteTerceiroDesconto { get; set; }
    }

    public class Protesto
    {
        [JsonPropertyName("quantidadeDiasProtesto")]
        public decimal QuantidadeDiasProtesto { get; set; }
    }

    public class Abatimento
    {
        [JsonPropertyName("valorAbatimento")]
        public decimal ValorAbatimento { get; set; }
    }

    public class AlteracaoAbatimento
    {
        [JsonPropertyName("novoValorAbatimento")]
        public decimal NovoValorAbatimento { get; set; }
    }

    public class Juros
    {
        [JsonPropertyName("tipoJuros")]
        public int TipoJuros { get; set; }

        [JsonPropertyName("valorJuros")]
        public decimal ValorJuros { get; set; }

        [JsonPropertyName("taxaJuros")]
        public decimal TaxaJuros { get; set; }
    }

    public class MultaCompleta
    {
        [JsonPropertyName("tipoMulta")]
        public int TipoMulta { get; set; }

        [JsonPropertyName("valorMulta")]
        public decimal ValorMulta { get; set; }

        [JsonPropertyName("dataInicioMulta")]
        public string? DataInicioMulta { get; set; }

        [JsonPropertyName("taxaMulta")]
        public decimal TaxaMulta { get; set; }
    }

    public class Negativacao
    {
        [JsonPropertyName("quantidadeDiasNegativacao")]
        public int QuantidadeDiasNegativacao { get; set; }

        [JsonPropertyName("tipoNegativacao")]
        public int TipoNegativacao { get; set; }

        [JsonPropertyName("orgaoNegativador")]
        public int OrgaoNegativador { get; set; }
    }

    public class AlteracaoSeuNumero
    {
        [JsonPropertyName("codigoSeuNumero")]
        public string? CodigoSeuNumero { get; set; }
    }

    public class AlteracaoEndereco
    {
        [JsonPropertyName("enderecoPagador")]
        public string? EnderecoPagador { get; set; }

        [JsonPropertyName("bairroPagador")]
        public string? BairroPagador { get; set; }

        [JsonPropertyName("cidadePagador")]
        public string? CidadePagador { get; set; }

        [JsonPropertyName("UFPagador")]
        public string? UFPagador { get; set; }

        [JsonPropertyName("CEPPagador")]
        public int CEPPagador { get; set; }
    }

    public class AlteracaoPrazo
    {
        [JsonPropertyName("quantidadeDiasAceite")]
        public int QuantidadeDiasAceite { get; set; }
    }
}
