using System;
using System.Collections.Generic;
using System.Text;

namespace CSLB900.MSTools.Calculos.Distancia
{
    public static class CalcularTempoAteLocal
    {
        /// <summary>
        /// Retorna o tempo estimado até o local em minutos, dado a distância em quilômetros e a velocidade média em quilômetros por hora.
        /// </summary>
        /// <param name="distanciaEmKm">Distancia ate o local em quilômetros</param>
        /// <param name="velocidadeMediaKmH">Velocidade média em quilômetros por hora</param>
        /// <returns>Tempo estimado até o local em minutos</returns>
        /// <exception cref="ArgumentException"></exception>
        public static double Calcular(double distanciaEmKm, double velocidadeMediaKmH)
        {
            if (velocidadeMediaKmH <= 0)
            {
                throw new ArgumentException("A velocidade média deve ser maior que zero.");
            }
            // Tempo = Distância / Velocidade
            double tempoEmHoras = distanciaEmKm / velocidadeMediaKmH;
            // Converter horas para minutos
            double tempoEmMinutos = tempoEmHoras * 60;
            return tempoEmMinutos;
        }
    }
}
