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
        public (decimal ValorParcela, decimal ValorRestoParcela, decimal ValorFinanciado) Calcular(decimal faturaTotal, int qtdParcelas, int valorEntrada)
        {
            var valorFinanciado = faturaTotal;
            var valorParcela = (valorFinanciado / qtdParcelas).Round(2);
            var valorRestoParcela = valorFinanciado - (valorParcela * qtdParcelas);
            return (valorParcela, valorRestoParcela, valorFinanciado);
        }
    }
}
