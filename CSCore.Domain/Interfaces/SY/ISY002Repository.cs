using CSCore.Domain.CS_Models.CSICP_SYS;

namespace CSCore.Domain.Interfaces.SY;

public interface ISY002Repository : IBaseCrud<Csicp_Sy002>
{
    Task<Csicp_Sy002> GetByIdAsync(string id, int tenant);
    Task<IEnumerable<Csicp_Sy002>> GetListAsync(int tenant, string? search);
    Task<IEnumerable<Csicp_Sy003Regra>> GetListSY003Async(string? search);
    Task<IReadOnlyCollection<object>> GetComboSY002(int tenant);
    Task<IReadOnlyCollection<object>> GetComboSY003();
}

