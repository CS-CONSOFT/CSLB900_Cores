using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.DD
{
    public interface IDD810Repository : IBaseCrud<CSICP_DD810>
    {
        Task<CSICP_DD810?> GetByIdAsync(string InDD810ID, int InTenantID);
        Task<(List<CSICP_DD810>, int)> GetListAsync(int InTenantID, int InPageNumber, int InPageSize);
        Task<string?> GetCfopCodigoByCfopId(int cfopId);
    }
}