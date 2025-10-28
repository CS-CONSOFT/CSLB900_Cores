using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.NN.CSICP_NN015.Interface
{
    public interface INN015Repository : IRepositorioBase<Domain.CS_Models.CSICP_NN.CSICP_NN015>
    {
        Task<(IEnumerable<Domain.CS_Models.CSICP_NN.CSICP_NN015>, int)> GetListAsync(int tenant, int page, int pageSize);

        Task<Domain.CS_Models.CSICP_NN.CSICP_NN015?> GetByIdAsync(int tenant, string id);
    }
}
