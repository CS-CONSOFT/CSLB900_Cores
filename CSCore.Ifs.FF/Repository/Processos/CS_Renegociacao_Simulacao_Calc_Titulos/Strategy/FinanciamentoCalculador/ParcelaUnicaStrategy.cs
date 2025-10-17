using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.FinanciamentoCalculador
{
    public class ParcelaUnicaStrategy : IFinanciamentoStrategy
    {
        public RetornoFinanciamento Calcular(decimal faturaTotal, int qtdParcelas, decimal valorEntrada)
        {
            var valorFinanciado = faturaTotal;
            var valorParcela = (valorFinanciado/qtdParcelas).Round(2);
            var retFinanciamento = new RetornoFinanciamento
            {
                ValorParcela = valorParcela,
                ValorRestoParcela = 0,
                ValorFinanciado = valorFinanciado
            };
            return retFinanciamento;
        }
    }
}
