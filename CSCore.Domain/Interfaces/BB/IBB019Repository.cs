namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB019Repository : IBaseCrud<CSICP_Bb019>
    {
        Task<CSICP_Bb019?> GetByIdAsync(string id, int tenant);
        Task<CSICP_Bb019> ChangeActive(CSICP_Bb019 entity);
        Task<IEnumerable<CSICP_Bb019>> GetListAsync(int tenant, string? search, int? searchCode, bool? isActive);
    }
}
