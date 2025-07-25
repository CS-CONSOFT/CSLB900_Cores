using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSCore.Domain.CS_Models.CSICP_DD.CSICP_DD040;
using static CSCore.Domain.CS_Models.CSICP_DD.CSICP_DD042;
using static CSCore.Domain.CS_Models.CSICP_FF.CSICP_FF102;

namespace CSCore.Domain.Interfaces.DD._04X
{
    public interface IDD040Repository : IRepositorioBase<CSICP_DD040>
    {
        Task<RepoDtoCSICP_DD040?> GetByIdAsync(int in_tenant, string in_dd040Id);
        Task<List<RepoCSICP_DD042>> GetListAsyncDD042(int in_tenant, string in_dd040Id);

        Task<List<CSICP_DD044>> GetListAsyncDD044InfoAdicionais(int in_tenant, string in_dd040Id);
        Task<List<CSICP_DD045>> GetListAsyncDD045Observacoes(int in_tenant, string in_dd040Id);
        Task<List<CSICP_DD048>> GetListAsyncDD048NotasReferenciadas(int in_tenant, string in_dd040Id);
        Task<List<CSICP_BB001_AXML>> GetListAsyncBB001AXML(int in_tenant, string? in_bb001Id);

    }
}
