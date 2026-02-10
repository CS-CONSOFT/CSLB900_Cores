using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.RR._00X.IRR010
{
    public interface IRR010Repository : IGetListBase<OsusrTo3CsicpRr010, PrmFiltrosRR010>, IRepositorioBaseV2<OsusrTo3CsicpRr010>
    {
        /// <summary>
        /// Obtém uma Condição de Criação por ID
        /// </summary>
        Task<OsusrTo3CsicpRr010?> GetByIdAsync(int tenantId, long id);

        /// <summary>
        /// Obtém lista paginada de Condições de Criação com filtros
        /// </summary>
        Task<(List<OsusrTo3CsicpRr010>, int)> GetListAsync(int tenantId, PrmFiltrosRR010 prm);

        /// <summary>
        /// Obtém lista simplificada para ComboBox
        /// </summary>
        Task<List<OsusrTo3CsicpRr010>> GetListForComboAsync(int tenantId);
    }
}