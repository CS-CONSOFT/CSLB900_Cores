namespace CSCore.Domain.Interfaces.AA
{
    public interface IAA025Repository : IBaseCrud<CSICP_Aa025>
    {
        Task<CSICP_Aa025?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Aa025>> GetListAsync(int tenant, string? search, int? searchCode);
        Task<CSICP_Aa025> ChangeActive(CSICP_Aa025 entity);
    }
}
