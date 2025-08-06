using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF106;

namespace CSCore.Domain.Interfaces.FF._1XX
{
    public interface IFF106Repository : IRepositorioBase<CSICP_FF106>
    {
        Task<(List<RepoDtoCSICP_FF106>, int)> GetListAsync(int in_tenant, string in_ff105ID, int in_page, int in_pageSize);
    }
}
