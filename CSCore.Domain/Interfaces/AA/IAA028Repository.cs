namespace CSCore.Domain.Interfaces.AA
{
    public interface IAA028Repository : IBaseCrud<CSICP_Aa028>
    {
        Task<CSICP_Aa028?> GetByIdAsync(string id, int tenant);
        Task<CSICP_Aa028?> GetByLocalidadeEUfIdAsync(string ufId, string localidade, int tenant);
        Task<IEnumerable<CSICP_Aa028>> GetListAsync(int tenant, string? search, string? ufId);
    }
}
