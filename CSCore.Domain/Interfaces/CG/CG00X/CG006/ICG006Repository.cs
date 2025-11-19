using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Domain.Interfaces.CG.CG00X.CG006
{
    public interface ICG006Repository : IRepositorioBase<CSICP_CG006>
    {
        Task<CSICP_CG006?> GetByIdAsync(int InTenantID, string InCG006ID);
        Task<(List<CSICP_CG006>, int)> GetListAsync(int InTenantID, PrmFiltrosCG006Repo prm);
    }
}