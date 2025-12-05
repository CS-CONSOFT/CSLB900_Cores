using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.CG.CG05X.CG055
{
    public interface ICG055Repository : IRepositorioBaseV2<Osusr8dwCsicpCg055>
    {
        Task<Osusr8dwCsicpCg055?> GetByIdAsync(int InTenantID, long InCG055ID);
        Task<(List<Osusr8dwCsicpCg055>, int)> GetListAsync(
            int InTenantID,
            int InPageNumber,
            int InPageSize);
    }
}