

using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.AA;

public interface IAA007Repository : IRepositorioBase<CSICP_Aa007>
{
    Task<CSICP_Aa007?> GetByIdAsync(long id, int tenant);
    Task<IEnumerable<CSICP_Aa007>> GetListAsync(int tenant, string? search, bool? isActive);

    Task<CSICP_Aa007> ChangeActive(CSICP_Aa007 entity);
}

