namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB004Repository : IBaseCrud<CSICP_BB004>
    {
        Task<CSICP_BB004?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_BB004>> GetListAsync(int tenant, int? searchCode);
    }
}
