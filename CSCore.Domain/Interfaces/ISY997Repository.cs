using CSCore.Domain.CS_Models.CSICP_SYS;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.SY
{
    public interface ISY997Repository : IRepositorioBase<CSICP_SY997_LOGS>
    {
        Task<CSICP_SY997_LOGS?> GetByIdAsync(long id, int tenant);
        Task<IEnumerable<CSICP_SY997_LOGS>> GetListAsync(int tenant, string? search = null, int pageSize = 50, int page = 1);
        Task<IEnumerable<CSICP_SY997_LOGS>> GetByUsuarioAsync(int tenant, string nomeUsuario);
        Task<IEnumerable<CSICP_SY997_LOGS>> GetBySeveridadeAsync(int tenant, string severidade);
        Task<IEnumerable<CSICP_SY997_LOGS>> GetNaoExibidosAsync(int tenant);
        Task<CSICP_SY997_LOGS> MarcarComoExibidoAsync(long id, int tenant);
    }
}