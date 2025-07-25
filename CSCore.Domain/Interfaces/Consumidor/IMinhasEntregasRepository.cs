using CSCore.Domain.CS_Models.CSICP_DD;

namespace CSCore.Domain.Interfaces.Consumidor
{
    public interface IMinhasEntregasRepository
    {
        Task<List<CSICP_DD101>> GetList_MinhasEntregas(string bb012_contaID, int tenant_id, int page,
            int pageSize);
    }
}
