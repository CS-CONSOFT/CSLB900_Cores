using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._01X
{
    public interface IGG019Repository : IRepositorioBase<CSICP_GG019>
    {
        Task<(IEnumerable<CSICP_GG019>, int)> GetListAsync(string Produto_ID, int tenant, int pageSize, int page);
        Task<CSICP_GG019?> GetByIdAsync(string id, string Produto_ID, int tenant);
    }
}
