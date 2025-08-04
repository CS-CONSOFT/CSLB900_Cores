using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF.FF1XX.FF114
{
    public class DtoGetFF114
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Ff114Refconfigbanco { get; set; }

        public decimal? Ff114Lote { get; set; }

        public int? Ff114Ordem { get; set; }

        public string? Ff114Linha240 { get; set; }

        public string? Ff114Linha400 { get; set; }

        public string? Ff114Idcontrole { get; set; }
    }
}
