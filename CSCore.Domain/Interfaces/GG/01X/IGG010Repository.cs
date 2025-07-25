using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.CS_QueryFilters;

namespace CSCore.Domain.Interfaces.GG._01X
{
    public interface IGG010Repository : IRepositorioBaseMudaAtivo<CSICP_GG010>
    {
        Task<(IEnumerable<CSICP_GG010>, int)> GetListAsync(int tenant,int pageSize, int page, string? search, string? codigo, bool isActive = true);
        Task<CSICP_GG010?> GetByIdAsync(string id, int tenant);
    }
}
