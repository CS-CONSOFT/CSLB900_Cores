using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.FF.Repository.Processos.CS_Renegociacao_Calc_Titulos.Strategy.FinanciamentoCalculador
{
    public static class FinanciamentoCalculator
    {
        public static RetornoFinanciamento CalcularValoresFinanciamento(
            decimal faturaTotal, 
            int qtdParcelas,
            decimal valorEntrada)
        {
            if (qtdParcelas <= 0)
                throw new ArgumentException("Quantidade de parcelas deve ser maior que zero.", nameof(qtdParcelas));

            IFinanciamentoStrategy strategy;
            if (qtdParcelas == 1)
                strategy = new ParcelaUnicaStrategy();
            else if (valorEntrada > 0)
                strategy = new ComEntradaStrategy();
            else
                strategy = new SemEntradaStrategy();

            return strategy.Calcular(faturaTotal, qtdParcelas, valorEntrada);
        }
    }
}
