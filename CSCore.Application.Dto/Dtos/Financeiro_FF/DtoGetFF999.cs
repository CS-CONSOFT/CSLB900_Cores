using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Financeiro_FF
{
    public class DtoGetFF999
    {
        public int TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Ff999IdControle { get; set; }

        public int? Ff999Parcela { get; set; }

        public DateTime? Ff999Datavencto { get; set; }

        public decimal? Ff999Valorparcela { get; set; }
    }
}
