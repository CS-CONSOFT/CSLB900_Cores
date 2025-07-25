using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLB900.MSTools.Calculos
{
    public static class CalculoCFinanciamento
    {
        // Fórmula que calcula o coeficiente de financiamento cf = i / (1 - (1 / (1 + i)^n))
        // Onde: i = taxa de juros e n = quantidade de parcelas
        // cf = coeficiente de financiamento

        public static decimal CalcularCoeficienteFinanciamento(decimal percentualJuros, int quantidadeParcelas)
        {
            if (percentualJuros <= 0)
                throw new ArgumentException("A taxa de juros deve ser maior que zero.");
            if (quantidadeParcelas <= 0)
                throw new ArgumentException("A quantidade de parcelas deve ser maior que zero.");
            
            decimal taxaJuros = (percentualJuros / 100); // Converte percentualJuros para decimal
            double taxaJurosDouble = (double)taxaJuros; // Converte para double para usar Math.Pow
            double denominador = 1 - (1 / Math.Pow(1 + taxaJurosDouble, quantidadeParcelas)); // Calcula o denominador da fórmula

            double cf = taxaJurosDouble / denominador; // Calcula o coeficiente de financiamento

            return Math.Round((decimal)cf, 6); // Converte o resultado de volta para decimal
        }
    }
}