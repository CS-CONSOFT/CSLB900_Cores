using CSCore.Domain.CS_Models.CSICP_CG;
using CSLB900.MSTools.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG06X.CG061
{
    public class DtoCreateUpdateCG061 : IConverteParaEntidade<Osusr8dwCsicpCg061>
    {
        public long? Cg061Regramentoid { get; set; }

        public string? Cg061Estabid { get; set; }

        public Osusr8dwCsicpCg061 ToEntity(int tenant, string? _)
        {
            return new Osusr8dwCsicpCg061
            {
                TenantId = tenant,
                Cg061Regramentoid = Cg061Regramentoid,
                Cg061Estabid = Cg061Estabid
            };
        }
    }
}