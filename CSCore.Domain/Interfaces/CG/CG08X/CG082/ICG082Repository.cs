using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.CG.CG08X.CG082
{
    public interface ICG082Repository : IRepositorioBase<Osusr8dwCsicpCg082>
    {
        Task<(List<Osusr8dwCsicpCg082>, int)> GetListAsync(int InTenantID, long InCG081ID, int InPageNumber, int InPageSize);
    }
}
