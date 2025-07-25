namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB037Repository : IBaseCrud<CSICP_Bb037>
    {
        Task<CSICP_Bb037?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Bb037>> GetListAsync(int tenant, string? search, int? searchCode, bool? isActive);
        Task<CSICP_Bb037> ChangeActive(CSICP_Bb037 entity);
    }
}

