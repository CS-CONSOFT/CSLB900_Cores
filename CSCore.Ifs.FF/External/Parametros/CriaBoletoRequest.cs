using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.External.Parametros
{
    public class CriaBoletoRequest
    {
        [JsonPropertyName("numeroConvenio")]
        public long NumeroConvenio { get; set; }

        [JsonPropertyName("numeroCarteira")]
        public int NumeroCarteira { get; set; }

        [JsonPropertyName("numeroVariacaoCarteira")]
        public int NumeroVariacaoCarteira { get; set; }

        [JsonPropertyName("codigoModalidade")]
        public int CodigoModalidade { get; set; }

        [JsonPropertyName("dataEmissao")]
        public string? DataEmissao { get; set; }

        [JsonPropertyName("dataVencimento")]
        public string? DataVencimento { get; set; }

        [JsonPropertyName("valorOriginal")]
        public decimal ValorOriginal { get; set; }

        [JsonPropertyName("valorAbatimento")]
        public decimal ValorAbatimento { get; set; }

        [JsonPropertyName("quantidadeDiasProtesto")]
        public decimal QuantidadeDiasProtesto { get; set; }

        [JsonPropertyName("quantidadeDiasNegativacao")]
        public int QuantidadeDiasNegativacao { get; set; }

        [JsonPropertyName("orgaoNegativador")]
        public int OrgaoNegativador { get; set; }

        [JsonPropertyName("numeroDiasLimiteRecebimento")]
        public int NumeroDiasLimiteRecebimento { get; set; }

        [JsonPropertyName("codigoAceite")]
        public string? CodigoAceite { get; set; }

        [JsonPropertyName("codigoTipoTitulo")]
        public int CodigoTipoTitulo { get; set; }

        [JsonPropertyName("descricaoTipoTitulo")]
        public string? DescricaoTipoTitulo { get; set; }

        [JsonPropertyName("indicadorPermissaoRecebimentoParcial")]
        public string? IndicadorPermissaoRecebimentoParcial { get; set; }

        [JsonPropertyName("numeroTituloBeneficiario")]
        public string? NumeroTituloBeneficiario { get; set; }

        [JsonPropertyName("campoUtilizacaoBeneficiario")]
        public string? CampoUtilizacaoBeneficiario { get; set; }

        [JsonPropertyName("numeroTituloCliente")]
        public string? NumeroTituloCliente { get; set; }

        [JsonPropertyName("mensagemBloquetoOcorrencia")]
        public string? MensagemBloquetoOcorrencia { get; set; }

        [JsonPropertyName("desconto")]
        public Desconto? Desconto { get; set; }

        [JsonPropertyName("segundoDesconto")]
        public SegundoTerceiroDesconto? SegundoDesconto { get; set; }

        [JsonPropertyName("terceiroDesconto")]
        public SegundoTerceiroDesconto? TerceiroDesconto { get; set; }

        [JsonPropertyName("jurosMora")]
        public JurosMora? JurosMora { get; set; }

        [JsonPropertyName("multa")]
        public Multa? Multa { get; set; }

        [JsonPropertyName("pagador")]
        public Pagador? Pagador { get; set; }

        [JsonPropertyName("beneficiarioFinal")]
        public BeneficiarioFinal? BeneficiarioFinal { get; set; }

        [JsonPropertyName("indicadorPix")]
        public string? IndicadorPix { get; set; }
    }

    public class Desconto
    {
        [JsonPropertyName("tipo")]
        public int Tipo { get; set; }

        [JsonPropertyName("dataExpiracao")]
        public string? DataExpiracao { get; set; }

        [JsonPropertyName("porcentagem")]
        public decimal Porcentagem { get; set; }

        [JsonPropertyName("valor")]
        public decimal Valor { get; set; }
    }

    public class SegundoTerceiroDesconto
    {
        [JsonPropertyName("dataExpiracao")]
        public string? DataExpiracao { get; set; }

        [JsonPropertyName("porcentagem")]
        public decimal Porcentagem { get; set; }

        [JsonPropertyName("valor")]
        public decimal Valor { get; set; }
    }

    public class JurosMora
    {
        [JsonPropertyName("tipo")]
        public int Tipo { get; set; }

        [JsonPropertyName("porcentagem")]
        public decimal Porcentagem { get; set; }

        [JsonPropertyName("valor")]
        public decimal Valor { get; set; }
    }

    public class Multa
    {
        [JsonPropertyName("tipo")]
        public int Tipo { get; set; }

        [JsonPropertyName("data")]
        public string? Data { get; set; }

        [JsonPropertyName("porcentagem")]
        public decimal Porcentagem { get; set; }

        [JsonPropertyName("valor")]
        public decimal Valor { get; set; }
    }

    public class Pagador
    {
        [JsonPropertyName("tipoInscricao")]
        public int TipoInscricao { get; set; }

        [JsonPropertyName("numeroInscricao")]
        public long NumeroInscricao { get; set; }

        [JsonPropertyName("nome")]
        public string? Nome { get; set; }

        [JsonPropertyName("endereco")]
        public string? Endereco { get; set; }

        [JsonPropertyName("cep")]
        public int Cep { get; set; }

        [JsonPropertyName("cidade")]
        public string? Cidade { get; set; }

        [JsonPropertyName("bairro")]
        public string? Bairro { get; set; }

        [JsonPropertyName("uf")]
        public string? Uf { get; set; }

        [JsonPropertyName("telefone")]
        public string? Telefone { get; set; }
    }

    public class BeneficiarioFinal
    {
        [JsonPropertyName("tipoInscricao")]
        public int TipoInscricao { get; set; }

        [JsonPropertyName("numeroInscricao")]
        public long NumeroInscricao { get; set; }

        [JsonPropertyName("nome")]
        public string? Nome { get; set; }
    }
}
