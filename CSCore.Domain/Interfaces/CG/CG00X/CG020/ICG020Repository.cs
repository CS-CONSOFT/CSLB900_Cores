using CSCore.Domain.CS_Models.CSICP_CG;
using CSCore.Domain.Interfaces.V2;
using CSLB900.MSTools.Util;

namespace CSCore.Domain.Interfaces.CG.CG00X.CG020
{
    public interface ICG020Repository : IRepositorioBaseV2<CSICP_CG020>
    {
        Task<CSICP_CG020?> GetByIdAsync(int InTenant, string InIDCG020);
        Task<(List<CSICP_CG020>, int)> GetListAsync(int InTenant, PrmFiltrosCG020Repo InPrm);
        Task<CSICP_CG020?> GetByIdSituacaoLoteAsync(int InTenant, string InIDCG020);
    }
}