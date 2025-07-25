namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB057Repository : IBaseCrud<CSICP_Bb057>
    {
        Task<CSICP_Bb057?> GetByIdAsync(long id, int tenant);
        Task<IEnumerable<CSICP_Bb057>> GetListAsync(int tenant);
        Task<IEnumerable<CSICP_Bb057>> GetListAsyncByBB055ID(int tenant, string bb055ID);

    }
}
