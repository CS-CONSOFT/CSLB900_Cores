using CSCore.Application.Dto.Dtos.NN.Dto;
using CSCore.Domain.CS_Models.CSICP_NN;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Ifs.NN.NN016
{
    public interface INN016Repository : IRepositorioBase<CSICP_NN016>
    {
        Task<(IEnumerable<CSICP_NN016>, int)> GetListAsync(int tenant,string NN015_ID, int page, int pageSize);
        Task<IEnumerable<CSICP_NN016>> GetListAsyncPorNN015ParaBaixaContasaReceberPagar(int tenant, string InNN015);

        Task<CSICP_NN016?> GetByIdAsync(int tenant, string id);
    }
}
