namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB002Repository : IBaseCrud<CSICP_BB002>
    {
        Task<CSICP_BB002?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_BB002>> GetListAsync(int tenant, string? search, int? searchCode);
    }
}
