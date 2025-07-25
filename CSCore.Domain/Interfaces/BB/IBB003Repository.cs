namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB003Repository : IBaseCrud<CSICP_Bb003>
    {
        Task<CSICP_Bb003?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Bb003>> GetListAsync(int tenant, string? search);
    }
}
