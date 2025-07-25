namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB008Repository : IBaseCrud<CSICP_Bb008>
    {
        Task<CSICP_Bb008?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Bb008>> GetListAsync(int tenant, string? search, int? searchCode, bool? isActive);
        Task<CSICP_Bb008> ChangeActive(CSICP_Bb008 entity);
    }
}

