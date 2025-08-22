using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.FF
{
    public interface IFF999Repository : IRepositorioBase<CSICP_FF999>
    {
        Task<(List<CSICP_FF999>, int)> GetListAsync(int in_tenant, string in_ff017Id, int in_page, int in_pageSize);

    }
}
