namespace CSCore.Domain.Interfaces.AA;
public interface IAA006Repository : IBaseCrud<CSICP_AA006>
{
    Task<CSICP_AA006?> GetByIdAsync(string id, int tenant);
    Task<IEnumerable<CSICP_AA006>> GetListAsync(int tenant, string? search);
}

