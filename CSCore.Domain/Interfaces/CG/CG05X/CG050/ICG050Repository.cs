using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.CG.CG05X.CG050
{
    public interface ICG050Repository : IRepositorioBaseV2<Osusr8dwCsicpCg050>
    {
        Task<Osusr8dwCsicpCg050?> GetByIdAsync(int InTenantID, long InCG050ID);
        Task<(List<Osusr8dwCsicpCg050>, int)> GetListAsync(
            int InTenantID,
            int InPageNumber,
            int InPageSize);
    }
}