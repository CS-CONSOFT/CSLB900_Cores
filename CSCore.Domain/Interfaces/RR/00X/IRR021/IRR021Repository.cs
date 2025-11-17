using CSCore.Domain.CS_Models.CSICP_RR;
using CSCore.Domain.Interfaces.V2;

namespace CSCore.Domain.Interfaces.RR._00X.IRR021
{
    public interface IRR021Repository : IRepositorioBaseV2<OsusrTo3CsicpRr021>
    {
        Task<(List<OsusrTo3CsicpRr021>, int)> GetListRR021LoteIdAsync(int In_TenantID, PrmFiltrosRR021 prm);
        Task<(List<OsusrTo3CsicpRr021>, int)> GetListRR021ParaPopular(int In_TenantID, string In_UsuarioID, string In_LoteID, DateTime In_DataPeso);
    }
}