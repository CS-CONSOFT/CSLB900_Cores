using CSCore.Domain.CS_Models.CSICP_GG;
using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Domain.Interfaces.GG._00X.GG008
{
    /// <summary>
    /// Interface do repositório para GG008RFTransacao - Transação Reforma Tributária
    /// </summary>
    public interface IGG008RFTransacaoRepository : IRepositorioBase<OsusrE9aCsicpGg008rftransacao>
    {
        Task<OsusrE9aCsicpGg008rftransacao> GetByIdAsync(string inGG008RFTID, string? inKardexGG008ID, int inTenantID);
        Task<(IEnumerable<OsusrE9aCsicpGg008rftransacao>, int)> GetListAsync(
            int inTenantID, string? inKardexGG008ID, string? inNcmID, string inFilialID, int inPageSize, int inPageNumber);
    }
}