using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF119;

namespace CSCore.Domain.Interfaces.FF._1XX
{
    public interface IFF119Repository : IRepositorioBase<CSICP_FF119>
    {
        Task<RepoDtoCSICP_FF119?> GetByIdAsync(int in_tenant, long in_ff119Id);
        Task<(List<RepoDtoCSICP_FF119>, int)> GetListAsync(int in_tenant, string in_ff112Id, int in_pageNumber, int in_pageSize);
    }
}
