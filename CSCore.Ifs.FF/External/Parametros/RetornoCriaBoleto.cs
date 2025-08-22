using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.External.Parametros
{
    public class RetornoCriaBoleto
    {
        [JsonPropertyName("numero")]
        public string? Numero { get; set; }

        [JsonPropertyName("numeroCarteira")]
        public string? NumeroCarteira { get; set; }

        [JsonPropertyName("numeroVariacaoCarteira")]
        public string? NumeroVariacaoCarteira { get; set; }

        [JsonPropertyName("codigoCliente")]
        public string? CodigoCliente { get; set; }

        [JsonPropertyName("linhaDigitavel")]
        public string? LinhaDigitavel { get; set; }

        [JsonPropertyName("codigoBarraNumerico")]
        public string? CodigoBarraNumerico { get; set; }

        [JsonPropertyName("numeroContratoCobranca")]
        public string? NumeroContratoCobranca { get; set; }

        [JsonPropertyName("CS_Beneficiario")]
        public CS_Beneficiario CS_Beneficiario { get; set; }

        [JsonPropertyName("CS_QrCode")]
        public CS_QrCode CS_QrCode { get; set; }
    }

    public class CS_Beneficiario
    {
        [JsonPropertyName("agencia")]
        public string? Agencia { get; set; }

        [JsonPropertyName("contaCorrente")]
        public string? ContaCorrente { get; set; }

        [JsonPropertyName("tipoEndereco")]
        public string? TipoEndereco { get; set; }

        [JsonPropertyName("logradouro")]
        public string? Logradouro { get; set; }

        [JsonPropertyName("bairro")]
        public string? Bairro { get; set; }

        [JsonPropertyName("cidade")]
        public string? Cidade { get; set; }

        [JsonPropertyName("codigoCidade")]
        public string? CodigoCidade { get; set; }

        [JsonPropertyName("uf")]
        public string? Uf { get; set; }

        [JsonPropertyName("cep")]
        public string? Cep { get; set; }

        [JsonPropertyName("indicadorComprovacao")]
        public string? IndicadorComprovacao { get; set; }
    }

    public class CS_QrCode
    {
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("txId")]
        public string? TxId { get; set; }

        [JsonPropertyName("emv")]
        public string? Emv { get; set; }
    
    }
}
