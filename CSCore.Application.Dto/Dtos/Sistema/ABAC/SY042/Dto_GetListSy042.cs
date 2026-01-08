using CSCore.Domain.CS_Models.CSICP_SYS.ABAC;
using CSLB900.MSTools.InterfaceBase;

namespace CSCore.Application.Dto.Dtos.Sistema.ABAC.SY042
{
    public record Dto_GetListSy042 : IConverteParaDTO<ABAC_CSSPH_FILTERSOPERADORES, Dto_GetListSy042>
    {
        public string Id { get; init; } = null!;
        public string? Filterid { get; init; }
        public string? Operatorid { get; init; }

        public static Dto_GetListSy042 FromEntity(ABAC_CSSPH_FILTERSOPERADORES entity)
        {
            return new Dto_GetListSy042
            {
                Id = entity.Id,
                Filterid = entity.Filterid,
                Operatorid = entity.Operatorid
            };
        }
    }
}
