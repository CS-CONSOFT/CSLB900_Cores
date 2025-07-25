namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB056Repository : IBaseCrud<CSICP_Bb056>
    {
        Task<CSICP_Bb056?> GetByIdAsync(long id, int tenant);
        Task<IEnumerable<CSICP_Bb056>> GetListAsync(int tenant, string? search, bool? isActive);
        Task<IEnumerable<CSICP_Bb056>> GetListAsyncByBB055ID(int tenant, string bb055ID);
        Task<CSICP_Bb056> ChangeActive(CSICP_Bb056 entity);
    }
}
