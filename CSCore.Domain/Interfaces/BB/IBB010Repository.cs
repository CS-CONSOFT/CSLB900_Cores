namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB010Repository : IBaseCrud<CSICP_Bb010>
    {
        Task<CSICP_Bb010?> GetByIdAsync(string id, int tenant);
        Task<CSICP_Bb010> ChangeActive(CSICP_Bb010 entity);
        Task<IEnumerable<CSICP_Bb010>> GetListAsync(int tenant, string? search, bool? isActive);
    }
}
