using System;
using System.Collections.Generic;
using System.Text;

namespace CSLB900.MSTools.Calculos.Distancia
{
    public static class CalcularTempoAteLocal
    {
        /// <summary>
        /// Retorna o tempo estimado até o local em minutos, dado a distância em metros e a velocidade média em metros por segundo.
        /// </summary>
        /// <param name="distanciaEmMetros">Distância até o local em metros</param>
        /// <param name="velocidadeMediaMS">Velocidade média em metros por segundo (m/s)</param>
        /// <returns>Tempo estimado até o local em minutos</returns>
        /// <exception cref="ArgumentException">Quando a velocidade média é menor ou igual a zero</exception>
        public static double Calcular(double distanciaEmMetros, double velocidadeMediaMS)
        {
            if (velocidadeMediaMS <= 0)
            {
                throw new ArgumentException("A velocidade média deve ser maior que zero.", nameof(velocidadeMediaMS));
            }

            // Tempo = Distância / Velocidade (resultado em segundos)
            double tempoEmSegundos = distanciaEmMetros / velocidadeMediaMS;

            // Converter segundos para minutos
            double tempoEmMinutos = tempoEmSegundos / 60;

            return tempoEmMinutos;
        }
    }
}