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
        public (decimal ValorParcela, decimal ValorRestoParcela, decimal ValorFinanciado) Calcular(decimal faturaTotal, int qtdParcelas, int valorEntrada)
        {
            var valorFinanciado = faturaTotal;
            var valorParcela = valorFinanciado.Round(2);
            return (valorParcela, 0, valorFinanciado);
        }
    }
}
