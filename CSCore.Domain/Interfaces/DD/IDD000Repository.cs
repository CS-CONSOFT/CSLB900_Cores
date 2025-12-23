using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.CS_Models.CSICP_FF;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Domain.Interfaces.DD
{
    public interface IDD000Repository : IRepositorioBase<CSICP_DD000>
    {
        Task<CSICP_DD000?> GetByIdAsync(string InDD000ID, int InTenantID);
        Task<(List<CSICP_DD000>, int)> GetListAsync(int InTenantID, string? InEstabID, int InPageNumber, int InPageSize);

    }
}