using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG00X.CG005
{
    public class DtoGetCG005Padrao
    {
        public int TenantId { get; set; }

        public string Cg005Id { get; set; } = null!;

        public string? Cg005FilialId { get; set; }

        public int? Cg005Codigo { get; set; }

        public string? Cg005Historico { get; set; }

        public string? Cg005Historicoresumido { get; set; }

        public bool? Cg005Isactive { get; set; }
    }
}
