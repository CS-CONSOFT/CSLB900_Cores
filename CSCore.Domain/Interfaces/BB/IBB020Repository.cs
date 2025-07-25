namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB020Repository : IBaseCrud<CSICP_Bb020>
    {
        Task<CSICP_Bb020?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Bb020>> GetListAsync(int tenant);
        Task<IEnumerable<CSICP_Bb020>> GetListByFormaPagtoIdAsync(string fPagtoId, int tenant);
        Task<IEnumerable<CSICP_Bb020>> GetListTaxaCartaoAdmList(int tenant, string BB019id);
    }
}
