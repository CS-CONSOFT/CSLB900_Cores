using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.CG.CG05X.CG054
{
    public interface ICG054Repository : IRepositorioBaseV2<Osusr8dwCsicpCg054>
    {
        Task<(List<Osusr8dwCsicpCg054>, int)> GetListAsync(
            int InTenantID,
            long InCG050ID,
            int InPageNumber,
            int InPageSize);
    }
}