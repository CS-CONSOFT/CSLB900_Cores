using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.RR._00X.IRR010
{
    /// <summary>
    /// Repository para Condição de Criação (RR010)
    /// Lista para combo disponível em NaoEstaticasComboRepository
    /// </summary>
    public interface IRR010Repository : IRepositorioBaseV2<OsusrTo3CsicpRr010>
    {
        Task<OsusrTo3CsicpRr010?> GetByIdAsync(int tenantId, long id);
        Task<(List<OsusrTo3CsicpRr010>, int)> GetListAsync(int tenantId, PrmFiltrosRR010 prm);
    }
}