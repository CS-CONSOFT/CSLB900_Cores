using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.DD
{
    public interface IDD156Repository : IRepositorioBase<CSICP_DD156>
    {
        Task<CSICP_DD156?> GetByIdAsync(string id, int tenant);
        Task<(IEnumerable<CSICP_DD156>, int)> GetListAsync(int tenant, int pageSize, int page);
    }
}
