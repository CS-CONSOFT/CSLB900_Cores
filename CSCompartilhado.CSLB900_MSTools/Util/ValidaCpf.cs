namespace CSLB900.MSTools.Util
{
    public static class ValidaCpf
    {
        public static bool CpfValido(decimal? cpfDecimal)
        {
            // Verifica se o valor é nulo ou negativo
            if (cpfDecimal == null || cpfDecimal < 0)
                return false;

            // Converte para string, remove decimais e preenche com zeros à esquerda para garantir 11 dígitos
            string cpf = ((long)cpfDecimal).ToString().PadLeft(11, '0');

            // O CPF deve conter exatamente 11 dígitos
            if (cpf.Length != 11)
                return false;

            // Verifica se todos os dígitos são iguais (CPFs assim são inválidos)
            if (cpf.Distinct().Count() == 1)
                return false;

            // Validação dos dois dígitos verificadores
            for (int j = 9; j < 11; j++)
            {
                int soma = 0;
                // Calcula a soma dos produtos dos dígitos pelos pesos decrescentes
                for (int i = 0; i < j; i++)
                    soma += (cpf[i] - '0') * (j + 1 - i);

                // Calcula o dígito verificador
                int digito = (soma * 10) % 11;
                if (digito == 10) digito = 0;

                // Verifica se o dígito calculado confere com o informado no CPF
                if (cpf[j] - '0' != digito)
                    return false;
            }

            // CPF válido
            return true;
        }


    }
}
