namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB013Repository : IBaseCrud<CSICP_Bb013>
    {
        Task<CSICP_Bb013?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Bb013>> GetListAsync(int tenant, string? search, int? searchCode);
    }
}
