using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF112Faixa
{
    public class DtoGetFF112Faixa
    {
        public int TenantId { get; set; }

        public string Ff112FaixaId { get; set; } = null!;

        public string? Ff112Id { get; set; }

        public decimal? Ff112NossonroInicial { get; set; }

        public decimal? Ff112NossonroFinal { get; set; }

        public decimal? Ff112NossonroAtual { get; set; }

        public decimal? Ff112Avisonossonro { get; set; }

        public bool? Ff112Isactive { get; set; }
    }
}

