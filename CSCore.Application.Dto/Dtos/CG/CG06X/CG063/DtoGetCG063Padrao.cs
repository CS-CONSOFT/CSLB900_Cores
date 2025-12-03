using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG06X.CG063
{
    public class DtoGetCG063Padrao
    {
        public int TenantId { get; set; }

        public long Cg063Id { get; set; }

        public long? Cg063Regramentoid { get; set; }

        public string? Cg063Parametroid { get; set; }

        public long? Cg063Eventopartpid { get; set; }
    }
}
