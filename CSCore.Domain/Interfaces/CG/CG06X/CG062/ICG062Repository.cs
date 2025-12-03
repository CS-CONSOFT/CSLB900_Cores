using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.CG.CG06X.CG062
{
    public interface ICG062Repository : IRepositorioBaseV2<Osusr8dwCsicpCg062>
    {
        Task<(List<Osusr8dwCsicpCg062>, int)> GetListAsync(int InTenantID, int InPageNumber, int InPageSize);
        Task<Osusr8dwCsicpCg062?> GetByIdAsync(int InTenantID, long InCG062ID);
    }
}