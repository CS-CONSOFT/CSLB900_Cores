namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB006Repository : IBaseCrud<CSICP_Bb006>
    {
        Task<CSICP_Bb006?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Bb006>> GetListAsync(int tenant, string? search, int? searchCode, bool? isActive);
        Task<CSICP_Bb006> ChangeActive(CSICP_Bb006 entity);
    }
}
