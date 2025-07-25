namespace CSCore.Domain.Interfaces.BB
{
    public interface IBB065Repository : IBaseCrud<CSICP_Bb065>
    {
        Task<CSICP_Bb065?> GetByIdAsync(string id, int tenant);
        Task<IEnumerable<CSICP_Bb065>> GetListAsync(int tenant);
        Task<IEnumerable<CSICP_Bb065>> GetListAsyncPorBB064id(long bb064ID, int tenant);
        Task AtualizaFxEtaria(
            int in_tenant,
            long in_bb064_ID,
            int in_StId_csicp_bb061_tp_Titular,
            int in_StId_csicp_bb061_tp_Dependente
            );
    }
}
