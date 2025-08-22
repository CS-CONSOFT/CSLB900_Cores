using System;
using MathNet.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.FinanciamentoCalculador
{
    public class ComEntradaStrategy : IFinanciamentoStrategy
    {
        public (decimal ValorParcela, decimal ValorRestoParcela, decimal ValorFinanciado) Calcular(decimal faturaTotal, int qtdParcelas, int valorEntrada)
        {
            var valorFinanciado = faturaTotal - valorEntrada;
            var parcelasRestantes = qtdParcelas - 1;
            var valorParcela = (valorFinanciado / parcelasRestantes).Round(2);
            var valorRestoParcela = valorFinanciado - (valorParcela * parcelasRestantes);
            return (valorParcela, valorRestoParcela, valorFinanciado);
        }
    }
}
