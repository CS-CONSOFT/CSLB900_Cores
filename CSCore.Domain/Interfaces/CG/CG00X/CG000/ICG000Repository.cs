using CSCore.Domain.CS_Models.CSICP_CG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.CG.CG00X.CG000
{
    public interface ICG000Repository
    {
        Task<CSICP_CG000?> GetByIdAsync(int InTenant, string InIDCG000);
        Task<(IEnumerable<CSICP_CG000>, int)> GetListAsync(int InTenant, int InPageNumber, int InPageSize);
    }
}
