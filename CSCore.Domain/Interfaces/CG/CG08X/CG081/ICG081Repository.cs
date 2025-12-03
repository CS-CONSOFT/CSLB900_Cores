using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Domain.Interfaces.CG.CG08X.CG081
{
    public interface ICG081Repository : IRepositorioBaseV2<Osusr8dwCsicpCg081>
    {
        Task<Osusr8dwCsicpCg081?> GetByIdAsync(int InTenantID, long InCG081ID);
        Task<(List<Osusr8dwCsicpCg081>, int)> GetListAsync(int InTenantID, long InCG080ID, int InPageNumber, int InPageSize);
    }
}