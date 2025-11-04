using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG008
{
    public class DtoGetCG008Padrao
    {
        public int TenantId { get; set; }

        public string Cg008Id { get; set; } = null!;

        public int? Cg008Cod { get; set; }

        public string? Cg008Descricao { get; set; }

        public string? Cg008Descresumida { get; set; }

        public bool? Cg008Isactive { get; set; }
    }
}
