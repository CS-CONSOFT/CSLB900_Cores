using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF006;

namespace CSCore.Domain.Interfaces.FF._00X
{
    public interface IFF006Repository : IRepositorioBase<CSICP_FF006>
    {
        Task<(List<CSICP_FF006>, int)> GetListAsync(int tenant, string ff102Id, int page, int pageSize);
        Task<CSICP_FF006?> GetByIdAsync(int tenant, long id);
    }
}
