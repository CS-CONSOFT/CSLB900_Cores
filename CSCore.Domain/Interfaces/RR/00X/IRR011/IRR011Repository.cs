using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.RR._00X.IRR011
{
    public interface IRR011Repository : IGetListBase<OsusrTo3CsicpRr011, PrmFiltrosRR011>, IRepositorioBaseV2<OsusrTo3CsicpRr011>
    {
        /// <summary>
        /// Obtém uma Série/RGN por ID
        /// </summary>
        Task<OsusrTo3CsicpRr011?> GetByIdAsync(int tenantId, long id);

        /// <summary>
        /// Obtém lista paginada de Séries/RGN com filtros
        /// </summary>
        Task<(List<OsusrTo3CsicpRr011>, int)> GetListAsync(int tenantId, PrmFiltrosRR011 prm);

    }
}