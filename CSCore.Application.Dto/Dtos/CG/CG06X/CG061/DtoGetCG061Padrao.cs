using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG06X.CG061
{
    public class DtoGetCG061Padrao
    {
        public int TenantId { get; set; }

        public long Cg061Id { get; set; }

        public long? Cg061Regramentoid { get; set; }

        public string? Cg061Estabid { get; set; }
    }
}
