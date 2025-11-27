using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Domain.Interfaces.CG.CG08X.CG080
{
    public interface ICG080Repository : IRepositorioBaseV2<Osusr8dwCsicpCg080>
    {
        Task<Osusr8dwCsicpCg080?> GetByIdAsync(int InTenantID, long InCG080ID);
        Task<(List<Osusr8dwCsicpCg080>, int)> GetListAsync(int InTenantID, string? InNome, int InPageNumber, int InPageSize);
    }
}