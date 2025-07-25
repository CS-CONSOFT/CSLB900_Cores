using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._03X
{
    public interface IGG031Repository : IRepositorioBase<CSICP_GG031>
    {

        Task<(IEnumerable<RepoDto_CSICP_GG031>, int)> GetListAsync
            (int tenant,
            string in_gg030_id,
            string? codigo,
            int pageSize,
            int page);
        Task<RepoDto_CSICP_GG031?> GetByIdAsync(string id, int tenant);

        Task<bool> PossuiItens(string in_produtoId, string in_gg030Id, string in_kardexId, int tenant);

        Task<bool> ProcessaAjustePreco(
            string movimentoId,
            int tenantId,
            int in_StID_Gg030Status_Solicitado,
            int in_StID_Gg023_Val_Venda,
            int in_StID_Gg023_Val_CustoReal,
            int in_StID_Gg023_Val_Custo,
            int in_StID_Gg023_Val_Reposicao,
            int in_StID_Gg023_Val_CustoMedio,
            int in_StID_Gg023_Val_ECommmerce,
            int in_StID_Gg030_Atendido
            );

    }
}
