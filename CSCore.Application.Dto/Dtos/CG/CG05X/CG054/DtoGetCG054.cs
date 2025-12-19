using CSCore.Application.Dto.Dtos.CG.CG05X.CG050;
using CSCore.Application.Dto.Dtos.CG.CG05X.CG055;
using CSCore.Domain.CS_Models.CSICP_CG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG05X.CG054
{
    public class DtoGetCG054
    {
        public int TenantId { get; set; }

        public long Cg054Id { get; set; }

        public long? Cg054Eventotpid { get; set; }

        public long? Cg054Valortpid { get; set; }

        public DtoGetCG050Padrao? NavCG050TipoEvento_CG054 { get; set; }
        public DtoGetCG055Padrao? NavCG055ValorEvento_CG054 { get; set; }
    }
}
