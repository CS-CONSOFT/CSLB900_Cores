using CSCore.Domain.CS_Models.CSICP_CG;
using CSLB900.MSTools.InterfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Application.Dto.Dtos.CG.CG06X.CG063
{
    public class DtoCreateUpdateCG063 : IConverteParaEntidade<Osusr8dwCsicpCg063>
    {
        public long? Cg063Regramentoid { get; set; }

        public string? Cg063Parametroid { get; set; }

        public long? Cg063Eventopartpid { get; set; }

        public Osusr8dwCsicpCg063 ToEntity(int tenant, string? _)
        {
            return new Osusr8dwCsicpCg063
            {
                TenantId = tenant,
                Cg063Regramentoid = Cg063Regramentoid,
                Cg063Parametroid = Cg063Parametroid,
                Cg063Eventopartpid = Cg063Eventopartpid
            };
        }
    }
}