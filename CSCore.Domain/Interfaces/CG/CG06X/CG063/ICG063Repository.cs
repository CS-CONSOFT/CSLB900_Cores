using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.CG.CG06X.CG063
{
    public interface ICG063Repository : IRepositorioBaseV2<Osusr8dwCsicpCg063>
    {
        Task<(List<Osusr8dwCsicpCg063>, int)> GetListAsync(int InTenantID, int InPageNumber, int InPageSize);
        Task<Osusr8dwCsicpCg063?> GetByIdAsync(int InTenantID, long InCG063ID);
    }
}