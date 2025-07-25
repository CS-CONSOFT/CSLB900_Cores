namespace CSCore.Domain.Interfaces.AA
{
    public interface IAA027Repository : IBaseCrud<CSICP_Aa027>
    {
        Task<CSICP_Aa027?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Aa027>> GetListAsync(int tenant, string? search, string? paisId, string? regiaoId);
        Task<CSICP_Aa027?> GetByIdFilterBySigla(int tenant, string sigla);
    }
}