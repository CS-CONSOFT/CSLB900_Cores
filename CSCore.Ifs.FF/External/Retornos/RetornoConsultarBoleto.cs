using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.External.Retornos
{
    public class RetornoConsultarBoleto
    {
        public string? CodigoLinhaDigitavel { get; set; }
        public string? TextoEmailPagador { get; set; }
        public string? TextoMensagemBloquetoTitulo { get; set; }
        public int? CodigoTipoMulta { get; set; }
        public int? CodigoCanalPagamento { get; set; }
        public int? NumeroContratoCobranca { get; set; }
        public int? CodigoTipoInscricaoSacado { get; set; }
        public int? NumeroInscricaoSacadoCobranca { get; set; }
        public int? CodigoEstadoTituloCobranca { get; set; }
        public int? CodigoTipoTituloCobranca { get; set; }
        public int? CodigoModalidadeTitulo { get; set; }
        public string? CodigoAceiteTituloCobranca { get; set; }
        public int? CodigoPrefixoDependenciaCobrador { get; set; }
        public int? CodigoIndicadorEconomico { get; set; }
        public string? NumeroTituloCedenteCobranca { get; set; }
        public int? CodigoTipoJuroMora { get; set; }
        public string? DataEmissaoTituloCobranca { get; set; }
        public string? DataRegistroTituloCobranca { get; set; }
        public string? DataVencimentoTituloCobranca { get; set; }
        public decimal? ValorOriginalTituloCobranca { get; set; }
        public decimal? ValorAtualTituloCobranca { get; set; }
        public decimal? ValorPagamentoParcialTitulo { get; set; }
        public decimal? ValorAbatimentoTituloCobranca { get; set; }
        public decimal? PercentualImpostoSobreOprFinanceirasTituloCobranca { get; set; }
        public decimal? ValorImpostoSobreOprFinanceirasTituloCobranca { get; set; }
        public decimal? ValorMoedaTituloCobranca { get; set; }
        public decimal? PercentualJuroMoraTitulo { get; set; }
        public decimal? ValorJuroMoraTitulo { get; set; }
        public decimal? PercentualMultaTitulo { get; set; }
        public decimal? ValorMultaTituloCobranca { get; set; }
        public int? QuantidadeParcelaTituloCobranca { get; set; }
        public string? DataBaixaAutomaticoTitulo { get; set; }
        public string? TextoCampoUtilizacaoCedente { get; set; }
        public string? IndicadorCobrancaPartilhadoTitulo { get; set; }
        public string? NomeSacadoCobranca { get; set; }
        public string? TextoEnderecoSacadoCobranca { get; set; }
        public string? NomeBairroSacadoCobranca { get; set; }
        public string? NomeMunicipioSacadoCobranca { get; set; }
        public string? SiglaUnidadeFederacaoSacadoCobranca { get; set; }
        public int? NumeroCepSacadoCobranca { get; set; }
        public decimal? ValorMoedaAbatimentoTitulo { get; set; }
        public string? DataProtestoTituloCobranca { get; set; }
        public int? CodigoTipoInscricaoSacador { get; set; }
        public int? NumeroInscricaoSacadorAvalista { get; set; }
        public string? NomeSacadorAvalistaTitulo { get; set; }
        public decimal? PercentualDescontoTitulo { get; set; }
        public string? DataDescontoTitulo { get; set; }
        public decimal? ValorDescontoTitulo { get; set; }
        public int? CodigoDescontoTitulo { get; set; }
        public decimal? PercentualSegundoDescontoTitulo { get; set; }
        public string? DataSegundoDescontoTitulo { get; set; }
        public decimal? ValorSegundoDescontoTitulo { get; set; }
        public int? CodigoSegundoDescontoTitulo { get; set; }
        public decimal? PercentualTerceiroDescontoTitulo { get; set; }
        public string? DataTerceiroDescontoTitulo { get; set; }
        public decimal? ValorTerceiroDescontoTitulo { get; set; }
        public int? CodigoTerceiroDescontoTitulo { get; set; }
        public string? DataMultaTitulo { get; set; }
        public int? NumeroCarteiraCobranca { get; set; }
        public int? NumeroVariacaoCarteiraCobranca { get; set; }
        public int? QuantidadeDiaProtesto { get; set; }
        public int? QuantidadeDiaPrazoLimiteRecebimento { get; set; }
        public string? DataLimiteRecebimentoTitulo { get; set; }
        public string? IndicadorPermissaoRecebimentoParcial { get; set; }
        public string? TextoCodigoBarrasTituloCobranca { get; set; }
        public int? CodigoOcorrenciaCartorio { get; set; }
        public decimal? ValorImpostoSobreOprFinanceirasRecebidoTitulo { get; set; }
        public decimal? ValorAbatimentoTotal { get; set; }
        public decimal? ValorJuroMoraRecebido { get; set; }
        public decimal? ValorDescontoUtilizado { get; set; }
        public decimal? ValorPagoSacado { get; set; }
        public decimal? ValorCreditoCedente { get; set; }
        public int? CodigoTipoLiquidacao { get; set; }
        public string? DataCreditoLiquidacao { get; set; }
        public string? DataRecebimentoTitulo { get; set; }
        public int? CodigoPrefixoDependenciaRecebedor { get; set; }
        public int? CodigoNaturezaRecebimento { get; set; }
        public string? NumeroIdentidadeSacadoTituloCobranca { get; set; }
        public string? CodigoResponsavelAtualizacao { get; set; }
        public int? CodigoTipoBaixaTitulo { get; set; }
        public decimal? ValorMultaRecebido { get; set; }
        public decimal? ValorReajuste { get; set; }
        public decimal? ValorOutroRecebido { get; set; }
        public int? CodigoIndicadorEconomicoUtilizadoInadimplencia { get; set; }
    }
}
