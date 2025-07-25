namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB001Repository : IBaseCrud<CSICP_BB001>
    {
        Task<CSICP_BB001?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_BB001>> GetListAsync(int tenant, string? search, int? searchCode, bool? isActive);
        Task<CSICP_BB001> ChangeActive(CSICP_BB001 entity);
    }
}
