using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG05X.CG055
{
    public class DtoGetCG055Padrao
    {
        public int TenantId { get; set; }

        public long Cg055Id { get; set; }

        public string? Cg055Txcodigo { get; set; }

        public string? Cg055Txdescricao { get; set; }

        public int? Cg055Moduloid { get; set; }
    }
}
