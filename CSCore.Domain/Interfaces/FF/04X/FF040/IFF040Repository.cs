using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.FF.Repository.FF04X.FF040;
using Microsoft.EntityFrameworkCore;

namespace CSCore.Domain.Interfaces.FF._04X
{
    public interface IFF040Repository : IRepositorioBase<CSICP_FF040>
    {
        Task<CSICP_FF040?> GetByIdAsync(int InTenantID, long InIDFF040);
        Task<(List<CSICP_FF040>, int)> GetListAsync(int InTenantID, PrmFiltrosFF040Repo parametros);  
    }
}
