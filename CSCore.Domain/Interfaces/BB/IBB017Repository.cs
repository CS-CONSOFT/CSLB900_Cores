namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB017Repository : IBaseCrud<CSICP_Bb017>
    {
        Task<CSICP_Bb017?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Bb017>> GetListByFormaPagtoIdAsync(string fPagtoId, int tenant);
        Task<IEnumerable<CSICP_Bb017>> GetListByCondicaoIdAsync(string condicaoId, int tenant);
        Task<IEnumerable<CSICP_Bb017>> GetListAsync(int tenant, string? in_CondicaoPagamentoID, string? in_FormaPagamentoID);
    }
}
