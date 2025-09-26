using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.FF.Repository.FF04X.FF040;

namespace CSCore.Domain.Interfaces.FF._04X
{
    public interface IFF040Repository : IGetListBase<CSICP_FF040, PrmFiltrosFF040Repo>, IRepositorioBase<CSICP_FF040>
    {
        Task<CSICP_FF040?> GetByIdAsync(int InTenantID, long InIDFF040);
        Task<(List<CSICP_FF040>, int)> GetListAsync(int InTenantID, PrmFiltrosFF040Repo prm);  
    }
}
