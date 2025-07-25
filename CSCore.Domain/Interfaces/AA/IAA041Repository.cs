namespace CSCore.Domain.Interfaces.AA
{
    public interface IAA041Repository : IBaseCrud<CSICP_Aa041>
    {
        Task<CSICP_Aa041?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Aa041>> GetListAsync(int tenant, string? search, int? searchCode);
    }
}
