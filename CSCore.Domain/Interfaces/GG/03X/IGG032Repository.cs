using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_QueryFilters.GG032;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._03X
{

    public interface IGG032Repository : IRepositorioBase<CSICP_GG032>
    {
        Task<(IEnumerable<CSICP_GG032>, int)> GetListAsync(int tenant, int pageSize, int page,
             string? search,
             int? GG032Status_ID,
             int? codigo,
             DateTime DataInicial,
             DateTime DataFinal);
        Task<CSICP_GG032?> GetByIdAsync(int tenant, string id);

        Task CS_BloquearDesbloquearInventario(
            int tenant, string in_InventarioId, int in_csicp_gg032_Sta_Bloqueado_ID,
            int in_csicp_gg032_Sta_Solicitado_ID, int in_tipoAcaoInventario);

        Task CS_InventarioProcessar(
            int tenant,
            string in_InventarioId,
             int in_StID_GG032_Sta_Bloqueado_ID,
            int in_StID_GG032_Sta_Concluido_ID,
            int in_StID_GG028_EntSaida_Saida_ID,
            int in_StID_GG028_EntSaida_Entrada_ID,
            int in_StID_GG028_Nat_Inventario_ID);

        Task<string> CS_GeradorInventarioEmMassa(
            int in_tenantId,
            int in_StID_EntitiesGG001TAlmox_Virtual,
            bool isQtdZero,
            FiltroProdutoRequest request
            );
    }
}
