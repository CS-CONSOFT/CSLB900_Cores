namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB028Repository : IBaseCrud<CSICP_Bb028>
    {
        Task<CSICP_Bb028?> GetByIdAsync(string id, int tenant);
        Task<CSICP_Bb028> ChangeActive(CSICP_Bb028 entity);
        Task<IEnumerable<CSICP_Bb028>> GetListAsync(int tenant, string? search, int? searchCode, bool? isActive);
    }
}
