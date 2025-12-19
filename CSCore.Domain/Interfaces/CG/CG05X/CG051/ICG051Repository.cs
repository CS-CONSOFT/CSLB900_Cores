using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.CG.CG05X.CG051
{
    public interface ICG051Repository : IRepositorioBaseV2<Osusr8dwCsicpCg051>
    {
        Task<(List<Osusr8dwCsicpCg051>, int)> GetListAsync(
            int InTenantID,
            long InCG050ID,
            int InPageNumber,
            int InPageSize);
    }
}