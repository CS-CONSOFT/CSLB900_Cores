using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG00X.CG004
{
    public class DtoGetCG004Padrao
    {
        public int TenantId { get; set; }

        public string Cg004Id { get; set; } = null!;

        public string? Cg004FilialId { get; set; }

        public int? Cg004Codigo { get; set; }

        public string? Cg004Descricao { get; set; }

        public int? Cg004TipoId { get; set; }

        public bool? Cg004Isactive { get; set; }
    }
}
