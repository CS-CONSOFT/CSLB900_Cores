using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Ifs.Compartilhado.Utilidade.Sankhya
{
    public static class Abreviacoes
    {
        public static readonly Dictionary<string, string> ABREVIACOES = new(StringComparer.OrdinalIgnoreCase)
        {
            // Rua
            { "R", "Rua" }, { "R.", "Rua" }, { "RUA", "Rua" },

            // Avenida
            { "Av", "Avenida" }, { "Av.", "Avenida" }, { "A", "Avenida" },

            // Travessa
            { "Trav", "Travessa" }, { "Trav.", "Travessa" }, { "TV", "Travessa" }, { "TV.", "Travessa" }, { "TVs", "Travessa" },

            // Outros tipos
            { "Al", "Alameda" }, { "Al.", "Alameda" }, { "ALA", "Alameda" }, { "ALAMEDA", "Alameda" },
            { "Pç", "Praça" }, { "Pç.", "Praça" },
            { "Rod", "Rodovia" }, { "Rod.", "Rodovia" },
            { "Est", "Estrada" }, { "Est.", "Estrada" },
            { "Jd", "Jardim" }, { "Jd.", "Jardim" },
            { "Vl", "Vila" }, { "Vl.", "Vila" },
            { "Baln", "Balneário" }, { "Baln.", "Balneário" },
            { "Conj", "Conjunto" }, { "Conj.", "Conjunto" },
            { "Res", "Residencial" }, { "Res.", "Residencial" },
            { "Cond", "Condomínio" }, { "Cond.", "Condomínio" },
            { "Pq", "Parque" }, { "Pq.", "Parque" },
            { "St", "Setor" }, { "St.", "Setor" },
            { "Lot", "Loteamento" }, 
            { "Lot.", "Loteamento" },
            { "Bec", "Beco" },
        };

        public static List<string> BuscarAbreviacoes(string nomeCompleto)
        {
            return ABREVIACOES
                .Where(kv => kv.Key.Equals(nomeCompleto, StringComparison.OrdinalIgnoreCase))
                .Select(kv => kv.Key)
                .ToList();
        }

        public static string NormalizeAbbr(string s)
        {
            return s.Replace(".", "").Trim().ToUpper();
        }
    }
}
