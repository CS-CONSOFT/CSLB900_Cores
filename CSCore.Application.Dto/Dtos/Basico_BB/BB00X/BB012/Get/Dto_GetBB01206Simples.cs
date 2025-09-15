using CSBS101._82Application.Dto.AA00X;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Basico_BB.BB00X.BB012.Get
{
    public class Dto_GetBB01206Simples
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Bb012Id { get; set; }

        public string? Bb012jEnderecoid { get; set; }

        public string? Bb012Logradouro { get; set; }

        public string? Bb012Numero { get; set; }

        public string? Bb012Complemento { get; set; }

        public string? Bb012Codgbairro { get; set; }

        public string? Bb012Bairro { get; set; }
        public string? Cidade_Aa028Cidade { get; set; }
        public string? UF_Aa027Sigla { get; set; }

        public string? UF_Descricao { get; set; }
        public int? Pais_Aa025Codigopais { get; set; }

        public string? Pais_Aa025Descricao { get; set; }


    }
}
