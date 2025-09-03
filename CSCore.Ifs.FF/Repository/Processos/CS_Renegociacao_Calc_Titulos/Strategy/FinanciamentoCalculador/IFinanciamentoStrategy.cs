using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.FinanciamentoCalculador
{
    public class RetornoFinanciamento
    {
        public decimal ValorParcela { get; set; }
        public decimal ValorRestoParcela { get; set; }
        public decimal ValorFinanciado { get; set; }
    }
    public interface IFinanciamentoStrategy
    {
        RetornoFinanciamento Calcular(decimal faturaTotal, int qtdParcelas, decimal valorEntrada);
    }
}
