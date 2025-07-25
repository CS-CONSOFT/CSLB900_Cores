using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLB900.MSTools.Util
{
    public static class ValidaCnpj
    {
        public static bool CnpjValido(string? cnpj)
        {
            // Verifica se o CNPJ é nulo ou vazio
            if (cnpj is null || cnpj == "") return false;

            // Remove pontuação e espaços, mantendo apenas os dígitos
            cnpj = new string(cnpj.Where(char.IsDigit).ToArray());

            // O CNPJ deve conter exatamente 14 dígitos
            if (cnpj.Length != 14)
                return false;

            // Verifica se todos os dígitos são iguais (CNPJs assim são inválidos)
            if (cnpj.Distinct().Count() == 1)
                return false;

            // Multiplicadores para o cálculo do primeiro dígito verificador
            int[] multiplicadores1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            // Multiplicadores para o cálculo do segundo dígito verificador
            int[] multiplicadores2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            // Calcula o primeiro dígito verificador
            int soma = 0;
            for (int i = 0; i < 12; i++)
                soma += (cnpj[i] - '0') * multiplicadores1[i];

            int resto = soma % 11;
            int digito1 = (resto < 2) ? 0 : 11 - resto;

            // Verifica se o primeiro dígito verificador está correto
            if ((cnpj[12] - '0') != digito1)
                return false;

            // Calcula o segundo dígito verificador
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += (cnpj[i] - '0') * multiplicadores2[i];

            resto = soma % 11;
            int digito2 = (resto < 2) ? 0 : 11 - resto;

            // Verifica se o segundo dígito verificador está correto
            if ((cnpj[13] - '0') != digito2)
                return false;

            // CNPJ válido
            return true;
        }
    }
}
