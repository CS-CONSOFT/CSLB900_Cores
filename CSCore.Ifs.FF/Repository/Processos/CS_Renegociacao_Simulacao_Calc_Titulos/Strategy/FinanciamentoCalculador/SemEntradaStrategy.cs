using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathNet.Numerics;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.FinanciamentoCalculador
{
    public class SemEntradaStrategy : IFinanciamentoStrategy
    {
        public RetornoFinanciamento Calcular(decimal faturaTotal, int qtdParcelas, decimal valorEntrada)
        {
            var valorFinanciado = faturaTotal;
            var valorParcela = (valorFinanciado / qtdParcelas).Round(3);
            var valorRestoParcela = Math.Abs(valorFinanciado - (valorParcela * qtdParcelas));

            var retFinanciamento = new RetornoFinanciamento
            {
                ValorParcela = valorParcela,
                ValorRestoParcela = valorRestoParcela,
                ValorFinanciado = valorFinanciado
            };

            return retFinanciamento;
        }
    }
}
