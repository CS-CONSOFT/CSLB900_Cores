namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB027Repository : IBaseCrud<CSICP_Bb027>
    {
        Task<CSICP_Bb027?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Bb027>> GetListAsync(int tenant, string? search, int? searchCode, int? regimeId);
    }
}
