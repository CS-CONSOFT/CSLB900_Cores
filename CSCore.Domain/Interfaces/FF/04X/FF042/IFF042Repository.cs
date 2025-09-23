using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.FF._04X.FF042;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.FF._04X
{
    public interface IFF042Repository : IGetListBase<CSICP_FF042, PrmFiltrosFF042Repo>
    {
        Task<(List<CSICP_FF042>, int)> GetListAsync(int InTenantID, PrmFiltrosFF042Repo prm);
    }
}
