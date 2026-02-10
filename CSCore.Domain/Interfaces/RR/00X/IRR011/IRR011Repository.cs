using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.RR._00X.IRR011
{
    /// <summary>
    /// Repository para Série/RGN (RR011)
    /// Lista para combo disponível em NaoEstaticasComboRepository
    /// </summary>
    public interface IRR011Repository : IRepositorioBaseV2<OsusrTo3CsicpRr011>
    {
        /// <summary>
        /// Obtém uma Série/RGN por ID
        /// </summary>
        Task<OsusrTo3CsicpRr011?> GetByIdAsync(int tenantId, long id);
    }
}