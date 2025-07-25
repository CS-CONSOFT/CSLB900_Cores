using CSCore.Domain.CS_Models.CSICP_DD;
using CSCore.Domain.CS_Models.CSICP_GG;

namespace CSCore.Domain.Interfaces.Consumidor
{
    public interface IMinhasComprasRepository
    {
        public Task<(List<CSICP_DD040>, List<CSICP_DD060>, List<CSICP_GG008c>)>
            Get_MinhasCompras(string bb012_contaID, int tenant_id);
        public Task Get_MinhasEntregas(string bb012_contaID);
    }
}
