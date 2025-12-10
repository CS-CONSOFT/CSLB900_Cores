using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.CG.CG00X.CG003;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.CG.CG00X.CG003
{
    public interface ICG003Repository : IGetListBase<CSICP_CG003, PrmFiltrosCG003Repo>, IRepositorioBaseV2<CSICP_CG003>
    {
        Task<CSICP_CG003?> GetByIdAsync(int InTenantID, string InIDCG003);
        Task<(List<CSICP_CG003>, int)> GetListAsync(int InTenantID, PrmFiltrosCG003Repo prm);
    }
}