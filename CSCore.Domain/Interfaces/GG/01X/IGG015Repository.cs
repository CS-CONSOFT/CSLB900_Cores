using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.GG._01X
{
    public interface IGG015Repository : IRepositorioBaseMudaAtivo<CSICP_GG015>
    {
        Task<(IEnumerable<CSICP_GG015>, int)> GetListAsync(int tenant, int pageSize, int page, string? search, bool isActive);
        Task<CSICP_GG015?> GetByIdAsync(string id, int tenant);
        Task<int> CreateAsync(CSICP_GG015 gg015Entity, string grupoID, string subGrupoID, IEnumerable<CSICP_BB001> listaTodosEstabelecimentos);
    }
}
