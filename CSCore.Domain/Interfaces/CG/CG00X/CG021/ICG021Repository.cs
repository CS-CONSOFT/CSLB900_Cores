using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Domain.Interfaces.CG.CG00X.CG021
{
    public interface ICG021Repository : IRepositorioBaseV2<Osusr8dwCsicpCg021>
    {
        Task<Osusr8dwCsicpCg021?> GetByIdAsync(int InTenant, string InIDCG021);
        Task<(List<Osusr8dwCsicpCg021>, int)> GetListAsync(int InTenant, PrmFiltrosCG021Repo InPrm);
    }
}