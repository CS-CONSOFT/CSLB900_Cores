using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Domain.Interfaces.CG.CG00X.CG006
{
    public interface ICG006Repository : IRepositorioBase<Osusr8dwCsicpCg006>
    {
        Task<Osusr8dwCsicpCg006?> GetByIdAsync(int InTenantID, string InCG006ID);
        Task<(List<Osusr8dwCsicpCg006>, int)> GetListAsync(int InTenantID, PrmFiltrosCG006Repo prm);
    }
}