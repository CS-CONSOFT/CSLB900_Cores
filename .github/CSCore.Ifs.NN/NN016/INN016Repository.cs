using CSCore.Domain.CS_Models.CSICP_NN;
using CSCore.Domain.Interfaces.V2;
using CSCore.Ifs.NN.NN016.Dto;

namespace CSCore.Ifs.NN.NN016
{
    public interface INN016Repository : IRepositorioBase<CSICP_NN016>
    {
        Task<(IEnumerable<DtoGetNN016>, int)> GetListAsync(int tenant, int page, int pageSize);

        Task<DtoGetNN016?> GetByIdAsync(int tenant, string id);
    }
}
