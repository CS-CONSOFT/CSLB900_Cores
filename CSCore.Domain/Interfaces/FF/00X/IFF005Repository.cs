using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.FF
{
    public interface IFF005Repository : IRepositorioBase<CSICP_FF005>
    {
        Task<(List<CSICP_FF005>, int)> GetListAsync(int tenant, string? filialId, int page, int pageSize);
        Task<CSICP_FF005?> GetByIdAsync(int tenant, string id);
    }
}
