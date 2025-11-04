using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Domain.Interfaces.CG.CG00X.CG009
{
    public interface ICG009Repository : IRepositorioBase<CSICP_CG009>
    {
        Task<CSICP_CG009?> GetByIdAsync(int InTenantID, string InCG009ID);
        Task<CSICP_CG009?> GetByIdComFiltrosAsync(int InTenantID, string InCG006_ID, int Ano, int? Mes, string TipoSaldo);
        Task<(List<CSICP_CG009>, int)> GetListAsync(int InTenantID, PrmFiltrosCG009Repo prm);
    }
}