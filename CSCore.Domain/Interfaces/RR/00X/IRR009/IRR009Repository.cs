using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.Util;

namespace CSCore.Domain.Interfaces.RR._00X.IRR009
{
    public interface IRR009Repository : IRepositorioBaseV2<OsusrTo3CsicpRr009>
    {
        /// <summary>
        /// Obtém relacionamento por ID
        /// </summary>
        Task<OsusrTo3CsicpRr009?> GetByIdAsync(int In_TenantID, string In_IDRR009);

        /// <summary>
        /// Obtém lista de relacionamentos com filtros
        /// </summary>
        Task<(List<OsusrTo3CsicpRr009>, int)> GetListAsync(int In_TenantID, PrmFiltrosRR009 prm);

        /// <summary>
        /// Verifica se um animal (RR001_ID) já existe no relacionamento
        /// </summary>
        Task<bool> ExisteAnimalNoRelacionamentoAsync(int In_TenantID, string In_Rr001Id, string In_Rr001Virtualid);

    }
}