using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._07X
{
    public interface IGG072Repository : IRepositorioBase<CSICP_GG072>
    {
        Task<(IEnumerable<CSICP_GG072>, int)> GetListAsync(int tenant, int pageSize, int page);
        Task<CSICP_GG072?> GetByIdAsync(int tenant, long id);
    }
}
