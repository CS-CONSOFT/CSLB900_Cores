using System;
using System.Collections.Generic;
using System.Text;

namespace CSLB900.MSTools.Calculos.Distancia
{
    public static class CalcularDistanciaEntreDuasCoordenadas
    {
        /// <summary>
        /// Calcula a distância entre dois pontos geográficos dados suas coordenadas de latitude/longitude.
        /// Utiliza a fórmula do Grande Círculo para calcular a distância entre duas localizações.
        /// Definições: Latitudes sul são negativas, longitudes leste são positivas.
        /// </summary>
        /// <param name="lat1">Latitude do ponto 1 (em graus decimais)</param>
        /// <param name="lon1">Longitude do ponto 1 (em graus decimais)</param>
        /// <param name="lat2">Latitude do ponto 2 (em graus decimais)</param>
        /// <param name="lon2">Longitude do ponto 2 (em graus decimais)</param>
        /// <param name="unit">Unidade desejada para o resultado: 'M' para milhas terrestres (padrão), 'K' para quilômetros, 'N' para milhas náuticas</param>
        /// <returns>Distância calculada entre os dois pontos na unidade especificada</returns>
        public static double calcular(double lat1, double lon1, double lat2, double lon2, char unit)
        {
            if ((lat1 == lat2) && (lon1 == lon2))
            {
                return 0;
            }
            else
            {
                double theta = lon1 - lon2;
                double dist = Math.Sin(deg2rad(lat1)) * Math.Sin(deg2rad(lat2)) + Math.Cos(deg2rad(lat1)) * Math.Cos(deg2rad(lat2)) * Math.Cos(deg2rad(theta));
                dist = Math.Acos(dist);
                dist = rad2deg(dist);
                dist = dist * 60 * 1.1515;
                if (unit == 'K')
                {
                    dist = dist * 1.609344;
                }
                else if (unit == 'N')
                {
                    dist = dist * 0.8684;
                }
                return (dist);
            }
        }


        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //::  This function converts decimal degrees to radians             :::
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        private static double deg2rad(double deg)
        {
            return (deg * Math.PI / 180.0);
        }

        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //::  This function converts radians to decimal degrees             :::
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        private static double rad2deg(double rad)
        {
            return (rad / Math.PI * 180.0);
        }

    }
}
