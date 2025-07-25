using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._01X
{
    public interface IGG028Repository : IRepositorioBase<CSICP_GG028>
    {
        Task<(IEnumerable<RepoGetCSICP_GG028>, int)> GetListAsync(int tenant, int pageSize, int page, string saldoID,
            DateTime DataMovimentoInicial,
            DateTime DataMovimentoFinal);
        Task<RepoGetCSICP_GG028?> GetByIdAsync(string id, int tenant);

        /// <summary>
        /// Retorna uma lista de CSICP_GG028Tree com base no tenant.
        /// </summary>
        /// <returns>
        /// <params>IEnumerable<CSICP_GG028Tree> É a lista paginada</params>
        /// </returns>
        Task<IEnumerable<RepoDtoExtrato>> GetListTreeAsync(int in_tenant, string in_doc_id, string? in_kardex_id);
    }
}
