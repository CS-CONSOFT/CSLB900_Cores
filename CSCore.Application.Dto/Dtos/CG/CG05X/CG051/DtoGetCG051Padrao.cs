using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG05X.CG051
{
    public class DtoGetCG051Padrao
    {
        public int TenantId { get; set; }

        public long Cg051Id { get; set; }

        public long? Cg051Eventotpid { get; set; }

        public long? Cg051Parametrotpid { get; set; }

        public bool? Flobrigatorio { get; set; }
    }
}
