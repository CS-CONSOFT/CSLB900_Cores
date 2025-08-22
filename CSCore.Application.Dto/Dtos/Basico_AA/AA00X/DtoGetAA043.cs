using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.Basico_AA.AA00X
{
    public class DtoGetAA043
    {
        public int? TenantId { get; set; }

        public string Id { get; set; } = null!;

        public string? Aa043Artigo { get; set; }

        public string? Aa043LcRedacao { get; set; }

        public string? Aa043Ec { get; set; }
    }
}
