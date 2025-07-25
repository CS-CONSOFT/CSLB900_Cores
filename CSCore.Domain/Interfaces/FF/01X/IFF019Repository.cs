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
        Task<(List<CSICP_FF019>, int)> GetListAsync(int tenant, string? estabelecimentoId, int page, int pageSize);
        Task<CSICP_FF019?> GetByIdAsync(int tenant, string id);
    }
}
