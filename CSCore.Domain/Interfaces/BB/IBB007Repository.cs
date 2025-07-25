namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB007Repository : IBaseCrud<CSICP_BB007>
    {
        Task<CSICP_BB007?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_BB007>> GetListAsync(int tenant, string? search, int? searchCode, bool? isActive);
        Task<CSICP_BB007> ChangeActive(CSICP_BB007 entity);
    }
}
