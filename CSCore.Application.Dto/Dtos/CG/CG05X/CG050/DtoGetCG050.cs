using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG05X.CG050
{
    public class DtoGetCG050
    {
        public int TenantId { get; set; }

        public long Cg050Id { get; set; }

        public string? Cg050Txcodigo { get; set; }

        public string? Cg050Txdescricao { get; set; }

        public int? Cg050Periodicidadeid { get; set; }

        public int? Cg050Moduloid { get; set; }

        public bool? Cg050Flonline { get; set; }

        public bool? Cg050Flencerramento { get; set; }

        public bool? Cg050Flperman { get; set; }

        public bool? Cg050Flperexc { get; set; }

        public bool? Cg050Isactive { get; set; }
    }
}
