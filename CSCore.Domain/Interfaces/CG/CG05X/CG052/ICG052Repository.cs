using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.CG.CG05X.CG052
{
    public interface ICG052Repository : IRepositorioBaseV2<Osusr8dwCsicpCg052>
    {
        Task<Osusr8dwCsicpCg052?> GetByIdAsync(int InTenantID, long InCG052ID);
        Task<(List<Osusr8dwCsicpCg052>, int)> GetListAsync(
            int InTenantID,
            string? InDescricao,
            int InPageNumber,
            int InPageSize);
    }
}