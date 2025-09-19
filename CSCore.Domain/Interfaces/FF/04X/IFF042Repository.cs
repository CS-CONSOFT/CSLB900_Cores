using CSCore.Domain.CS_Models.CSICP_FF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.FF._04X
{
    public interface IFF042Repository
    {
        Task<(List<CSICP_FF042>, int)> GetListAsync(int InTenantID, int InPageNumber, int InPageSize);
    }
}
