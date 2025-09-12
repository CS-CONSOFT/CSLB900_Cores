using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF007;

namespace CSCore.Domain.Interfaces.FF
{
    public interface IFF007Repository : IRepositorioBase<CSICP_FF007>
    {
        Task<(List<CSICP_FF007>, int)> GetListAsync(int tenant, string? estabelecimentoId, int page, int pageSize);
        Task<CSICP_FF007?> GetByIdAsync(int tenant, long id);
    }
}
