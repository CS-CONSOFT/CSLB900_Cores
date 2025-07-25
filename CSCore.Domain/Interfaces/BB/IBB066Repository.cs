namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB066Repository : IBaseCrud<CSICP_Bb066>
    {
        Task<CSICP_Bb066?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Bb066>> GetListAsync(int tenant);
        Task<IEnumerable<CSICP_Bb066>> GetListAsyncByBB064ID(long bb064ID, int tenant);
    }
}

