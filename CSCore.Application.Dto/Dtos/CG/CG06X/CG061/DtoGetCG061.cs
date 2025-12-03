using CSBS101._82Application.Dto.BB00X.BB001;
using CSCore.Application.Dto.Dtos.CG.CG06X.CG060;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG06X.CG061
{
    public class DtoGetCG061
    {
        public int TenantId { get; set; }

        public long Cg061Id { get; set; }

        public long? Cg061Regramentoid { get; set; }

        public string? Cg061Estabid { get; set; }

        public DtoGetCG060Padrao? NavCG060RegramentoID_CG061 { get; set; }

        public Dto_GetBB001_Exibicao? NavBB001Estab_CG061 { get; set; }
    }
}