namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB028bRepository : IBaseCrud<CSICP_Bb028b>
    {
        Task<CSICP_Bb028b?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Bb028b>> GetListAsync(int tenant, int? searchCode);
        Task<IEnumerable<CSICP_Bb028b>> GetListAsyncByBB028(int tenant, string BB028CompradorID);
    }
}
