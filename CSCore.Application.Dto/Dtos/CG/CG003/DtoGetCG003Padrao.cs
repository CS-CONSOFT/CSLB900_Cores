using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG003
{
    public class DtoGetCG003Padrao
    {
        public int TenantId { get; set; }

        public string Cg003Id { get; set; } = null!;

        public string? Cg003FilialId { get; set; }

        public int? Cg003Codigo { get; set; }

        public string? Cg003Descricao { get; set; }

        public int? Cg003Natureza { get; set; }

        public bool? Cg003Isactive { get; set; }
    }
}
