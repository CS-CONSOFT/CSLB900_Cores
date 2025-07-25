namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB029Repository : IBaseCrud<CSICP_Bb029>
    {
        Task<CSICP_Bb029?> GetByIdAsync(string id, int tenant);
        Task<CSICP_Bb029> ChangeActive(CSICP_Bb029 entity);
        Task<IEnumerable<CSICP_Bb029>> GetListAsync(int tenant, string? search, bool? isActive);
    }
}

