using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.FF._1XX
{
    public interface IFF108Repository : IRepositorioBase<CSICP_FF108>
    {
        Task<(List<CSICP_FF108>, int)> GetListAsync(int in_tenant, string in_ff105Id, int in_pageNumber, int in_pageSize);
    }
}
