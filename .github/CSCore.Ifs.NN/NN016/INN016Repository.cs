using CSCore.Domain.CS_Models.CSICP_NN;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.NN.NN016.Dto;

namespace CSCore.Ifs.NN.NN016
{
    public interface INN016Repository : IRepositorioBase<CSICP_NN016>
    {
        Task<(IEnumerable<DtoGetNN016>, int)> GetListAsync(int tenant,string NN015_ID, int page, int pageSize);
        Task<IEnumerable<DtoGetNN016>> GetListAsyncPorNN015ParaBaixaContasaReceberPagar(int tenant, string InNN015);

        Task<DtoGetNN016?> GetByIdAsync(int tenant, string id);
    }
}
