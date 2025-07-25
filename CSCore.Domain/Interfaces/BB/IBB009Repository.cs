namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB009Repository : IBaseCrud<CSICP_Bb009>
    {
        Task<CSICP_Bb009?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Bb009>> GetListAsync(int tenant, string? search, int? searchCode, bool? isActive);
        Task<CSICP_Bb009> ChangeActive(CSICP_Bb009 entity);
    }
}
