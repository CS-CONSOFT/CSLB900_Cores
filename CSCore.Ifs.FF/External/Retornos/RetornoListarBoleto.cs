    using System;
using System.Collections.Generic;

namespace CSCore.Ifs.FF.External.Retornos
{

    public class RetornoListarBoleto
    {
        public string? IndicadorContinuidade { get; set; }
        public int QuantidadeRegistros { get; set; }
        public int ProximoIndice { get; set; }
        public List<BoletoItem> Boletos { get; set; } = [];
    }

    public class BoletoItem
    {
        public string? NumeroBoletoBB { get; set; }
        public string? EstadoTituloCobranca { get; set; }
        public string? DataRegistro { get; set; }
        public string? DataVencimento { get; set; }
        public string? DataMovimento { get; set; }
        public decimal ValorOriginal { get; set; }
        public decimal ValorAtual { get; set; }
        public decimal ValorPago { get; set; }
        public int Contrato { get; set; }
        public int CarteiraConvenio { get; set; }
        public int VariacaoCarteiraConvenio { get; set; }
        public int CodigoEstadoTituloCobranca { get; set; }
        public string? DataCredito { get; set; }
    }
}
