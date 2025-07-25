namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB032Repository : IBaseCrud<CSICP_Bb032>
    {
        Task<CSICP_Bb032?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Bb032>> GetListAsync(int tenant, string? search, int? searchCode, bool? isActive);
        Task<CSICP_Bb032> ChangeActive(CSICP_Bb032 entity);
    }
}
