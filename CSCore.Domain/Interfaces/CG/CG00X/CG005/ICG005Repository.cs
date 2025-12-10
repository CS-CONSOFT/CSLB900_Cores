using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Domain.Interfaces.CG.CG00X.CG005
{
    public interface ICG005Repository : IRepositorioBaseV2<CSICP_CG005>
    {
        Task<CSICP_CG005?> GetByIdAsync(int InTenantID, string InCG005ID);
        Task<(List<CSICP_CG005>, int)> GetListAsync(int InTenantID, PrmFiltrosCG005Repo prm);
    }
}