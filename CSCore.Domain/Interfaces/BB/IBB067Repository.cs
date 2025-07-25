namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB067Repository : IBaseCrud<CSICP_Bb067>
    {
        Task<CSICP_Bb067?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Bb067>> GetListAsync(int tenant, string? search);
    }
}
