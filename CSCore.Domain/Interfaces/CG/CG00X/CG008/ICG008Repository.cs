using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Domain.Interfaces.CG.CG00X.CG008
{
    public interface ICG008Repository : IRepositorioBaseV2<CSICP_CG008>
    {
        Task<CSICP_CG008?> GetByIdAsync(int InTenant, string InIDCG008);
        Task<(List<CSICP_CG008>, int)> GetListAsync(int InTenant, PrmFiltrosCG008Repo InPrm);
    }
}