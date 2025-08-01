using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.FF._1XX
{
    public interface IFF114Repository : IRepositorioBase<CSICP_FF114>
    {
        Task<(List<CSICP_FF114>, int)> GetListAsync(int in_tenant, string in_ff113Id, int in_page, int in_pageSize);
    }
}
