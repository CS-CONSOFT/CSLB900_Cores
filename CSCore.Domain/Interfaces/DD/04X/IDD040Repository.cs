using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.DD._04X
{
    public interface IDD040Repository : IRepositorioBase<CSICP_DD040>
    {
        Task<CSICP_DD040?> GetByIdAsync(int in_tenant, string in_dd040Id);
        Task<List<RepoCSICP_DD042>> GetListAsyncDD042(int in_tenant, string in_dd040Id);

        Task<List<CSICP_DD044>> GetListAsyncDD044InfoAdicionais(int in_tenant, string in_dd040Id);
        Task<List<CSICP_DD045>> GetListAsyncDD045Observacoes(int in_tenant, string in_dd040Id);
        Task<List<CSICP_DD048>> GetListAsyncDD048NotasReferenciadas(int in_tenant, string in_dd040Id);
        Task<List<CSICP_BB001_AXML>> GetListAsyncBB001AXML(int in_tenant, string? in_bb001Id);

    }
}
