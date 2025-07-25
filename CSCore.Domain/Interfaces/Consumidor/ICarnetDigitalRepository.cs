using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.CS_Models.CSICP_FF;

namespace CSCore.Domain.Interfaces.Consumidor
{

    public interface ICarnetDigitalRepository
    {
        public Task<(IEnumerable<CSICP_FF102>, int count)> ListadeTituloByConta_ID(
            int tenantId,
            string bb012_contaID,
            int situacaoTitulo,
            int diasAteDataVencimento,
            int pageSize,
            int pageNumber);

        public Task<CSICP_FF102> TituloByConta_ID(
           int tenantId,
           string bb012_contaID,
           string tituloID,
           int situacaoTitulo,
           int diasAteDataVencimento);
        public Task Gera_Pix_Titulo(string bb012_contaID);
        public Task<List<CSICP_DD143Stum>> ConsultaStatus();

        Task<CSICP_BB001Img?> GetLogoEmpresa(string BB001_ID, int tenant);
    }
}
