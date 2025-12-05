using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.CG.CG06X.CG060
{
    public interface ICG060Repository : IRepositorioBaseV2<Osusr8dwCsicpCg060>
    {
        Task<(List<Osusr8dwCsicpCg060>, int)> GetListAsync(int InTenantID, int InPageNumber, int InPageSize);
        Task<Osusr8dwCsicpCg060?> GetByIdAsync(int InTenantID, long InCG060ID);
    }
}