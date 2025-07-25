namespace CSCore.Domain.Interfaces.AA
{
    public interface IAA029Repository : IBaseCrud<CSICP_AA029>
    {
        Task<CSICP_AA029?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_AA029>> GetListAsync(int tenant, string? search, bool? isActive);
        Task<CSICP_AA029> ChangeActive(CSICP_AA029 entity);
    }
}