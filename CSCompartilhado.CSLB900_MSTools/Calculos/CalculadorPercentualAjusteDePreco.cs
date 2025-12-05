using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLB900.MSTools.Calculos
{
    public static class CalculadorPercentualAjusteDePreco
    {
        /// <summary>
        /// preco base = 1000 | percentual de venda = 10% |  preco_venda_1 = 1000 + (1000 * 10 / 100) = 1100
        /// </summary>
        /// <param name="Preco"></param>
        /// <param name="PercentualVenda"></param>
        /// <returns></returns>
        public static decimal? CalculaPercentual(this decimal? precoVendaAtual, decimal? preco, decimal? percentualVenda)
        {
            if (percentualVenda == 0) return precoVendaAtual;
            return Trunca(preco + (preco * (percentualVenda / 100)));
        }

        private static decimal Trunca(decimal? valor)
        {
            return Math.Round(valor ?? 0, 2, MidpointRounding.AwayFromZero);
        }
    }
}
