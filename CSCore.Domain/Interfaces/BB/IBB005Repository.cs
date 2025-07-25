namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB005Repository : IBaseCrud<CSICP_Bb005>
    {
        Task<CSICP_Bb005?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Bb005>> GetListAsync(int tenant, string? search, int? searchCode, bool? isActive);
        Task<CSICP_Bb005> ChangeActive(CSICP_Bb005 entity);
    }
}
