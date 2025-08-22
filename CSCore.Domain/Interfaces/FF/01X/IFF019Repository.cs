using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.FF._01X
{
    public interface IFF019Repository : IRepositorioBase<CSICP_FF019>
    {
        Task<(List<CSICP_FF019>, int)> GetListAsync(int in_tenant, string? in_estabId, int in_pageNumber, int in_pageSize);
        Task<CSICP_FF019?> GetByIdAsync(int in_tenant, string in_ff019Id);
    }
}
