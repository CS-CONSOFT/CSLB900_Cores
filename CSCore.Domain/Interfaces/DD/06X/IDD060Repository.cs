using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.CS_Models.CSICP_DD.DD_40_60;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCore.Domain.Interfaces.DD._06X
{
    public interface IDD060Repository : IRepositorioBase<CSICP_DD060>
    {
        Task<(List<RepoDtoCSICP_DD060>, int)> GetListAsync(
            int in_tenant, string in_estabID, string in_dd040id, int in_page, int in_pageSize);    
    }
}
