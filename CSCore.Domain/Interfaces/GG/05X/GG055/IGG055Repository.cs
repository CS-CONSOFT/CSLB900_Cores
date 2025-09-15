using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.GG._05X.GG055;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.GG._05X
{
    public interface IGG055Repository
    {
        Task<(List<CSICP_GG055>, int)> GetListAsync(int InTenantID, PrmFiltrosGG055Repo parametros);
    }
}
