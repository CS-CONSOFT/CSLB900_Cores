using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_QueryFilters.Specific;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG.Saldo
{
    public interface IGG520Repository : IRepositorioBase<CSICP_GG520>
    {
        Task<(IEnumerable<CSICP_GG520>, int)> GetListAsync(
            string Produto_ID, string Kardex_ID, int tenant, int pageSize, int page, bool isActive);

        Task<IEnumerable<CSICP_GG520>> GetListaSaldoPorKardex(
           string Kardex_ID, int tenant);

        Task<IEnumerable<CSICP_GG520>> GetListParaProdutosComKardexESaldos(
          string Kardex_ID, int tenant);

        Task<(IEnumerable<CSICP_GG520>, IEnumerable<CSICP_GG520>)> PesquisProdutoPorCodigo(
            int tenant, string almoxID, string? in_almoxIDSaida, string estabID, int codBarra);


        Task<CSICP_GG520?> GetByIdAsync
            (string gg520_saldoID, int tenant);
        Task<string> GeraSaldo(GG520GeraSaldoParametros gG520GeraSaldoParametros);
        Task<CSICP_GG520> GeraSaldoSemCommit(GG520GeraSaldoParametros gG520GeraSaldoParametros);
        Task<IEnumerable<CSICP_GG520>> GetListSaldosCandidatos(int tenant, string? kardexId, string? almoxId, string? gg520Id_master);
    }
}
