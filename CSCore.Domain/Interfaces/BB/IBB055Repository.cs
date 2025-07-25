namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB055Repository : IBaseCrud<CSICP_Bb055>
    {
        Task<CSICP_Bb055?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Bb055>> GetListAsync(int tenant, string? search, bool? isActive);
        Task<CSICP_Bb055> ChangeActive(CSICP_Bb055 entity);
    }
}

