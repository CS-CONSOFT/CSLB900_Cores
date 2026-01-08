using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY042
{
    public record Dto_UpdateSy042 : IConverteParaEntidade<ABAC_CSSPH_FILTERSOPERADORES>
    {
        public string? Filterid { get; init; }
        public string? Operatorid { get; init; }

        public ABAC_CSSPH_FILTERSOPERADORES ToEntity(int tenant, string? id)
        {
            return new ABAC_CSSPH_FILTERSOPERADORES
            {
                Id = id ?? string.Empty,
                Filterid = this.Filterid,
                Operatorid = this.Operatorid
            };
        }
    }
}
