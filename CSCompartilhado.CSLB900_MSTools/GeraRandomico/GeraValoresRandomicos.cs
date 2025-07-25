using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSLB900.MSTools.GeraRandomico
{
    public static class GeraValoresRandomicos
    {
        public static string GeraAlfaNumericoCom7Posicoes()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var bytes = new byte[7];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);

            var resultado = new char[7];
            for (int i = 0; i < 7; i++)
            {
                resultado[i] = chars[bytes[i] % chars.Length];
            }
            return new string(resultado);
        }
    }
}
