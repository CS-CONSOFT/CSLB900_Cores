namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB025Repository : IBaseCrud<CSICP_Bb025>
    {
        Task<CSICP_Bb025?> GetByIdAsync(string id, int tenant);
        Task<CSICP_Bb025> ChangeActive(CSICP_Bb025 entity);
        Task<IEnumerable<CSICP_Bb025>> GetListAsync(int tenant, string? search, int? searchCode, bool? isActive);
    }
}
