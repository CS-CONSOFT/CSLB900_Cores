using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLB900.MSTools.Util
{
    public static class StringUtils
    {
        /// <summary>
        /// Remove acentos de uma string, retornando apenas os caracteres sem marcações.
        /// </summary>
        /// <param name="texto">Texto de entrada possivelmente com acentos.</param>
        /// <returns>Texto sem acentos.</returns>
        public static string RemoverAcentos(string texto)
        {
            if (texto == null) return "";
            // Normaliza o texto para decompor caracteres acentuados
            var normalized = texto.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();
            // Percorre cada caractere e adiciona apenas os que não são marcas de acentuação
            foreach (var c in normalized)
            {
                if (System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c) !=
                    System.Globalization.UnicodeCategory.NonSpacingMark)
                    sb.Append(c);
            }
            // Retorna o texto normalizado novamente para a forma composta
            return sb.ToString().Normalize(NormalizationForm.FormC);
        }

        /// <summary>
        /// Extrai o prefixo (tipo de logradouro) e o sufixo (restante do endereço) de um logradouro.
        /// </summary>
        /// <param name="logradouro">Nome completo do logradouro.</param>
        /// <returns>Tupla contendo o prefixo e o sufixo (sem acentos).</returns>
        public static (string prefixo, string sufixo) ExtrairPrefixoSufixoLogradouro(string logradouro)
        {
            // Retorna tupla vazia se o logradouro for nulo ou em branco
            if (string.IsNullOrWhiteSpace(logradouro)) return ("", "");

            // Lista de possíveis prefixos de logradouro, ignorando maiúsculas/minúsculas
            var prefixos = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "Rua", "R", "R.", "Avenida", "AVENIDA", "Av", "Av.", "AV.",
                "Travessa", "Trav", "Trav.", "Alameda", "Al", "Al.",
                "Praça", "Pç", "Pç.", "Rodovia", "Estrada", "Via", "Viela",
                "Vila", "Largo", "Passeio", "Beco","Bec", "Caminho", "Servidão",
                "Boulevard", "Blvd", "Marginal", "Esplanada", "Balneário",
                "Colônia", "Conjunto", "Distrito", "Estação", "Favela", "Feira",
                "Jardim", "Jd", "Jd.", "Ladeira", "Loteamento", "Morro", "Núcleo",
                "Parque", "Passagem", "Passarela", "Ponte", "Porto", "Projeção",
                "Quadra", "Ramal", "Recanto", "Residencial", "Setor", "Sítio",
                "Trav", "Trecho", "Trevo", "Vale", "Vereda", "Zona", "Complexo",
                "Condomínio", "Área", "Anel Rodoviário", "Desvio", "Contorno",
                "Reta", "Rodoanel", "Terminal", "Estradinha", "Alto", "Aclive",
                "Declive", "Encosta", "Vinculo", "Fazenda", "Outeiro", "Estrada", "Est"
            };

            // Divide o logradouro em partes separadas por espaço
            var partes = logradouro.Trim().Split(' ');
            if (partes.Length == 0) return ("", "");

            // Pega a primeira palavra do logradouro, colocando a primeira letra em maiúsculo
            var primeira = char.ToUpper(partes[0][0]) + partes[0].Substring(1);
            // Verifica se a primeira palavra é um prefixo conhecido
            if (prefixos.Contains(primeira))
            {
                // Se for prefixo, retorna o prefixo (em maiúsculo) e o restante do logradouro (sufixo) sem acentos
                var prefixo = primeira.ToUpper();
                var sufixoAcentuado = string.Join(" ", partes.Skip(1)).Trim().ToUpperInvariant();
                var sufixo = RemoverAcentos(sufixoAcentuado);
                return (prefixo, sufixo);
            }
            else
            {
                // Se não for prefixo, retorna prefixo vazio e o logradouro inteiro (sem acentos) como sufixo
                var sufixoAcentuado = logradouro.Trim().ToUpperInvariant();
                var sufixo = RemoverAcentos(sufixoAcentuado);
                return ("", sufixo);
            }
        }


        public static string RemoveCaracteresEspeciais(string? texto)
        {
            if (texto == "" || texto is null) return string.Empty;

            // Define os caracteres especiais a serem removidos
            var caracteresEspeciais = new[] { '.', ',', '\'', '"', '#', '-', '/', '\\' };

            var resultado = new StringBuilder(texto.Length);

            foreach (var c in texto)
            {
                if (!caracteresEspeciais.Contains(c) && !char.IsPunctuation(c))
                {
                    resultado.Append(c);
                }
            }

            return resultado.ToString();
        }

        public static string GeneratePassword(int length, bool alpha)
        {
            const string digits = "0123456789";
            const string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string chars = alpha ? digits + letters : digits;

            var password = new char[length];
            using var rng = System.Security.Cryptography.RandomNumberGenerator.Create();
            var data = new byte[length];

            rng.GetBytes(data);

            for (int i = 0; i < length; i++)
            {
                int idx = data[i] % chars.Length;
                password[i] = chars[idx];
            }

            return new string(password);
        }

        /// <summary>
        /// Formata uma data no padrão customizado, permitindo escolher o separador e o tamanho do ano.
        /// Exemplo: Para data 21/12/2012, separador "/" e tamanho do ano 4, retorna "21/12/2012".
        /// Para separador "" e tamanho do ano 2, retorna "211212".
        /// </summary>
        /// <param name="Prm_data">Data a ser formatada.</param>
        /// <param name="Prm_Separador">Separador entre dia, mês e ano (ex: "/", "-", "").</param>
        /// <param name="Prm_Tam_Ano">Tamanho do ano: 2 para "yy", 4 para "yyyy".</param>
        /// <returns>Data formatada conforme os parâme
        public static string FormatarDataCustom(DateTime Prm_data, string Prm_Separador, int Prm_Tam_Ano)
        {
        
            string dia = Prm_data.Day.ToString("D2");
            string mes = Prm_data.Month.ToString("D2");
            string ano = Prm_data.Year.ToString().PadLeft(Prm_Tam_Ano, '0');
            if (Prm_Tam_Ano == 2)
                ano = ano.Substring(ano.Length - 2, 2);

            return $"{dia}{Prm_Separador}{mes}{Prm_Separador}{ano}";
        }

        public static string FixaTamanhoValor(
        string? valor,
        int lengthMax,
        bool? isDecimal = false,
        string? constanteConcatenar = "0",
        bool? concatRight = false
    )
        {
            // Se o valor for nulo ou vazio, retorna "###"
            if (string.IsNullOrEmpty(valor))
                return "###";

            // Tratamento para decimal (opcional)
            if (isDecimal == true)
            {
                valor = valor.Replace(",", ".");
            }

            // Se o tamanho excede o máximo, corta
            if (valor.Length > lengthMax)
                valor = valor.Substring(0, lengthMax);
            // Se o tamanho é menor, concatena usando o caracter informado
            else if (valor.Length < lengthMax)
            {
                char padChar = !string.IsNullOrEmpty(constanteConcatenar) ? constanteConcatenar[0] : '0';

                if (concatRight == true)
                    valor = valor.PadRight(lengthMax, padChar);
                else
                    valor = valor.PadLeft(lengthMax, padChar);
            }

            return valor;
        }

    }
    }