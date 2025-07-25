namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB064Repository : IBaseCrud<CSICP_Bb064>
    {
        Task<CSICP_Bb064?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Bb064>> GetListAsync(int tenant, string? search, bool? isActive);
        Task<CSICP_Bb064> ChangeActive(CSICP_Bb064 entity);
    }
}
